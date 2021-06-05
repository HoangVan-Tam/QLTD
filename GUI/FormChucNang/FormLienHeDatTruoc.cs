using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BUL;
namespace GUI.FormChucNang
{
    public partial class FormLienHeDatTruoc : DevExpress.XtraEditors.XtraForm
    {
        private const string STATUS_ONSHELF = "OnShelf";
        private DetailPreOrderBUL dbDetail;
        private ListTitlePreOrderBUL dbListPreOrder;
        private TitleBUL dbTitle;
        private DiskBUL dbDisk;
        private BindingSource bindingDSTilte;
        private BindingSource bindingDSDatTruoc;
        private DiskTypeBUL dbDiskType;
        private CustomerBUL dbCustomer;
        public FormLienHeDatTruoc()
        {
            InitializeComponent();
            dbDetail = new DetailPreOrderBUL();
            dbListPreOrder = new ListTitlePreOrderBUL();
            dbListPreOrder = new ListTitlePreOrderBUL();
            dbTitle = new TitleBUL();
            dbDisk = new DiskBUL();
            dbDiskType = new DiskTypeBUL();
            dbCustomer = new CustomerBUL();
            bindingDSTilte = new BindingSource();
            bindingDSDatTruoc = new BindingSource();
        }

        private void FormLienHeDatTruoc_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigToSuccessForm();
                LoadNhungTieuDeDangChoAccept();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigToSuccessForm()
        {
            tablePanel1.Rows[0].Height = tablePanel1.Rows[1].Height;
            ExpressionMethod.EditGridView(grvDSTieuDe);
            ExpressionMethod.EditGridView(grvDSGanDia);
            bindingDSTilte.DataSource = null;
            ExpressionMethod.LoadGridControl(grcDSTieuDe, grvDSTieuDe, bindingDSTilte);
            ExpressionMethod.LoadGridControl(grc_DSGanDia, grvDSGanDia, bindingDSDatTruoc);

        }
        private void LoadNhungTieuDeDangChoAccept()
        {
            //Load những cái tiêu đề nào có đĩa đang chờ được accept
            var db = dbDetail.GetDetailPreOrders().Where(x => x.Accepted == false)
                .Join(dbDisk.GetDisks(), dt => dt.IdDisk, d => d.IdDisk, (dt, d) => new { dt, d })
                .Join(dbTitle.GetTitles(), dtd => dtd.d.IdTitle, t => t.IdTitle, (dtd, t) => new { dtd, t }).ToList();
            var lstTitle = dbTitle.GetTitles().Where(x => db.Find(k => k.t.IdTitle == x.IdTitle) != null).ToList()
                .Join(dbDiskType.GetDiskTypes(), t => t.IdDiskType, dt => dt.IdDiskType, (t, dt) => new TitleOrder { IdTitle = t.IdTitle, NameTitle = t.NameTitle, TitleType = dt.TypeName });
            bindingDSTilte.DataSource = lstTitle;
            dbDetail = new DetailPreOrderBUL();
            dbDisk = new DiskBUL();
            dbTitle = new TitleBUL();
            if (lstTitle.Count() == 0)
            {
                btnChapNhan.Enabled = false;
                btnHuyMuc.Enabled = false;
            }
        }
        private void ThucHienKiemTraNguoiDatDia()
        {
            var db = dbDetail.GetDetailPreOrders().Where(x => x.Accepted == false)
               .Join(dbDisk.GetDisks(), dt => dt.IdDisk, d => d.IdDisk, (dt, d) => new { dt, d })
               .Join(dbTitle.GetTitles(), dtd => dtd.d.IdTitle, t => t.IdTitle, (dtd, t) => new { dtd, t }).ToList();
            if (bindingDSTilte[grvDSTieuDe.GetSelectedRows()[0]] is TitleOrder == false)
                return;
            //Kiểm tra tiêu đề đang được chọn
            int tieude = ((TitleOrder)bindingDSTilte[grvDSTieuDe.GetSelectedRows()[0]]).IdTitle;
            //Danh sách đặt là gì
            int idDsDat = (int)db.Find(x => x.t.IdTitle == tieude).dtd.dt.IdListTitlePreOrder;
            var DsDat = dbListPreOrder.GetListTitlePreOrder(idDsDat);
            //Lấy khách hàng 
            var customer = dbCustomer.GetCustomer((int)DsDat.IdCustomer);
            txt_DiaChi.Text = customer.Address;
            txt_SoDienThoai.Text = customer.PhoneNumber;
            txt_TenKhachHang.Text = customer.CustomerName;
            // lay ra danh sach cua nhung thang nao la khach hang
            var lstPreOrderOfCustomer = dbListPreOrder.GetListTitlePreOrders().Where(x => x.IdCustomer == customer.IdCustomer).ToList();
            // lay danh sach  nhung thang nao thuoc lst id vua lay
            var lstOfCus = db.Where(d => lstPreOrderOfCustomer.Find(x => x.IdListTitlePreOrder == d.dtd.dt.IdListTitlePreOrder) != null && d.dtd.dt.Accepted == false).Select(x => new MyDeTailOrder { IdDetailPreOrder = x.dtd.dt.IdDetailPreOrder, IdDisk = x.dtd.d.IdDisk, Title = x.t.NameTitle }).ToList();
            bindingDSDatTruoc.DataSource = lstOfCus;
        }

