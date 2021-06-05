namespace GUI
{
    partial class MainForm
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
            this.sa = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.adceGroupDichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acdeThueDia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adceTraDia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adceDatTruoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adceGroupQuanLy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adceKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adceLoaiDia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acdeTieuDe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acdeCD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adceBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.bar_TrangThai = new DevExpress.XtraBars.BarSubItem();
            this.bar_BtnLog = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Warning = new DevExpress.XtraBars.BarButtonItem();
            this.fluent_label = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.sa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // sa
            // 
            this.sa.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa.Appearance.AccordionControl.Options.UseFont = true;
            this.sa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sa.Dock = System.Windows.Forms.DockStyle.Left;
            this.sa.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.adceGroupDichVu,
            this.adceGroupQuanLy});
            this.sa.Location = new System.Drawing.Point(0, 25);
            this.sa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sa.Name = "sa";
            this.sa.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.sa.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.sa.Size = new System.Drawing.Size(294, 894);
            this.sa.TabIndex = 1;
            this.sa.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // adceGroupDichVu
            // 
            this.adceGroupDichVu.Appearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupDichVu.Appearance.Disabled.Options.UseFont = true;
            this.adceGroupDichVu.Appearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupDichVu.Appearance.Hovered.Options.UseFont = true;
            this.adceGroupDichVu.Appearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupDichVu.Appearance.Normal.Options.UseFont = true;
            this.adceGroupDichVu.Appearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupDichVu.Appearance.Pressed.Options.UseFont = true;
            this.adceGroupDichVu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acdeThueDia,
            this.adceTraDia,
            this.adceDatTruoc});
            this.adceGroupDichVu.Expanded = true;
            this.adceGroupDichVu.ImageOptions.Image = global::GUI.Properties.Resources.icons8_self_service_kiosk_48;
            this.adceGroupDichVu.Name = "adceGroupDichVu";
            this.adceGroupDichVu.Text = "Dịch Vụ";
            // 
            // acdeThueDia
            // 
            this.acdeThueDia.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeThueDia.Appearance.Disabled.Options.UseFont = true;
            this.acdeThueDia.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeThueDia.Appearance.Hovered.Options.UseFont = true;
            this.acdeThueDia.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeThueDia.Appearance.Normal.Options.UseFont = true;
            this.acdeThueDia.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeThueDia.Appearance.Pressed.Options.UseFont = true;
            this.acdeThueDia.ImageOptions.Image = global::GUI.Properties.Resources.icons8_video_playlist_32;
            this.acdeThueDia.Name = "acdeThueDia";
            this.acdeThueDia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acdeThueDia.Text = "Thuê Đĩa";
            this.acdeThueDia.Click += new System.EventHandler(this.acdeThueDia_Click);
            // 
            // adceTraDia
            // 
            this.adceTraDia.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceTraDia.Appearance.Disabled.Options.UseFont = true;
            this.adceTraDia.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceTraDia.Appearance.Hovered.Options.UseFont = true;
            this.adceTraDia.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceTraDia.Appearance.Normal.Options.UseFont = true;
            this.adceTraDia.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceTraDia.Appearance.Pressed.Options.UseFont = true;
            this.adceTraDia.ImageOptions.Image = global::GUI.Properties.Resources.icons8_money_32;
            this.adceTraDia.Name = "adceTraDia";
            this.adceTraDia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.adceTraDia.Text = "Trả Đĩa";
            this.adceTraDia.Click += new System.EventHandler(this.adceTraDia_Click);
            // 
            // adceDatTruoc
            // 
            this.adceDatTruoc.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceDatTruoc.Appearance.Disabled.Options.UseFont = true;
            this.adceDatTruoc.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceDatTruoc.Appearance.Hovered.Options.UseFont = true;
            this.adceDatTruoc.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceDatTruoc.Appearance.Normal.Options.UseFont = true;
            this.adceDatTruoc.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceDatTruoc.Appearance.Pressed.Options.UseFont = true;
            this.adceDatTruoc.ImageOptions.Image = global::GUI.Properties.Resources.icons8_google_calendar_321;
            this.adceDatTruoc.Name = "adceDatTruoc";
            this.adceDatTruoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.adceDatTruoc.Text = "Đặt Trước";
            this.adceDatTruoc.Click += new System.EventHandler(this.adceDatTruoc_Click);
            // 
            // adceGroupQuanLy
            // 
            this.adceGroupQuanLy.Appearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupQuanLy.Appearance.Disabled.Options.UseFont = true;
            this.adceGroupQuanLy.Appearance.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupQuanLy.Appearance.Hovered.Options.UseFont = true;
            this.adceGroupQuanLy.Appearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupQuanLy.Appearance.Normal.Options.UseFont = true;
            this.adceGroupQuanLy.Appearance.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceGroupQuanLy.Appearance.Pressed.Options.UseFont = true;
            this.adceGroupQuanLy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.adceKhachHang,
            this.adceLoaiDia,
            this.acdeTieuDe,
            this.acdeCD,
            this.adceBaoCao});
            this.adceGroupQuanLy.Expanded = true;
            this.adceGroupQuanLy.ImageOptions.Image = global::GUI.Properties.Resources.icons8_system_task_48;
            this.adceGroupQuanLy.Name = "adceGroupQuanLy";
            this.adceGroupQuanLy.Text = "Quản Lý";
            // 
            // adceKhachHang
            // 
            this.adceKhachHang.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceKhachHang.Appearance.Disabled.Options.UseFont = true;
            this.adceKhachHang.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceKhachHang.Appearance.Hovered.Options.UseFont = true;
            this.adceKhachHang.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceKhachHang.Appearance.Normal.Options.UseFont = true;
            this.adceKhachHang.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceKhachHang.Appearance.Pressed.Options.UseFont = true;
            this.adceKhachHang.ImageOptions.Image = global::GUI.Properties.Resources.icons8_guest_32;
            this.adceKhachHang.Name = "adceKhachHang";
            this.adceKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.adceKhachHang.Text = "Khách Hàng";
            this.adceKhachHang.Click += new System.EventHandler(this.adceKhachHang_Click);
            // 
            // adceLoaiDia
            // 
            this.adceLoaiDia.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceLoaiDia.Appearance.Disabled.Options.UseFont = true;
            this.adceLoaiDia.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceLoaiDia.Appearance.Hovered.Options.UseFont = true;
            this.adceLoaiDia.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceLoaiDia.Appearance.Normal.Options.UseFont = true;
            this.adceLoaiDia.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceLoaiDia.Appearance.Pressed.Options.UseFont = true;
            this.adceLoaiDia.ImageOptions.Image = global::GUI.Properties.Resources.icons8_clapperboard_32;
            this.adceLoaiDia.Name = "adceLoaiDia";
            this.adceLoaiDia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.adceLoaiDia.Text = "Loại Đĩa";
            this.adceLoaiDia.Click += new System.EventHandler(this.adceLoaiDia_Click);
            // 
            // acdeTieuDe
            // 
            this.acdeTieuDe.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeTieuDe.Appearance.Disabled.Options.UseFont = true;
            this.acdeTieuDe.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeTieuDe.Appearance.Hovered.Options.UseFont = true;
            this.acdeTieuDe.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeTieuDe.Appearance.Normal.Options.UseFont = true;
            this.acdeTieuDe.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeTieuDe.Appearance.Pressed.Options.UseFont = true;
            this.acdeTieuDe.ImageOptions.Image = global::GUI.Properties.Resources.icons8_create_32;
            this.acdeTieuDe.Name = "acdeTieuDe";
            this.acdeTieuDe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acdeTieuDe.Text = "Tiêu Đề";
            this.acdeTieuDe.Click += new System.EventHandler(this.acdeTieuDe_Click);
            // 
            // acdeCD
            // 
            this.acdeCD.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeCD.Appearance.Disabled.Options.UseFont = true;
            this.acdeCD.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeCD.Appearance.Hovered.Options.UseFont = true;
            this.acdeCD.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeCD.Appearance.Normal.Options.UseFont = true;
            this.acdeCD.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acdeCD.Appearance.Pressed.Options.UseFont = true;
            this.acdeCD.ImageOptions.Image = global::GUI.Properties.Resources.icons8_software_box_32;
            this.acdeCD.Name = "acdeCD";
            this.acdeCD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acdeCD.Text = "CD/DVD";
            this.acdeCD.Click += new System.EventHandler(this.acdeCD_Click);
            // 
            // adceBaoCao
            // 
            this.adceBaoCao.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceBaoCao.Appearance.Disabled.Options.UseFont = true;
            this.adceBaoCao.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceBaoCao.Appearance.Hovered.Options.UseFont = true;
            this.adceBaoCao.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceBaoCao.Appearance.Normal.Options.UseFont = true;
            this.adceBaoCao.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adceBaoCao.Appearance.Pressed.Options.UseFont = true;
            this.adceBaoCao.ImageOptions.Image = global::GUI.Properties.Resources.icons8_ratings_32;
            this.adceBaoCao.Name = "adceBaoCao";
            this.adceBaoCao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.adceBaoCao.Text = "Báo Cáo";
            this.adceBaoCao.Click += new System.EventHandler(this.adceBaoCao_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_TrangThai,
            this.bar_BtnLog,
            this.btn_Warning});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1491, 25);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.bar_TrangThai);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btn_Warning);
            // 
            // bar_TrangThai
            // 
            this.bar_TrangThai.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bar_TrangThai.Caption = "Nhân Viên";
            this.bar_TrangThai.Id = 2;
            this.bar_TrangThai.ImageOptions.Image = global::GUI.Properties.Resources.icons8_guest_32;
            this.bar_TrangThai.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_TrangThai.ItemAppearance.Disabled.Options.UseFont = true;
            this.bar_TrangThai.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_TrangThai.ItemAppearance.Hovered.Options.UseFont = true;
            this.bar_TrangThai.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_TrangThai.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_TrangThai.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_TrangThai.ItemAppearance.Pressed.Options.UseFont = true;
            this.bar_TrangThai.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_BtnLog)});
            this.bar_TrangThai.Name = "bar_TrangThai";
            this.bar_TrangThai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar_BtnLog
            // 
            this.bar_BtnLog.Caption = "Đăng Nhập Vào Tài Khoản Quản Lý";
            this.bar_BtnLog.Id = 0;
            this.bar_BtnLog.ImageOptions.Image = global::GUI.Properties.Resources.icons8_key2_16;
            this.bar_BtnLog.Name = "bar_BtnLog";
            this.bar_BtnLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_BtnLog_ItemClick);
            // 
            // btn_Warning
            // 
            this.btn_Warning.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Warning.Hint = "Hiện tại không có đặt trước";
            this.btn_Warning.Id = 0;
            this.btn_Warning.ImageOptions.Image = global::GUI.Properties.Resources.icons8_medium_risk_321;
            this.btn_Warning.Name = "btn_Warning";
            this.btn_Warning.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Warning_ItemClick);
            // 
            // fluent_label
            // 
            this.fluent_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluent_label.Location = new System.Drawing.Point(294, 25);
            this.fluent_label.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.fluent_label.Name = "fluent_label";
            this.fluent_label.Size = new System.Drawing.Size(1197, 894);
            this.fluent_label.TabIndex = 0;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 919);
            this.ControlContainer = this.fluent_label;
            this.Controls.Add(this.fluent_label);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::GUI.Properties.Resources.icons8_cd_642;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.NavigationControl = this.sa;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm 11 - App Cho Thuê Đĩa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl sa;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceGroupDichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acdeThueDia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceTraDia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceDatTruoc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceGroupQuanLy;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acdeTieuDe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acdeCD;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluent_label;
        private DevExpress.XtraBars.BarButtonItem bar_BtnLog;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceBaoCao;
        public DevExpress.XtraBars.BarSubItem bar_TrangThai;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adceLoaiDia;
        private DevExpress.XtraBars.BarButtonItem btn_Warning;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}