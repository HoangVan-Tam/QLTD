namespace GUI.FormChucNang
{
    partial class FormThemTD
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
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuongDia = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_ThemTT = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.cbx_LoaiDia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTieuDe.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 79.04F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.48F)});
            this.tablePanel1.Controls.Add(this.tablePanel5);
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F)});
            this.tablePanel1.Size = new System.Drawing.Size(800, 450);
            this.tablePanel1.TabIndex = 1;
            // 
            // tablePanel5
            // 
            this.tablePanel1.SetColumn(this.tablePanel5, 1);
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel5.Controls.Add(this.label3);
            this.tablePanel5.Controls.Add(this.txt_SoLuongDia);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(53, 244);
            this.tablePanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel1.SetRow(this.tablePanel5, 3);
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel5.Size = new System.Drawing.Size(695, 72);
            this.tablePanel5.TabIndex = 5;
            // 
            // label3
            // 
            this.tablePanel5.SetColumn(this.label3, 0);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.tablePanel5.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(270, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng Đĩa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SoLuongDia
            // 
            this.tablePanel5.SetColumn(this.txt_SoLuongDia, 1);
            this.txt_SoLuongDia.EditValue = 1;
            this.txt_SoLuongDia.Location = new System.Drawing.Point(288, 21);
            this.txt_SoLuongDia.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txt_SoLuongDia.Name = "txt_SoLuongDia";
            this.txt_SoLuongDia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongDia.Properties.Appearance.Options.UseFont = true;
            this.txt_SoLuongDia.Properties.NullValuePrompt = "Số Lượng Đĩa";
            this.tablePanel5.SetRow(this.txt_SoLuongDia, 0);
            this.txt_SoLuongDia.Size = new System.Drawing.Size(397, 30);
            this.txt_SoLuongDia.TabIndex = 4;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.btn_ThemTT);
            this.tablePanel4.Controls.Add(this.btn_Dong);
            this.tablePanel4.Location = new System.Drawing.Point(53, 349);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 4);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(695, 72);
            this.tablePanel4.TabIndex = 4;
            // 
            // btn_ThemTT
            // 
            this.btn_ThemTT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTT.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_ThemTT, 0);
            this.btn_ThemTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThemTT.ImageOptions.Image = global::GUI.Properties.Resources.icons8_add_property_32;
            this.btn_ThemTT.Location = new System.Drawing.Point(4, 4);
            this.btn_ThemTT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemTT.Name = "btn_ThemTT";
            this.btn_ThemTT.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_ThemTT, 0);
            this.btn_ThemTT.Size = new System.Drawing.Size(340, 64);
            this.btn_ThemTT.TabIndex = 1;
            this.btn_ThemTT.Text = "Thêm Tiêu Đề";
            this.btn_ThemTT.Click += new System.EventHandler(this.btn_ThemTT_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_Dong, 1);
            this.btn_Dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dong.ImageOptions.Image = global::GUI.Properties.Resources.icons8_close_pane_32;
            this.btn_Dong.Location = new System.Drawing.Point(352, 4);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Dong, 0);
            this.btn_Dong.Size = new System.Drawing.Size(340, 64);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel3.Controls.Add(this.cbx_LoaiDia);
            this.tablePanel3.Controls.Add(this.label2);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(53, 164);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 2);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(695, 72);
            this.tablePanel3.TabIndex = 3;
            // 
            // cbx_LoaiDia
            // 
            this.tablePanel3.SetColumn(this.cbx_LoaiDia, 1);
            this.cbx_LoaiDia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LoaiDia.FormattingEnabled = true;
            this.cbx_LoaiDia.Location = new System.Drawing.Point(282, 20);
            this.cbx_LoaiDia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbx_LoaiDia.Name = "cbx_LoaiDia";
            this.tablePanel3.SetRow(this.cbx_LoaiDia, 0);
            this.cbx_LoaiDia.Size = new System.Drawing.Size(409, 32);
            this.cbx_LoaiDia.TabIndex = 6;
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
            this.label2.Size = new System.Drawing.Size(270, 72);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Đĩa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel2.Controls.Add(this.label4);
            this.tablePanel2.Controls.Add(this.txt_TenTieuDe);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(53, 84);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(695, 72);
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
            this.label4.Size = new System.Drawing.Size(270, 72);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Tiêu Đề";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TenTieuDe
            // 
            this.tablePanel2.SetColumn(this.txt_TenTieuDe, 1);
            this.txt_TenTieuDe.Location = new System.Drawing.Point(286, 21);
            this.txt_TenTieuDe.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txt_TenTieuDe.Name = "txt_TenTieuDe";
            this.txt_TenTieuDe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTieuDe.Properties.Appearance.Options.UseFont = true;
            this.txt_TenTieuDe.Properties.NullValuePrompt = "Tiêu Đề";
            this.tablePanel2.SetRow(this.txt_TenTieuDe, 0);
            this.txt_TenTieuDe.Size = new System.Drawing.Size(401, 30);
            this.txt_TenTieuDe.TabIndex = 4;
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(693, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm Tiêu Đề";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // FormThemTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormThemTD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemTD";
            this.Load += new System.EventHandler(this.FormThemTD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTieuDe.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_SoLuongDia;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_ThemTT;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.ComboBox cbx_LoaiDia;
        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_TenTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}