        private void grvDSTieuDe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ThucHienKiemTraNguoiDatDia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                AcceptFromList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
      
        }
        private void AcceptFromList()
        {
            DialogResult result=MessageBox.Show("Xác nhận lấy đĩa", "Lấy Đĩa Đặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Doi tat ca trong list thành accept
                foreach (var item in bindingDSDatTruoc.DataSource as List<MyDeTailOrder>)
                {
                    dbDetail.UpdateAccepted(item.IdDetailPreOrder);
                    //cap nhat trang thai dia
                }
                MessageBox.Show("Thực hiện chấp thuận lấy đĩa thành công", "Lấy Đĩa Đặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhungTieuDeDangChoAccept();
                ThucHienKiemTraNguoiDatDia();
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            try
            {
                DenyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }
        private void DenyList()
        {
            DialogResult result = MessageBox.Show("Xác nhận từ chối không lấy đĩa", "Lấy Đĩa Đặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Xoa het o list detail 
                foreach (var item in bindingDSDatTruoc.DataSource as List<MyDeTailOrder>)
                {
                    dbDetail.DeleteDetailPreOrder(item.IdDetailPreOrder);
                    //cap nhat trang thai dia
                    var disk = dbDisk.GetDisk(item.IdDisk);
                    disk.DiskRentalStatus = STATUS_ONSHELF;
                    dbDisk.UpdateDisk(disk);
                }
                LoadNhungTieuDeDangChoAccept();
                ThucHienKiemTraNguoiDatDia();
            }
            
           
        }
        private void DenyAtLocation()
        {

            DialogResult result = MessageBox.Show("Xác nhận bỏ mục này", "Lấy Đĩa Đặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var dto = bindingDSDatTruoc[grvDSGanDia.GetSelectedRows()[0]] as MyDeTailOrder;
                bindingDSDatTruoc.RemoveAt(grvDSGanDia.GetSelectedRows()[0]);
                dbDetail.DeleteDetailPreOrder(dto.IdDetailPreOrder);
                var disk = dbDisk.GetDisk(dto.IdDisk);
                disk.DiskRentalStatus = STATUS_ONSHELF;
                dbDisk.UpdateDisk(disk);
                LoadNhungTieuDeDangChoAccept();
                ThucHienKiemTraNguoiDatDia();
            }
        }

        private void btnHuyMuc_Click(object sender, EventArgs e)
        {
            try
            {
                DenyAtLocation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
    }
}
