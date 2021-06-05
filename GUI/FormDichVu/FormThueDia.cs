using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GUI.FormChucNang;
using BUL;
using Entities;
using Entities.DTO;
using DevExpress.XtraEditors.Repository;
using System.Globalization;

namespace GUI.FormDichVu
{
    public partial class FormThueDia : DevExpress.XtraEditors.XtraForm
    {
        private TitleBUL dbTitle;
        private DiskBUL dbDisk;
        private CustomerBUL dbCus;
        private ListRentedBUL dbRented;
        private List<DiskInfoRent> db;
        private BindingSource binding;
        private string auth;
        private const string STATUS_RENTED = "Rented";
        private const string STATUS_ONHOLD = "OnHold";
        private double totalRent = 0;
        private List<Disk> lstDisk;
        private double totalOnHold = 0;
        public FormThueDia(string auth)
        {
            InitializeComponent();
            dbTitle = new TitleBUL();
            dbCus = new CustomerBUL();
            dbDisk = new DiskBUL();
            dbRented = new ListRentedBUL();
            db = ExpressionMethod.DBDiskRent();
            this.binding = new BindingSource();
            this.auth = auth;
            lstDisk = new List<Disk>();
        }

        private void FormThueDia_Load(object sender, EventArgs e)
        {
            try
            {
                AddInfoToAccessForm();
                LoadView();
                LoadCombobox();
                ExpressionMethod.ConfigListView(lsvDiaTheoTieuDe);
                ExpressionMethod.ConfigListView(lsvBangXepHang);
                lsvBangXepHang.CheckBoxes = false;
                LoadListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadListView()
        {
            lsvDiaTheoTieuDe.Columns.Add("Mã Đĩa", this.Width/20);
            lsvDiaTheoTieuDe.Columns.Add("Tên Tiêu Đề", this.Width/5);
            lsvDiaTheoTieuDe.Columns.Add("Trạng Thái Đĩa", this.Width/16);
        }
        private void AddDataToListView(int titleId, string nameTitle)
        {
            lstDisk = dbDisk.GetDiskRamdon(titleId).Where(p=>p.DiskStatus=="Good").ToList();
            lsvDiaTheoTieuDe.Items.Clear();
            foreach (var item in lstDisk)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.IdDisk.ToString(), nameTitle, item.DiskStatus});
                lsvDiaTheoTieuDe.Items.Add(listViewItem);
            }
        }

        public void LoadCombobox()
        {
            var lst = dbTitle.GetListTitles();
            RepositoryItemComboBox lstItem = cbo_TieuDe.Properties;
            foreach(var item in lst)
            {
                lstItem.Items.Add(item.NameTitle);
            }
            cbo_TieuDe.SelectedIndex = -1;
            cbo_BXH.Items.Add("Tiêu Đề Mới");
            cbo_BXH.Items.Add("Tiêu Đề Được Nhiều Người Đặt Trong Tháng " + DateTime.Now.Month);
            cbo_BXH.Items.Add("Tiêu Đề Được Nhiều Người Đặt Trong Tuần");
            cbo_BXH.Items.Add("Tiêu Đề Được Nhiều Người Đặt Trong Năm");
            cbo_BXH.SelectedIndex = -1;
        }

        private void AddInfoToAccessForm()
        {
            tablePnl.Rows[4].Height = 300;
            ExpressionMethod.EditGridView(grv_ThueDia);
            ExpressionMethod.ConfigListView(lsvOnHold);
            AddColumnToList();
        }


        private void AddColumnToList()
        {
            lsvOnHold.Columns.Add("Mã Đĩa", this.Width / 7);
            lsvOnHold.Columns.Add("Tiêu Đề", this.Width / 7);
            lsvOnHold.Columns.Add("Loại Đĩa", this.Width / 7);
            lsvOnHold.Columns.Add("Thời Gian Thuê", this.Width / 7);
            lsvOnHold.Columns.Add("Phí Trễ", this.Width / 7);
            lsvOnHold.Columns.Add("Giá Thuê", this.Width / 7);
            lsvOnHold.Columns.Add("Trạng Thái Thuê", this.Width / 7);
        }


