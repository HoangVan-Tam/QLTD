using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.FormChucNang;
using BUL;
using Entities;

namespace GUI.FormQuanLy
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        private CustomerBUL db;
        private BindingSource binding;
        public FormKhachHang(string auth)
        {
            InitializeComponent();
            this.auth = auth;
            db = new CustomerBUL();
            binding = new BindingSource();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigToSuccessView();
                LoadView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(grv_KhachHang);
            txt_DiaChi.ReadOnly = true;
            txt_SoDienThoai.ReadOnly = true;
            txt_TenKhachHang.ReadOnly = true;
            btn_XacNhan.Enabled = false;
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKH frm = new FormThemKH();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            frm.FormClosing += Frm_FormClosing;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                binding.DataSource = db.GetCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpressionMethod.CheckAuth(this.auth))
                {
                    DialogResult result = MessageBox.Show("Xác nhận xóa khách hàng", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (db.DeleteCustomer(Int32.Parse(pictureBox1.Tag.ToString())))
                        {
                            MessageBox.Show("Xóa thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            binding.DataSource = db.GetCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadView()
        {
            binding.DataSource = db.GetCustomers();
            ExpressionMethod.LoadGridControl(grd_KhachHang, grv_KhachHang, binding);
        }

        private void LoadToTextBox(int indexSelected)
        {
            Customer customer = binding[indexSelected] as Customer;
            pictureBox1.Tag = customer.IdCustomer;
            txt_TenKhachHang.Text = customer.CustomerName;
            txt_DiaChi.Text = customer.Address;
            txt_SoDienThoai.Text = customer.PhoneNumber;
        }

        private void grv_KhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LoadToTextBox(grv_KhachHang.GetSelectedRows()[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.CheckSDT() == false)
                return;
            else
            {
                Customer customer = new Customer();
                customer.IdCustomer = Convert.ToInt32(pictureBox1.Tag);
                customer.CustomerName = txt_TenKhachHang.Text;
                customer.PhoneNumber = txt_SoDienThoai.Text;
                customer.Address = txt_DiaChi.Text;
                if (db.UpdateCustomer(customer) == true)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_CapNhat.Text = "Cập nhật";
                    txt_DiaChi.ReadOnly = true;
                    txt_SoDienThoai.ReadOnly = true;
                    txt_TenKhachHang.ReadOnly = true;
                    btn_XacNhan.Enabled = false;
                    binding.DataSource = db.GetCustomers();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(auth) == true)
            {
                if(btn_CapNhat.Text== "Cập nhật")
                {
                    txt_DiaChi.ReadOnly = false;
                    txt_SoDienThoai.ReadOnly = false;
                    txt_TenKhachHang.ReadOnly = false;
                    btn_XacNhan.Enabled = true;
                    btn_CapNhat.Text = "Hủy";
                }
                else
                {
                    txt_DiaChi.ReadOnly = true;
                    txt_SoDienThoai.ReadOnly = true;
                    txt_TenKhachHang.ReadOnly = true;
                    btn_XacNhan.Enabled = false;
                    btn_CapNhat.Text = "Cập nhật";
                }
            }
                
        }
    }
}

