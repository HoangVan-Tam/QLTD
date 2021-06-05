using GUI.FormChucNang;
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
using Entities.DTO;

namespace GUI.FormDichVu
{
    public partial class FormTraDia : DevExpress.XtraEditors.XtraForm
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private ListRentedBUL dbListRented;
        private CustomerBUL dbCustomer;
        private List<DiskHoldByCustomer> lstdiskHoldByCustomers;
        private List<DiskInfoReturn> db;
        private string auth;
        public FormTraDia(string auth)
        {
            InitializeComponent();
            dbListRented = new ListRentedBUL();
            db = ExpressionMethod.DBDiskReturn();
            this.auth = auth;
            dbCustomer = new CustomerBUL();
        }

        private void btn_XacNhanTraDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_NhapMaDia.CheckSDT() == false)
                    return;
                var customer = dbCustomer.GetCustomer(txt_NhapMaDia.Text);
                lstdiskHoldByCustomers = ExpressionMethod.GetAllDiskHoldByCustomers(txt_NhapMaDia.Text);
                if (lstdiskHoldByCustomers == null)
                {
                    MessageBox.Show("Không Tìm Thấy Khách Hàng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (lstdiskHoldByCustomers.Count==0)
                {
                    MessageBox.Show("Khách Hàng Này Không Có Đĩa Để Trả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AddInfo();
                }
                LoadData(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData(Customer customer)
        {
            txtDiaChi.Text = customer.Address;
            txtMaKH.Text = customer.IdCustomer.ToString();
            txtTenKH.Text = customer.CustomerName;
            txtSoDienThoai.Text = customer.PhoneNumber;
        }
        private void LoadView()
        {
            //binding.DataSource = new List<DiskInfoReturn>();
            //ExpressionMethod.LoadGridControl(grc_TraDia, grv_TraDia, binding);
        }

        private void AddColumnToListView()
        {
            lsvDiskHoldByCustomer.Columns.Add("Mã Đơn Thuê", this.Width/6-50);
            lsvDiskHoldByCustomer.Columns.Add("Mã Đĩa", this.Width / 6-50);
            lsvDiskHoldByCustomer.Columns.Add("Mã Tiêu Đề", this.Width / 6-50);
            lsvDiskHoldByCustomer.Columns.Add("Tên Tiêu Đề", this.Width / 2+100);
            lsvDiskHoldByCustomer.Columns.Add("Ngày Thuê", this.Width / 5+25);
            lsvDiskHoldByCustomer.Columns.Add("Ngày Trả", this.Width / 5+25);
        }

        private void AddInfo()
        {
            lsvDiskHoldByCustomer.Items.Clear();
            foreach (var item in lstdiskHoldByCustomers)
            {
                string rentalDate = ((DateTime)item.RentalDate).ToString(DATE_FORMAT);
                string expectedDate = ((DateTime)item.ExpectedReturnDate).ToString(DATE_FORMAT);
                ListViewItem listViewItem = new ListViewItem(new string[] { item.IdListRented.ToString(), item.IdDisk.ToString(), item.IdTitle.ToString(), item.NameTitle, rentalDate, expectedDate });
                listViewItem.Tag = item.IdListRented;
                lsvDiskHoldByCustomer.Items.Add(listViewItem);
            }
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db = ExpressionMethod.DBDiskReturn();
            dbListRented = new ListRentedBUL();
        }

        private void FormTraDia_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
            tablePanel1.Rows[4].Height = 600;
            ExpressionMethod.ConfigListView(lsvDiskHoldByCustomer);

            AddColumnToListView();
        }
        private void ConfigToSuccessView()
        {
           // ExpressionMethod.EditGridView(grv_TraDia);
        }

        private void btnHuyMuc_Click(object sender, EventArgs e)
        {
            //binding.RemoveAt(grv_TraDia.GetSelectedRows()[0]);
        }
        private void ThucHienTraDia()
        {
            for (int i = 0; i < lsvDiskHoldByCustomer.CheckedItems.Count; i++)
            {
                if (dbListRented.ReturnDisk(Convert.ToInt32(lsvDiskHoldByCustomer.CheckedItems[i].Text)) == false)
                {
                    MessageBox.Show("Trả đĩa thất bại", "Trả đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Trả đĩa thành công", "Trả đĩa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThucHienTraDia_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Khách Hàng Để Trả", "Trả đĩa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lsvDiskHoldByCustomer.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vui Lòng Chọn Đĩa Để Trả", "Trả đĩa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Xác nhận trả đĩa", "Trả đĩa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ThucHienTraDia();
                    }
                    var customer = new CustomerBUL().GetCustomer(Int32.Parse(txtMaKH.Text.ToString()));
                    var lstLate = new ListRentedBUL().ListLate(customer.IdCustomer);
                    if (lstLate.Count > 0)
                    {
                        DialogResult result1 = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result1 == DialogResult.Yes)
                        {
                            FormThanhToan frm = new FormThanhToan(customer, lstLate, this.auth);
                            frm.Show();
                            frm.FormClosing += Frm_FormClosing;
                        }
                    }
                }
                lstdiskHoldByCustomers = ExpressionMethod.GetAllDiskHoldByCustomers(txt_NhapMaDia.Text);
                AddInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại thông tin trả đĩa", "Trả đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