        private void LoadView()
        {
            binding.DataSource = new List<DiskInfoRent>();
            ExpressionMethod.LoadGridControl(grdc_DSThueDia, grv_ThueDia, binding);
        }


        private void AddInfoListView()
        {
            //Thieu ne
            lsvOnHold.Items.Clear();
            int IdCustomer = Int32.Parse(txtMaKH.Text.ToString());
            var dbOnHold = db
                .Join(new DetailPreOrderBUL().GetDetailPreOrders().Where(x => x.Accepted == true && x.IdCustomer == IdCustomer), x => x.IdDisk, pre => pre.IdDisk, (x, pre) => new { x, pre });
            //.Join(new ListTitlePreOrderBUL().GetListTitlePreOrders().Where(x => x.IdCustomer == IdCustomer),xpre=>xpre.pre.id)


            foreach (var item in dbOnHold)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.x.IdDisk.ToString(), item.x.Title, item.x.TypeName, item.x.TimeRented.ToString(), item.x.LateFee.ToString(), item.x.Price.ToString(), item.x.DiskRentalStatus });
                listViewItem.Tag = item.pre;
                lsvOnHold.Items.Add(listViewItem);
            }
        }


        private void LoadDataCustomerToText(Customer customer)
        {
            txtDiaChi.Text = customer.Address;
            txtMaKH.Text = customer.IdCustomer.ToString();
            txtSoDienThoai.Text = customer.PhoneNumber;
            txtTenKH.Text = customer.CustomerName;
        }


        private void btn_TimKiemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaKHNhapVao.CheckSDT() == false)
                    return;
                string customerId = txt_MaKHNhapVao.Text.ToString();
                Customer customer = dbCus.GetCustomer(customerId);
                if (customer == null)
                {
                    DialogResult result= MessageBox.Show("Không tìm thấy khách hàng\n\nCó muốn thêm khách hàng này không?", "Thông tin khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FormThemKH frm = new FormThemKH(txt_MaKHNhapVao.Text);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    LoadDataCustomerToText(customer);
                    AddInfoListView();
                    var lstLate = new ListRentedBUL().ListLate(customer.IdCustomer);
                    if (lstLate.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            FormThanhToan frm = new FormThanhToan(customer, lstLate, this.auth);
                            frm.ShowDialog();
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ThemDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDiaTheoTieuDe.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < lsvDiaTheoTieuDe.CheckedItems.Count; i++)
                    {
                        var idDisk = lsvDiaTheoTieuDe.CheckedItems[i].SubItems[0].Text;
                        AddDiskToListRent(db.Where(p => p.IdDisk == Convert.ToInt32(idDisk)).FirstOrDefault());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddDiskToListRent(DiskInfoRent disk)
        {
            if (disk.DiskRentalStatus.Equals(STATUS_RENTED))
            {
                MessageBox.Show("Đĩa này đã được thuê", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (disk.DiskRentalStatus.Equals(STATUS_ONHOLD))
            {
                MessageBox.Show("Đĩa này đã được đặt trước", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (binding.Contains(disk))
            {
                MessageBox.Show("Đĩa này đã tồn tại trong danh sách", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Thêm vào danh sách

            binding.Add(disk);

        }


        private void btnLoaiBoKhoiDS_Click(object sender, EventArgs e)
        {
            try
            {
                binding.RemoveAt(grv_ThueDia.GetSelectedRows()[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void grv_ThueDia_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                this.totalRent = 0;
                foreach (var item in binding.DataSource as List<DiskInfoRent>)
                {
                    this.totalRent += item.Price;
                }
                txtTongTien.Text = (totalRent + totalOnHold).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThucHienThueDia()
        {
            if (txtMaKH.CheckMa() == false)
                return;
            ThucHienLayDiaDatTruoc();
            int idCustomer = Int32.Parse(txtMaKH.Text.ToString());
            foreach (var item in binding.DataSource as List<DiskInfoRent>)
            {
                ListRented rented = new ListRented { IdDisk = item.IdDisk, IdCustomer = idCustomer, LateFee = item.LateFee, RentalDate = DateTime.Today, ExpectedReturnDate = DateTime.Today.AddDays(item.TimeRented), ActualReturnDate = null, StatusOnBill = null };
                if (dbRented.AddListRented(rented) == false)
                {
                    MessageBox.Show("Thuê đĩa thất bại", "Thuê đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Thuê đĩa thành công", "Thuê đĩa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db = ExpressionMethod.DBDiskRent();
            binding.DataSource = new List<DiskInfoRent>();
            cbo_TieuDe.Text = "";
            lsvDiaTheoTieuDe.Items.Clear();
            cbo_BXH.Text = "";
            lsvBangXepHang.Items.Clear();
        }


        private void ThucHienLayDiaDatTruoc()
        {

            if (txtMaKH.CheckMa() == false)
                return;
            DetailPreOrderBUL dbpre = new DetailPreOrderBUL();
            int idCustomer = Int32.Parse(txtMaKH.Text.ToString());
            for (int i = 0; i < lsvOnHold.Items.Count; i++)
            {
                if (lsvOnHold.Items[i].Checked)
                {
                    dbRented.AddListRented(ListItemToListRented(lsvOnHold.Items[i]));
                }
                DetailPreOrder pre = lsvOnHold.Items[i].Tag as DetailPreOrder;
                dbpre.DeleteDetailPreOrder(pre.IdDetailPreOrder);
            }
            AddInfoListView();
        }


        private ListRented ListItemToListRented(ListViewItem item)
        {
            int idDisk = Int32.Parse(item.SubItems[0].Text.ToString());
            int idCustomer = Int32.Parse(txtMaKH.Text.ToString());
            int timeRent = Int32.Parse(item.SubItems[3].Text.ToString());
            double lateFee = double.Parse(item.SubItems[4].Text.ToString());
            ListRented rented = new ListRented
            {
                ActualReturnDate = null,
                RentalDate = DateTime.Today,
                ExpectedReturnDate = DateTime.Today.AddDays(timeRent),
                IdCustomer = idCustomer,
                IdDisk = idDisk,
                LateFee = lateFee,
                StatusOnBill = null
            };
            return rented;
        }


        private void btnXacNhanThueDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Chưa Có Thông Tin Khách Hàng", "Thuê đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (binding.Count==0 && lsvOnHold.CheckedItems.Count==0)
                {
                    MessageBox.Show("Khách Hàng Chưa Thêm Đĩa Vào Danh Sách Thuê", "Thuê đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Xác nhận thuê đĩa", "Thuê đĩa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        ThucHienThueDia();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void lsvOnHold_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                this.totalOnHold = 0;
                for (int i = 0; i < lsvOnHold.Items.Count; i++)
                {
                    if (lsvOnHold.Items[i].Checked == true)
                        this.totalOnHold += double.Parse(lsvOnHold.Items[i].SubItems[5].Text.ToString());
                }
                txtTongTien.Text = (totalRent + totalOnHold).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lsvOnHold.Items.Count; i++)
                {
                    lsvOnHold.Items[i].Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRemoveAllCheck_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lsvOnHold.Items.Count; i++)
                {
                    lsvOnHold.Items[i].Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_TieuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var title = dbTitle.GetTitleByNameTitle(cbo_TieuDe.SelectedItem.ToString());
            if (title != null)
            {
                AddDataToListView(title.IdTitle, cbo_TieuDe.SelectedItem.ToString());
            }
            if (cbo_TieuDe.Text == "")
            {
                lsvDiaTheoTieuDe.Items.Clear();
                cbo_TieuDe.ClosePopup();
            }
        }

        private void cbo_TieuDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbo_TieuDe.Text =="")
            {
                cbo_TieuDe.ShowPopup();
            }
        }

        private void cbo_TieuDe_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbo_TieuDe.Text == "")
            {
                cbo_TieuDe.ClosePopup();
            }
        }

        private void cbo_BXH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBXH();
        }

        private void LoadBXH()
        {
            if (cbo_BXH.Text == "Tiêu Đề Mới")
            {
                var listTitle = dbTitle.GetNewTitle();
                lsvBangXepHang.Columns.Clear();
                lsvBangXepHang.Items.Clear();
                lsvBangXepHang.Columns.Add("Mã Tiêu Đề");
                lsvBangXepHang.Columns.Add("Số Lượng Đĩa Trên Kệ");
                lsvBangXepHang.Columns.Add("Tên Tiêu Đề");
                foreach (var item in listTitle)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] { item.IdTitle.ToString(), item.TotalDiskOnShelf.ToString(), item.NameTitle });
                    lsvBangXepHang.Items.Add(listViewItem);
                }
                lsvBangXepHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (cbo_BXH.Text == "Tiêu Đề Được Nhiều Người Đặt Trong Tháng "+DateTime.Now.Month)
            {
                var temp = dbRented.GetListRenteds().
                        Join(dbDisk.GetDisks(), r => r.IdDisk, d => d.IdDisk, (r, d) => new { r, d }).
                        Join(dbTitle.GetListTitles(), rd => rd.d.IdTitle, t => t.IdTitle, (rd, t) => new { rd, t })
                        .Where(p => p.rd.r.RentalDate.Value.Month == DateTime.Now.Month)
                        .GroupBy(p => p.t.IdTitle)
                        .Select(x => new
                        {
                            idTitle = x.Key,
                            nameTile = x.Select(o => o.t.NameTitle).FirstOrDefault(),
                            number = x.Select(o => o.t.IdTitle),
                            totalDiskOnShelf = x.Select(p=>p.t.TotalDiskOnShelf).FirstOrDefault(),
                        }).OrderByDescending(p=>p.number.Count()).Take(10);

                lsvBangXepHang.Columns.Clear();
                lsvBangXepHang.Items.Clear();
                lsvBangXepHang.Columns.Add("Mã Tiêu Đề");
                lsvBangXepHang.Columns.Add("Tên Tiêu Đề");
                lsvBangXepHang.Columns.Add("Số Lượng Đĩa Trên Kệ");
                lsvBangXepHang.Columns.Add("Số Lượng Lượt Thuê");
                foreach (var item in temp)
                {
                    var tempTotal = dbTitle.CountNumberDiskOnShelf(item.idTitle, item.totalDiskOnShelf.Value);
                    ListViewItem listViewItem = new ListViewItem(new string[] {item.idTitle.ToString(), item.nameTile, tempTotal.ToString(), item.number.Count().ToString()});
                    lsvBangXepHang.Items.Add(listViewItem);
                }
                lsvBangXepHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lsvBangXepHang.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                //MessageBox.Show(temp[0].idTitle.ToString() + " " + temp[0].nameTile+" "+ temp[0].number.Count().ToString());
            }
            else if (cbo_BXH.Text == "Tiêu Đề Được Nhiều Người Đặt Trong Tuần")
            {
                var firstDayOfWeek = ExpressionMethod.GetFirstDayOfWeek(DateTime.Now);
                var ls = firstDayOfWeek.AddDays(7).Date;
                var temp = dbRented.GetListRenteds().
                        Join(dbDisk.GetDisks(), r => r.IdDisk, d => d.IdDisk, (r, d) => new { r, d }).
                        Join(dbTitle.GetListTitles(), rd => rd.d.IdTitle, t => t.IdTitle, (rd, t) => new { rd, t })
                        .Where(p => p.rd.r.RentalDate.Value.Date >= firstDayOfWeek.Date && p.rd.r.RentalDate <= firstDayOfWeek.AddDays(7).Date)
                        .GroupBy(p => p.t.IdTitle)
                        .Select(x => new
                        {
                            idTitle = x.Key,
                            nameTile = x.Select(o => o.t.NameTitle).FirstOrDefault(),
                            number = x.Select(o => o.t.IdTitle),
                            totalDiskOnShelf = x.Select(p => p.t.TotalDiskOnShelf).FirstOrDefault(),
                        }).OrderByDescending(p => p.number.Count()).Take(10);

                lsvBangXepHang.Columns.Clear();
                lsvBangXepHang.Items.Clear();
                lsvBangXepHang.Columns.Add("Mã Tiêu Đề");
                lsvBangXepHang.Columns.Add("Tên Tiêu Đề");
                lsvBangXepHang.Columns.Add("Số Lượng Đĩa Trên Kệ");
                lsvBangXepHang.Columns.Add("Số Lượng Lượt Thuê");
                foreach (var item in temp)
                {
                    var tempTotal = dbTitle.CountNumberDiskOnShelf(item.idTitle, item.totalDiskOnShelf.Value);
                    ListViewItem listViewItem = new ListViewItem(new string[] { item.idTitle.ToString(), item.nameTile, tempTotal.ToString(), item.number.Count().ToString() });
                    lsvBangXepHang.Items.Add(listViewItem);
                }
                lsvBangXepHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lsvBangXepHang.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                //MessageBox.Show(temp[0].idTitle.ToString() + " " + temp[0].nameTile+" "+ temp[0].number.Count().ToString());
            }
            else if (cbo_BXH.Text == "Tiêu Đề Được Nhiều Người Đặt Trong Năm")
            {
                var temp = dbRented.GetListRenteds().
                        Join(dbDisk.GetDisks(), r => r.IdDisk, d => d.IdDisk, (r, d) => new { r, d }).
                        Join(dbTitle.GetListTitles(), rd => rd.d.IdTitle, t => t.IdTitle, (rd, t) => new { rd, t })
                        .Where(p => p.rd.r.RentalDate.Value.Year == DateTime.Now.Year)
                        .GroupBy(p => p.t.IdTitle)
                        .Select(x => new
                        {
                            idTitle = x.Key,
                            nameTile = x.Select(o => o.t.NameTitle).FirstOrDefault(),
                            number = x.Select(o => o.t.IdTitle),
                            totalDiskOnShelf = x.Select(p => p.t.TotalDiskOnShelf).FirstOrDefault(),
                        }).OrderByDescending(p => p.number.Count()).Take(10);

                lsvBangXepHang.Columns.Clear();
                lsvBangXepHang.Items.Clear();
                lsvBangXepHang.Columns.Add("Mã Tiêu Đề");
                lsvBangXepHang.Columns.Add("Tên Tiêu Đề");
                lsvBangXepHang.Columns.Add("Số Lượng Đĩa Trên Kệ");
                lsvBangXepHang.Columns.Add("Số Lượng Lượt Thuê");
                foreach (var item in temp)
                {
                    var tempTotal = dbTitle.CountNumberDiskOnShelf(item.idTitle, item.totalDiskOnShelf.Value);
                    ListViewItem listViewItem = new ListViewItem(new string[] { item.idTitle.ToString(), item.nameTile, tempTotal.ToString(), item.number.Count().ToString() });
                    lsvBangXepHang.Items.Add(listViewItem);
                }
                lsvBangXepHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lsvBangXepHang.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                //MessageBox.Show(temp[0].idTitle.ToString() + " " + temp[0].nameTile+" "+ temp[0].number.Count().ToString());
            }
        }

        private void lsvBangXepHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lsvBangXepHang.SelectedItems.Count > 0)
            {
                cbo_TieuDe.Text = "";
                if (cbo_BXH.Text == "Tiêu Đề Mới")
                {
                    AddDataToListView(Convert.ToInt32(lsvBangXepHang.SelectedItems[0].SubItems[0].Text), lsvBangXepHang.SelectedItems[0].SubItems[2].Text);
                }
                else
                {
                    AddDataToListView(Convert.ToInt32(lsvBangXepHang.SelectedItems[0].SubItems[0].Text), lsvBangXepHang.SelectedItems[0].SubItems[1].Text);
                }
            }
        }
    }
}
