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

namespace GUI.FormQuanLy
{
    public partial class FormCD : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        private BindingSource binding;
        private DiskBUL db;
        public FormCD(string auth)
        {
            InitializeComponent();
            this.auth = auth;
            btn_XacNhan.Enabled = false;
            db = new DiskBUL();
            binding = new BindingSource();
        }

        private void FormCD_Load(object sender, EventArgs e)
        {
            try
            {
                AddInfoToSuccessForm();
                LoadView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void AddInfoToSuccessForm() {
            ExpressionMethod.EditGridView(grv_CD);
            ExpressionMethod.AddToComboBoxStatusCD(cbx_TrangThaiDia);
            ExpressionMethod.AddToComboBoxStatusRentCD(cbx_TrangThaiThue);
        }
        private void LoadView()
        {
            binding.DataSource = db.GetDisks();
            ExpressionMethod.LoadGridControl(grdc_CD, grv_CD, binding);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa đĩa bản sao này", "Xóa đĩa bản sao", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    if (db.Delete(Int32.Parse(pictureBox1.Tag.ToString())))
                    {
                        MessageBox.Show("Xóa thành công", "Xóa đĩa bản sao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binding.DataSource = db.GetDisks();
                    }
                    else
                        MessageBox.Show("Xóa thất bại", "Xóa đĩa bản sao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void grv_CD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LoadToTextBox(grv_CD.GetSelectedRows()[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadToTextBox(int indexSelected)
        {
            Disk disk = binding[indexSelected] as Disk;
            pictureBox1.Tag = disk.IdDisk;
            txt_TenTieuDe.Text = disk.IdTitle.ToString();
            switch (disk.DiskStatus)
            {
                case "Good": cbx_TrangThaiDia.SelectedIndex = 0; break;
                case "Damage": cbx_TrangThaiDia.SelectedIndex = 1; break;
            }
            switch (disk.DiskRentalStatus)
            {
                case "OnShelf": cbx_TrangThaiThue.SelectedIndex = 0; break;
                case "OnHold": cbx_TrangThaiThue.SelectedIndex = 1; break;
                case "Rented": cbx_TrangThaiThue.SelectedIndex = 2; break;
            }
            if (cbx_TrangThaiThue.SelectedIndex != 0)
            {
                btn_CapNhat.Enabled = false;
            }
            else
            {
                btn_CapNhat.Enabled = true;
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(auth)==true)
            {
                if (btn_CapNhat.Text == "Cập nhật")
                {
                    cbx_TrangThaiDia.Enabled = true;
                    txt_TenTieuDe.ReadOnly = false;
                    btn_CapNhat.Text = "Hủy";
                    btn_XacNhan.Enabled = true;
                }
                else
                {
                    cbx_TrangThaiDia.Enabled = false;
                    btn_XacNhan.Enabled = false;
                    txt_TenTieuDe.ReadOnly = true;
                    btn_CapNhat.Text = "Cập nhật";
                }
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

            Disk disk = new Disk();
            disk.IdDisk = Convert.ToInt32(pictureBox1.Tag.ToString());
            disk.IdTitle = Convert.ToInt32(txt_TenTieuDe.Text);
            switch (cbx_TrangThaiDia.SelectedIndex)
            {
                case 0: disk.DiskStatus = "Good"; break;
                case 1: disk.DiskStatus = "Damage"; break;
            }
            switch (cbx_TrangThaiThue.SelectedIndex)
            {
                case 0: disk.DiskRentalStatus = "OnShelf"; break;
                case 1: disk.DiskRentalStatus = "OnHold"; break;
                case 2: disk.DiskRentalStatus = "Rented"; break;
            }
            db.UpdateDisk(disk);
            if (db.UpdateDisk(disk) == true)
            {
                string message = "Cập nhật thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
                cbx_TrangThaiDia.Enabled = false;
                btn_XacNhan.Enabled = false;
                txt_TenTieuDe.ReadOnly = true;
                btn_CapNhat.Text = "Cập nhật";
                LoadView();
            }
            else
            {
                string message = "Cập nhật thất bại";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
    }
}
