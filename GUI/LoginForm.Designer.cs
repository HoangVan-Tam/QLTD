namespace GUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.txt_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.pbx_Key = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Key)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.lbl_Login);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.pbx_Key);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 129F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 370F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 47F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64.39999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 66.19997F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 55.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F)});
            this.tablePanel1.Size = new System.Drawing.Size(1539, 1076);
            this.tablePanel1.TabIndex = 15;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel4.Controls.Add(this.txt_MatKhau);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(517, 615);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 4);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(505, 54);
            this.tablePanel4.TabIndex = 6;
            // 
            // txt_MatKhau
            // 
            this.tablePanel4.SetColumn(this.txt_MatKhau, 1);
            this.txt_MatKhau.EditValue = "admin";
            this.txt_MatKhau.Location = new System.Drawing.Point(29, 8);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhau.Properties.NullValuePrompt = "Nhập mật khẩu";
            this.txt_MatKhau.Properties.UseSystemPasswordChar = true;
            this.tablePanel4.SetRow(this.txt_MatKhau, 0);
            this.txt_MatKhau.Size = new System.Drawing.Size(447, 38);
            this.txt_MatKhau.TabIndex = 2;
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel3.Controls.Add(this.txt_TenDangNhap);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(517, 551);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 3);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(505, 54);
            this.tablePanel3.TabIndex = 5;
            // 
            // txt_TenDangNhap
            // 
            this.tablePanel3.SetColumn(this.txt_TenDangNhap, 1);
            this.txt_TenDangNhap.EditValue = "admin";
            this.txt_TenDangNhap.Location = new System.Drawing.Point(29, 8);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDangNhap.Properties.NullValuePrompt = "Nhập tên đăng nhập";
            this.tablePanel3.SetRow(this.txt_TenDangNhap, 0);
            this.txt_TenDangNhap.Size = new System.Drawing.Size(447, 38);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // lbl_Login
            // 
            this.tablePanel1.SetColumn(this.lbl_Login, 1);
            this.lbl_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Login.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Login.Location = new System.Drawing.Point(517, 13);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.tablePanel1.SetRow(this.lbl_Login, 0);
            this.lbl_Login.Size = new System.Drawing.Size(505, 103);
            this.lbl_Login.TabIndex = 4;
            this.lbl_Login.Text = "Manager Login";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel2.Controls.Add(this.btn_Close);
            this.tablePanel2.Controls.Add(this.btn_Login);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(517, 679);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 5);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(505, 56);
            this.tablePanel2.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Close.Appearance.Options.UseBorderColor = true;
            this.btn_Close.Appearance.Options.UseFont = true;
            this.btn_Close.Appearance.Options.UseForeColor = true;
            this.btn_Close.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_Close.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Close.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.AppearancePressed.Options.UseBorderColor = true;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tablePanel2.SetColumn(this.btn_Close, 3);
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.ImageOptions.Image = global::GUI.Properties.Resources.icons8_unavailable_32;
            this.btn_Close.Location = new System.Drawing.Point(282, 5);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.SetRow(this.btn_Close, 0);
            this.btn_Close.Size = new System.Drawing.Size(194, 46);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Thoát";
            // 
            // btn_Login
            // 
            this.btn_Login.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Login.Appearance.Options.UseBorderColor = true;
            this.btn_Login.Appearance.Options.UseFont = true;
            this.btn_Login.Appearance.Options.UseForeColor = true;
            this.btn_Login.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_Login.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Login.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.AppearancePressed.Options.UseBorderColor = true;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tablePanel2.SetColumn(this.btn_Login, 1);
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Login.ImageOptions.Image = global::GUI.Properties.Resources.icons8_access_32;
            this.btn_Login.Location = new System.Drawing.Point(29, 5);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.SetRow(this.btn_Login, 0);
            this.btn_Login.Size = new System.Drawing.Size(194, 46);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng nhập";
            // 
            // pbx_Key
            // 
            this.tablePanel1.SetColumn(this.pbx_Key, 1);
            this.pbx_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Key.Image = global::GUI.Properties.Resources.images_removebg_preview;
            this.pbx_Key.Location = new System.Drawing.Point(517, 134);
            this.pbx_Key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbx_Key.Name = "pbx_Key";
            this.tablePanel1.SetRow(this.pbx_Key, 1);
            this.pbx_Key.Size = new System.Drawing.Size(505, 360);
            this.pbx_Key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Key.TabIndex = 0;
            this.pbx_Key.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 1076);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Key)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.Label lbl_Login;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        public DevExpress.XtraEditors.SimpleButton btn_Login;
        private System.Windows.Forms.PictureBox pbx_Key;
        public DevExpress.XtraEditors.TextEdit txt_MatKhau;
        public DevExpress.XtraEditors.TextEdit txt_TenDangNhap;
    }
}