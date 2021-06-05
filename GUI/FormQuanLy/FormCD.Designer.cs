namespace GUI.FormQuanLy
{
    partial class FormCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCD));
            this.label3 = new System.Windows.Forms.Label();
            this.grdc_CD = new DevExpress.XtraGrid.GridControl();
            this.grv_CD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_TenTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton5 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel7 = new DevExpress.Utils.Layout.TablePanel();
            this.cbx_TrangThaiThue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.cbx_TrangThaiDia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdc_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel7)).BeginInit();
            this.tablePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.tablePanel5.SetColumn(this.label3, 0);
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.tablePanel5.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Tiêu Đề";
            // 
            // grdc_CD
            // 
            this.tablePanel1.SetColumn(this.grdc_CD, 1);
            this.grdc_CD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdc_CD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdc_CD.Location = new System.Drawing.Point(40, 105);
            this.grdc_CD.MainView = this.grv_CD;
            this.grdc_CD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdc_CD.Name = "grdc_CD";
            this.tablePanel1.SetRow(this.grdc_CD, 2);
            this.grdc_CD.Size = new System.Drawing.Size(885, 966);
            this.grdc_CD.TabIndex = 2;
            this.grdc_CD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_CD});
            // 
            // grv_CD
            // 
            this.grv_CD.DetailHeight = 512;
            this.grv_CD.GridControl = this.grdc_CD;
            this.grv_CD.Name = "grv_CD";
            this.grv_CD.OptionsView.ShowFooter = true;
            this.grv_CD.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grv_CD_FocusedRowChanged);
            // 
            // txt_TenTieuDe
            // 
            this.tablePanel5.SetColumn(this.txt_TenTieuDe, 1);
            this.txt_TenTieuDe.Location = new System.Drawing.Point(171, 5);
            this.txt_TenTieuDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenTieuDe.Name = "txt_TenTieuDe";
            this.txt_TenTieuDe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTieuDe.Properties.Appearance.Options.UseFont = true;
            this.txt_TenTieuDe.Properties.NullValuePrompt = "Tên Tiêu Đề";
            this.txt_TenTieuDe.Properties.ReadOnly = true;
            this.tablePanel5.SetRow(this.txt_TenTieuDe, 0);
            this.txt_TenTieuDe.Size = new System.Drawing.Size(242, 30);
            this.txt_TenTieuDe.TabIndex = 2;
            // 
            // tablePanel5
            // 
            this.tablePanel2.SetColumn(this.tablePanel5, 1);
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel5.Controls.Add(this.label3);
            this.tablePanel5.Controls.Add(this.txt_TenTieuDe);
            this.tablePanel5.Location = new System.Drawing.Point(216, 405);
            this.tablePanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel2.SetRow(this.tablePanel5, 2);
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel5.Size = new System.Drawing.Size(417, 40);
            this.tablePanel5.TabIndex = 4;
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // navButton4
            // 
            this.navButton4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton4.Caption = "navButton4";
            this.navButton4.Name = "navButton4";
            // 
            // navButton2
            // 
            this.navButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton2.Caption = "navButton2";
            this.navButton2.Name = "navButton2";
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton3.Caption = "navButton3";
            this.navButton3.Name = "navButton3";
            // 
            // navButton5
            // 
            this.navButton5.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton5.Caption = "navButton5";
            this.navButton5.Name = "navButton5";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 2);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel2.Controls.Add(this.tablePanel7);
            this.tablePanel2.Controls.Add(this.tablePanel5);
            this.tablePanel2.Controls.Add(this.tablePanel4);
            this.tablePanel2.Controls.Add(this.tablePanel3);
            this.tablePanel2.Controls.Add(this.pictureBox1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(932, 105);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 350F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 103.6001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 46.39994F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel2.Size = new System.Drawing.Size(849, 966);
            this.tablePanel2.TabIndex = 3;
            // 
            // tablePanel7
            // 
            this.tablePanel2.SetColumn(this.tablePanel7, 1);
            this.tablePanel7.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel7.Controls.Add(this.cbx_TrangThaiThue);
            this.tablePanel7.Controls.Add(this.label6);
            this.tablePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel7.Location = new System.Drawing.Point(216, 502);
            this.tablePanel7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tablePanel7.Name = "tablePanel7";
            this.tablePanel2.SetRow(this.tablePanel7, 4);
            this.tablePanel7.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel7.Size = new System.Drawing.Size(417, 46);
            this.tablePanel7.TabIndex = 6;
            // 
            // cbx_TrangThaiThue
            // 
            this.tablePanel7.SetColumn(this.cbx_TrangThaiThue, 1);
            this.cbx_TrangThaiThue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TrangThaiThue.FormattingEnabled = true;
            this.cbx_TrangThaiThue.Location = new System.Drawing.Point(171, 7);
            this.cbx_TrangThaiThue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbx_TrangThaiThue.Name = "cbx_TrangThaiThue";
            this.tablePanel7.SetRow(this.cbx_TrangThaiThue, 0);
            this.cbx_TrangThaiThue.Size = new System.Drawing.Size(242, 32);
            this.cbx_TrangThaiThue.TabIndex = 4;
            // 
            // label6
            // 
            this.tablePanel7.SetColumn(this.label6, 0);
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.tablePanel7.SetRow(this.label6, 0);
            this.label6.Size = new System.Drawing.Size(159, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "TT Thuê";
            // 
            // tablePanel4
            // 
            this.tablePanel2.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.btn_XacNhan);
            this.tablePanel4.Controls.Add(this.btn_CapNhat);
            this.tablePanel4.Controls.Add(this.btn_Xoa);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(216, 555);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel2.SetRow(this.tablePanel4, 5);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(417, 94);
            this.tablePanel4.TabIndex = 3;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XacNhan.Appearance.Options.UseFont = true;
            this.btn_XacNhan.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btn_XacNhan, 1);
            this.btn_XacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XacNhan.ImageOptions.Image = global::GUI.Properties.Resources.icons8_inspection_32;
            this.btn_XacNhan.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_XacNhan.Location = new System.Drawing.Point(143, 5);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_XacNhan, 0);
            this.btn_XacNhan.Size = new System.Drawing.Size(131, 84);
            this.btn_XacNhan.TabIndex = 1;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btn_CapNhat, 0);
            this.btn_CapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CapNhat.ImageOptions.Image = global::GUI.Properties.Resources.icons8_renew_32;
            this.btn_CapNhat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_CapNhat.Location = new System.Drawing.Point(4, 5);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_CapNhat, 0);
            this.btn_CapNhat.Size = new System.Drawing.Size(131, 84);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btn_Xoa, 2);
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.ImageOptions.Image = global::GUI.Properties.Resources.icons8_delete_file_32;
            this.btn_Xoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Xoa.Location = new System.Drawing.Point(282, 5);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Xoa, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(131, 84);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel2.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel3.Controls.Add(this.cbx_TrangThaiDia);
            this.tablePanel3.Controls.Add(this.label5);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(216, 455);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel2.SetRow(this.tablePanel3, 3);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(417, 40);
            this.tablePanel3.TabIndex = 2;
            // 
            // cbx_TrangThaiDia
            // 
            this.tablePanel3.SetColumn(this.cbx_TrangThaiDia, 1);
            this.cbx_TrangThaiDia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TrangThaiDia.FormattingEnabled = true;
            this.cbx_TrangThaiDia.Location = new System.Drawing.Point(171, 4);
            this.cbx_TrangThaiDia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbx_TrangThaiDia.Name = "cbx_TrangThaiDia";
            this.tablePanel3.SetRow(this.cbx_TrangThaiDia, 0);
            this.cbx_TrangThaiDia.Size = new System.Drawing.Size(242, 32);
            this.cbx_TrangThaiDia.TabIndex = 4;
            // 
            // label5
            // 
            this.tablePanel3.SetColumn(this.label5, 0);
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.tablePanel3.SetRow(this.label5, 0);
            this.label5.Size = new System.Drawing.Size(159, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "TT Đĩa";
            // 
            // pictureBox1
            // 
            this.tablePanel2.SetColumn(this.pictureBox1, 1);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel2.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(417, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(885, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho CD/DVD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.tablePanel1.SetColumn(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(932, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(849, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Tin Chi Tiết CD/DVD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.grdc_CD);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1785, 1076);
            this.tablePanel1.TabIndex = 2;
            // 
            // tablePanel6
            // 
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel6.Location = new System.Drawing.Point(216, 455);
            this.tablePanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel6.Size = new System.Drawing.Size(417, 40);
            this.tablePanel6.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 33);
            this.label4.TabIndex = 3;
            // 
            // FormCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 1076);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCD";
            this.Text = "FormCD";
            this.Load += new System.EventHandler(this.FormCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdc_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel7)).EndInit();
            this.tablePanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl grdc_CD;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_CD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_TenTieuDe;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraBars.Navigation.NavButton navButton5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.ComboBox cbx_TrangThaiDia;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
        private DevExpress.Utils.Layout.TablePanel tablePanel7;
        private System.Windows.Forms.ComboBox cbx_TrangThaiThue;
        private System.Windows.Forms.Label label6;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private System.Windows.Forms.Label label4;
    }
}