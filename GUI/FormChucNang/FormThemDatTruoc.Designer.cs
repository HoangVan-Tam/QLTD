namespace GUI.FormChucNang
{
    partial class FormThemDatTruoc
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
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_ThemDatTruoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TieuDe = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKhachHang.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TieuDe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.58F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70.42F)});
            this.tablePanel3.Controls.Add(this.label2);
            this.tablePanel3.Controls.Add(this.txt_MaKhachHang);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(48, 164);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 2);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(668, 72);
            this.tablePanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.tablePanel3.SetColumn(this.label2, 0);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.tablePanel3.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(190, 72);
            this.label2.TabIndex = 5;
            this.label2.Text = "SĐT Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_MaKhachHang
            // 
            this.tablePanel3.SetColumn(this.txt_MaKhachHang, 1);
            this.txt_MaKhachHang.Location = new System.Drawing.Point(209, 21);
            this.txt_MaKhachHang.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhachHang.Properties.Appearance.Options.UseFont = true;
            this.txt_MaKhachHang.Properties.NullValuePrompt = "Khách Hàng Đặt Trước";
            this.tablePanel3.SetRow(this.txt_MaKhachHang, 0);
            this.txt_MaKhachHang.Size = new System.Drawing.Size(448, 30);
            this.txt_MaKhachHang.TabIndex = 4;
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(666, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Trước";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 376);
            this.panel1.TabIndex = 2;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 78.98F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.87F)});
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F)});
            this.tablePanel1.Size = new System.Drawing.Size(770, 376);
            this.tablePanel1.TabIndex = 1;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.btn_ThemDatTruoc);
            this.tablePanel4.Controls.Add(this.btn_Dong);
            this.tablePanel4.Location = new System.Drawing.Point(48, 273);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 3);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(668, 70);
            this.tablePanel4.TabIndex = 4;
            // 
            // btn_ThemDatTruoc
            // 
            this.btn_ThemDatTruoc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDatTruoc.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_ThemDatTruoc, 0);
            this.btn_ThemDatTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThemDatTruoc.ImageOptions.Image = global::GUI.Properties.Resources.icons8_add_property_32;
            this.btn_ThemDatTruoc.Location = new System.Drawing.Point(4, 4);
            this.btn_ThemDatTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemDatTruoc.Name = "btn_ThemDatTruoc";
            this.btn_ThemDatTruoc.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_ThemDatTruoc, 0);
            this.btn_ThemDatTruoc.Size = new System.Drawing.Size(326, 62);
            this.btn_ThemDatTruoc.TabIndex = 1;
            this.btn_ThemDatTruoc.Text = "Thêm Đặt Trước";
            this.btn_ThemDatTruoc.Click += new System.EventHandler(this.btn_ThemDatTruoc_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_Dong, 1);
            this.btn_Dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dong.ImageOptions.Image = global::GUI.Properties.Resources.icons8_close_pane_32;
            this.btn_Dong.Location = new System.Drawing.Point(338, 4);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Dong, 0);
            this.btn_Dong.Size = new System.Drawing.Size(326, 62);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.24F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70.76F)});
            this.tablePanel2.Controls.Add(this.label4);
            this.tablePanel2.Controls.Add(this.txt_TieuDe);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(48, 84);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(668, 72);
            this.tablePanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.tablePanel2.SetColumn(this.label4, 0);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.tablePanel2.SetRow(this.label4, 0);
            this.label4.Size = new System.Drawing.Size(187, 72);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiêu Đề";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_TieuDe
            // 
            this.tablePanel2.SetColumn(this.txt_TieuDe, 1);
            this.txt_TieuDe.Location = new System.Drawing.Point(203, 21);
            this.txt_TieuDe.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TieuDe.Properties.Appearance.Options.UseFont = true;
            this.txt_TieuDe.Properties.NullValuePrompt = "Tiêu Đề Đặt Trước";
            this.txt_TieuDe.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.txt_TieuDe, 0);
            this.txt_TieuDe.Size = new System.Drawing.Size(457, 30);
            this.txt_TieuDe.TabIndex = 4;
            // 
            // FormThemDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 376);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThemDatTruoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemDatTruoc";
            this.Load += new System.EventHandler(this.FormThemDatTruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKhachHang.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TieuDe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_ThemDatTruoc;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_TieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_MaKhachHang;
        private System.Windows.Forms.Panel panel1;
    }
}