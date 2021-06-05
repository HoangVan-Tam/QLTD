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
    public partial class FormLoaiDia : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        private DiskTypeBUL db;
        private BindingSource binding;
        public FormLoaiDia(string auth)
        {
            InitializeComponent();
            btn_XacNhan.Enabled = false;
            this.auth = auth;
            db = new DiskTypeBUL();
            binding = new BindingSource();
        }

        private void FormLoaiDia_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
            LoadView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(grv_LoaiDia);
        }
        private void LoadView()
        {
            binding.DataSource = db.GetDiskTypes();
            ExpressionMethod.LoadGridControl(grd_LoaiDia, grv_LoaiDia, binding);
        }

        private void grv_LoaiDia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grv_LoaiDia.DataSource != null)
            {
                LoadToTextBox(grv_LoaiDia.GetSelectedRows()[0]);
            }
        }
        private void LoadToTextBox(int indexSelected)
        {
            DiskType diskType = binding[indexSelected] as DiskType;
            pictureBox1.Tag = diskType.IdDiskType;
            txt_GiaThue.Text = diskType.Price.ToString();
            txt_PhiTre.Text = diskType.LateFee.ToString();
            txt_SoNgayThue.Text = diskType.TimeRented.ToString();
            txt_TenLoaiDia.Text = diskType.TypeName;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
                if (btn_CapNhat.Text == "Cập nhật")
                {
                    btn_XacNhan.Enabled = true;
                    txt_GiaThue.ReadOnly = false;
                    txt_SoNgayThue.ReadOnly = false;
                    btn_CapNhat.Text = "Hủy";
                }
                else
                {
                    btn_XacNhan.Enabled = false;
                    txt_GiaThue.ReadOnly = true;
                    txt_SoNgayThue.ReadOnly = true;
                    btn_CapNhat.Text = "Cập nhật";
                }
            }

        }

        private void btn_XacNhan_Click_1(object sender, EventArgs e)
        {
            DiskType diskType = new DiskType();
            diskType.IdDiskType = Convert.ToInt32(pictureBox1.Tag.ToString());
            diskType.TypeName = txt_TenLoaiDia.Text;
            diskType.LateFee = (float)(Convert.ToInt32(txt_PhiTre.Text));
            diskType.TimeRented = Convert.ToInt32(txt_SoNgayThue.Text);
            diskType.Price = (float)(Convert.ToInt32(txt_GiaThue.Text));
            db.UpdateDiskType(diskType);
            if (db.UpdateDiskType(diskType) == true)
            {
                string message = "Cập nhật thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
                LoadView();
                LoadToTextBox(0);
                txt_GiaThue.ReadOnly = true;
                txt_SoNgayThue.ReadOnly = true;
                btn_XacNhan.Enabled = false;
                btn_CapNhat.Text = "Cập nhật";
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