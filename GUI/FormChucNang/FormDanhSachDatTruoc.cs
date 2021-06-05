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
    public partial class FormDanhSachDatTruoc : DevExpress.XtraEditors.XtraForm
    {
        private ListTitlePreOrderBUL dbListTitlePre;
        private DetailPreOrderBUL dbDetailPre;
        private TitleBUL dbTitle;
        private DiskBUL dbDisk;
        private CustomerBUL dbCus;
        private BindingSource bindingDSDatTruoc;
        private BindingSource bindingChiTietDatTruoc;
        private const string STATUS_INCOMPLETED = "Incompleted";
        private const string STATUS_ONSHELF = "OnShelf";
        public FormDanhSachDatTruoc()
        {
            InitializeComponent();
            dbDetailPre = new DetailPreOrderBUL();
            dbListTitlePre = new ListTitlePreOrderBUL();
            dbTitle = new TitleBUL();
            dbDisk = new DiskBUL();
            dbCus = new CustomerBUL();
            bindingChiTietDatTruoc = new BindingSource();
            bindingDSDatTruoc = new BindingSource();
        }

        private void FormDanhSachDatTruoc_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
            LoadView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(grvDSDatTruoc);
            ExpressionMethod.LoadGridControl(grdc_DanhSach, grvDSDatTruoc, bindingDSDatTruoc);
        }
        private void LoadView()
        {
            try
            {
                LoadDanhSachDatTruoc();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void LoadDanhSachDatTruoc()
        {
            // Load những list nào đang imcomplete và những list nào complete nhưng id list vẫn còn ở dưới detail

            var data = dbListTitlePre.GetListTitlePreOrders().Where(x => x.StatusProcess.Equals(STATUS_INCOMPLETED) || dbDetailPre.GetDetailPreOrders().Find(d => d.IdListTitlePreOrder == x.IdListTitlePreOrder) != null)
            .Join(dbTitle.GetTitles(), dt => dt.IdTitle, t => t.IdTitle, (dt, t) => new { dt, t })
            .Join(dbCus.GetCustomers(), dtt => dtt.dt.IdCustomer, c => c.IdCustomer, (dtt, c) => new MyListTitlePreOrder { IdCustomer = c.IdCustomer, IdListPreOrder = dtt.dt.IdListTitlePreOrder, NameCustomer = c.CustomerName, NameTitle = dtt.t.NameTitle });
            bindingDSDatTruoc.DataSource = data;
            dbListTitlePre = new ListTitlePreOrderBUL();
            dbCus = new CustomerBUL();
            dbTitle = new TitleBUL();
            dbDetailPre = new DetailPreOrderBUL();



        }
        private void LoaiBoDatTruoc(int idListTitlePreOrder)
        {

            //Neu update truoc thi dia lien tuc duoc them vao gay ra loi
            List<Disk> lstUpdate = new List<Disk>();
            //Xóa detail và cập nhật trạng thái đĩa
            foreach (var item in dbDetailPre.GetDetailPreOrders())
            {
                if (item.IdListTitlePreOrder == idListTitlePreOrder)
                {
                    var disk = dbDisk.GetDisk((int)item.IdDisk);
                    dbDetailPre.DeleteDetailPreOrder(item.IdDetailPreOrder);
                    lstUpdate.Add(disk);
                }
            }
            dbListTitlePre.DeleteListTitlePreOrder(idListTitlePreOrder);
            foreach (var item in lstUpdate)
            {
                item.DiskRentalStatus = STATUS_ONSHELF;
                dbDisk.UpdateDisk(item);
            }
            DialogResult result = MessageBox.Show("Hủy Mục Thành Công", "Hủy đặt trước", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbDisk = new DiskBUL();
            dbDetailPre = new DetailPreOrderBUL();
            LoadView();

        }

        private void btnHuyDatTruoc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Chắc chắn muốn hủy mục này", "Hủy đặt trước", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var lstPreOrder = bindingDSDatTruoc[grvDSDatTruoc.GetSelectedRows()[0]] as MyListTitlePreOrder;
                    LoaiBoDatTruoc(lstPreOrder.IdListPreOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
