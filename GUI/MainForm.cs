using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using GUI.FormQuanLy;
using GUI.FormDichVu;
using System.Collections.Generic;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Form form;
        private List<string> lst = ExpressionMethod.ListBegin();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        { 
            ConfigView();
            FormThueDia frm = new FormThueDia(bar_TrangThai.Caption.ToString());
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }
        /// <summary>
        /// Config Design
        /// </summary>
        private void ConfigView()
        {
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = lst[0];
            IconOptions.Image = Properties.Resources.icons8_cd_641;

        }
        private void ChangeBar()
        {
            if (bar_BtnLog.Caption.Equals("Đăng Xuất"))
            {
                bar_TrangThai.Caption = lst[1];
                bar_BtnLog.Caption = lst[3];
                bar_TrangThai.ImageOptions.Image = Properties.Resources.icons8_guest_32;
                bar_BtnLog.ImageOptions.Image = Properties.Resources.icons8_key2_16;
            }
            
        }

        private void bar_BtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bar_BtnLog.Caption.Equals("Đăng Xuất"))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ChangeBar();
                    MessageBox.Show("Đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                LoginForm frm = new LoginForm();
                ExpressionMethod.AddFormToFluent(fluent_label, frm);
                this.form = frm;
                frm.btn_Login.Click += Btn_Login_Click;
            }

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string account = ((LoginForm)form).txt_TenDangNhap.Text;
            string password = ((LoginForm)form).txt_MatKhau.Text;
            if (account.Equals("admin") && (password.Equals("admin")))
            {
                bar_TrangThai.Caption = lst[2];
                bar_BtnLog.Caption = lst[4];
                bar_TrangThai.ImageOptions.Image = Properties.Resources.icons8_businessman_32;
                bar_BtnLog.ImageOptions.Image = Properties.Resources.icons8_exit_16;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Đăng nhập thất bại\n Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void acdeThueDia_Click(object sender, EventArgs e)
        {
            FormThueDia frm = new FormThueDia(bar_TrangThai.Caption.ToString());
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void adceTraDia_Click(object sender, EventArgs e)
        {
            FormTraDia frm = new FormTraDia(bar_TrangThai.Caption.ToString());
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void adceDatTruoc_Click(object sender, EventArgs e)
        {
            FormDatTruoc frm = new FormDatTruoc();
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void adceKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang frm = new FormKhachHang(bar_TrangThai.Caption);
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void acdeTieuDe_Click(object sender, EventArgs e)
        {
            FormTieuDe frm = new FormTieuDe(bar_TrangThai.Caption);
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void acdeCD_Click(object sender, EventArgs e)
        {
            FormCD frm = new FormCD(bar_TrangThai.Caption);
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void adceBaoCao_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(bar_TrangThai.Caption.ToString()))
            {
                FormBaoCao frm = new FormBaoCao();
                ExpressionMethod.AddFormToFluent(fluent_label, frm);
            }
           
        }

        private void adceLoaiDia_Click(object sender, EventArgs e)
        {
            FormLoaiDia frm = new FormLoaiDia(bar_TrangThai.Caption);
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }
        private void btn_Warning_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
    }
}
