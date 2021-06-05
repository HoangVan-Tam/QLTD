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
    public partial class FormThemKH : Form
    {
        private CustomerBUL db;
        private string phoneNumber;
        public FormThemKH()
        {
            InitializeComponent();
            db = new CustomerBUL();
        }
        public FormThemKH(string _phoneNumber)
        {
            InitializeComponent();
            db = new CustomerBUL();
            phoneNumber = _phoneNumber;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoDienThoai.CheckSDT() == false)
                    return;
                if (db.GetCustomer(txt_SoDienThoai.Text) != null)
                {
                    MessageBox.Show("Số điện thoại của khách hàng đã được đăng ký", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult result = MessageBox.Show("Xác nhận thêm khách hàng", "Thêm khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Customer customer = new Customer { PhoneNumber = txt_SoDienThoai.Text.ToString(), Address = txt_DiaChi.Text.ToString(), CustomerName = txt_TenKhachHang.Text.ToString() };
                    if (db.AddCustomer(customer))
                    {
                        MessageBox.Show("Thêm thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenKhachHang.Text = "";
        }

        private void FormThemKH_Load(object sender, EventArgs e)
        {
            if (phoneNumber != "")
            {
                txt_SoDienThoai.Text = phoneNumber;
            }
        }
    }
}
