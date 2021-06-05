using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using Entities;

namespace GUI.FormChucNang
{
    public partial class FormThanhToan : Form
    {
        private ListRentedBUL db;
        private Customer customer;
        private string auth;
        private List<ListRented> lstRented;
        private const string FORMAT_DATE= "dd/MM/yyyy";
        private const string STATUS_PAID = "Paid";
        public FormThanhToan(Customer customer, List<ListRented> lstRented, string auth)
        {
            InitializeComponent();
            this.customer = customer;
            this.lstRented = lstRented;
            this.auth = auth;

            db = new ListRentedBUL();
        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                AddInfoToSuccessForm();
                tablePnl.Rows[2].Height = this.Height - 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddInfoToSuccessForm()
        {
            ExpressionMethod.ConfigListView(lstvThanhToanTreHan);
            AddColumnToListView();
        }
        private void AddColumnToListView()
        {
            lstvThanhToanTreHan.Columns.Add("Mã Đĩa", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("Tiêu Đề", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("TG Thuê", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("TG Dự Tính", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("TG Trả", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("Phí Trễ", this.Width / 6);
            AddInfo();
        }
        private void AddInfo()
        {
            txtMaKH.Text = customer.IdCustomer.ToString();
            txtTenKH.Text = customer.CustomerName;
            lstvThanhToanTreHan.Items.Clear();
            foreach (var item in lstRented)
            {
                string rentalDate = ((DateTime)item.RentalDate).ToString(FORMAT_DATE);
                string expectedDate = ((DateTime)item.ExpectedReturnDate).ToString(FORMAT_DATE);
                string actualDate = ((DateTime)item.ActualReturnDate).ToString(FORMAT_DATE);
                ListViewItem listViewItem = new ListViewItem(new string[] {item.IdDisk.ToString(),"1",rentalDate,expectedDate,actualDate,item.LateFee.ToString()});
                listViewItem.Tag = item.IdListRented;
                lstvThanhToanTreHan.Items.Add(listViewItem);
            }
        }

        private void btnHuyKhoanTre_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
               DialogResult result= MessageBox.Show("Xác nhận xóa khoản trễ này", "Xóa khoản trễ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ThucHienXoaKhoanTre();
                }
            }
        }
        private void ThucHienXoaKhoanTre()
        {
            int idListRented = Int32.Parse(lstvThanhToanTreHan.SelectedItems[0].Tag.ToString());
            if (db.DeleteListRented(idListRented))
            {
                MessageBox.Show("Xóa khoản trễ thành công", "Xóa khoản trễ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstvThanhToanTreHan.Items.Remove(lstvThanhToanTreHan.SelectedItems[0]);
            }
            else
                MessageBox.Show("Xóa khoản trễ thất bại", "Xóa khoản trễ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstvThanhToanTreHan_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            double tong = 0;
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
            {
                if (lstvThanhToanTreHan.Items[i].Checked)
                    tong += Int32.Parse(lstvThanhToanTreHan.Items[i].SubItems[5].Text.ToString());
            }
            txtTongTien.Text = tong.ToString();
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
                lstvThanhToanTreHan.Items[i].Checked = true;

        }

        private void btnHuyTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
                lstvThanhToanTreHan.Items[i].Checked = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận thanh toán ", "Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ThucHienThanhToan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThucHienThanhToan()
        {
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
            {
                if (lstvThanhToanTreHan.Items[i].Checked == true)
                {
                    var item = lstRented[i];
                    item.StatusOnBill = STATUS_PAID;
                    bool check = db.UpdateListRented(item);
                    if (check == false)
                    {
                        MessageBox.Show("Thực hiện thanh toán thất bại", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            MessageBox.Show("Thực hiện thanh toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.lstRented = db.ListLate(customer.IdCustomer);
            AddInfo();
        }
    }
}
