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
using Entities;
using BUL;
using Entities.DTO;

namespace GUI.FormQuanLy
{
    public partial class FormTieuDe : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        private BindingSource binding;
        private TitleBUL db;
        public FormTieuDe(string auth)
        {
            InitializeComponent();
            this.auth = auth;
            db = new TitleBUL();
            binding = new BindingSource();
        }

        private void FormTieuDe_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
            LoadView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(grv_TieuDe);
        }

        private void btn_ThemDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpressionMethod.CheckAuth(this.auth))
                {
                    FormThemDiaBS frm = new FormThemDiaBS(Int32.Parse(pictureBox1.Tag.ToString()));
                    frm.Show();
                    frm.FormClosing += Frm_FormClosing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_ThemTieuDe_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpressionMethod.CheckAuth(this.auth))
                {
                    FormThemTD frm = new FormThemTD();
                    frm.Show();
                    frm.FormClosing += Frm_FormClosing;
                }
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
                    DialogResult result = MessageBox.Show("Xác nhận xóa tiêu đề", "Xóa tiêu đề", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (db.DeleteTitle(Int32.Parse(pictureBox1.Tag.ToString())))
                        {
                            MessageBox.Show("Xóa tiêu đề thành công", "Xóa tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            binding.DataSource = db.GetTitles();
                        }
                        else
                            MessageBox.Show("Xóa tiêu đề thất bại", "Xóa tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DatTruoc_Click(object sender, EventArgs e)
        {
            FormThemDatTruoc frm = new FormThemDatTruoc(Int32.Parse(pictureBox1.Tag.ToString()));
            frm.Show();
            frm.FormClosing += Frm_FormClosing;
        }
        private void LoadView()
        {
            try
            {
                binding.DataSource = db.GetTitles();
                ExpressionMethod.LoadGridControl(grd_TieuDe, grv_TieuDe, binding);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grv_TieuDe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LoadToTextBox(grv_TieuDe.GetSelectedRows()[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadToTextBox(int indexSelected)
        {
            TitleDTO title = binding[indexSelected] as TitleDTO;
            pictureBox1.Tag = title.IdTitle;
            txt_DiaTrenKe.Text = title.TotalDiskOnShelf.ToString();
            txt_LoaiDia.Text = title.IdDiskType.ToString();
            txt_SoLuongDia.Text = db.TotalDiskOfTitle(title.IdTitle).ToString();
            txt_TenTieuDe.Text = title.NameTitle;
        }
        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                db = new TitleBUL();
                binding.DataSource = db.GetTitles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
