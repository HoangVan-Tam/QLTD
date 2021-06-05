namespace GUI.FormChucNang
{
    partial class FormThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.tablePnl = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lstvThanhToanTreHan = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHuyKhoanTre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuyTatCa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePnl)).BeginInit();
            this.tablePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.tablePnl.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePnl.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(801, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán Trễ Hạn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel2
            // 
            this.tablePnl.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel2.Controls.Add(this.txtMaKH);
            this.tablePanel2.Controls.Add(this.label2);
            this.tablePanel2.Controls.Add(this.label3);
            this.tablePanel2.Controls.Add(this.txtTenKH);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 53);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePnl.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(801, 44);
            this.tablePanel2.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.tablePanel2.SetColumn(this.txtMaKH, 1);
            this.txtMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaKH.Location = new System.Drawing.Point(204, 5);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaKH.Properties.NullValuePrompt = "Mã Khách Hàng";
            this.txtMaKH.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.txtMaKH, 0);
            this.txtMaKH.Size = new System.Drawing.Size(192, 34);
            this.txtMaKH.TabIndex = 3;
            // 
            // label2
            // 
            this.tablePanel2.SetColumn(this.label2, 0);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.tablePanel2.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(194, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.tablePanel2.SetColumn(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 0);
            this.label3.Name = "label3";
            this.tablePanel2.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(194, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Khách Hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenKH
            // 
            this.tablePanel2.SetColumn(this.txtTenKH, 3);
            this.txtTenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKH.Location = new System.Drawing.Point(605, 5);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtTenKH.Properties.NullValuePrompt = "Tên Khách Hàng";
            this.txtTenKH.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.txtTenKH, 0);
            this.txtTenKH.Size = new System.Drawing.Size(192, 34);
            this.txtTenKH.TabIndex = 3;
            // 
            // tablePnl
            // 
            this.tablePnl.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePnl.Controls.Add(this.tablePanel4);
            this.tablePnl.Controls.Add(this.tablePanel3);
            this.tablePnl.Controls.Add(this.lstvThanhToanTreHan);
            this.tablePnl.Controls.Add(this.tablePanel2);
            this.tablePnl.Controls.Add(this.label1);
            this.tablePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePnl.Location = new System.Drawing.Point(0, 0);
            this.tablePnl.Name = "tablePnl";
            this.tablePnl.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePnl.Size = new System.Drawing.Size(807, 507);
            this.tablePnl.TabIndex = 0;
            // 
            // tablePanel4
            // 
            this.tablePnl.SetColumn(this.tablePanel4, 0);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel4.Controls.Add(this.btnDong);
            this.tablePanel4.Controls.Add(this.btnThanhToan);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(3, 353);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePnl.SetRow(this.tablePanel4, 4);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(801, 151);
            this.tablePanel4.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btnDong, 3);
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDong.ImageOptions.Image = global::GUI.Properties.Resources.icons8_close_pane_321;
            this.btnDong.Location = new System.Drawing.Point(604, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btnDong, 0);
            this.btnDong.Size = new System.Drawing.Size(194, 145);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btnThanhToan, 2);
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThanhToan.ImageOptions.Image = global::GUI.Properties.Resources.icons8_card_payment_32;
            this.btnThanhToan.Location = new System.Drawing.Point(404, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btnThanhToan, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(194, 145);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // tablePanel3
            // 
            this.tablePnl.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel3.Controls.Add(this.label4);
            this.tablePanel3.Controls.Add(this.txtTongTien);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(3, 303);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePnl.SetRow(this.tablePanel3, 3);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(801, 44);
            this.tablePanel3.TabIndex = 4;
            // 
            // label4
            // 
            this.tablePanel3.SetColumn(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 0);
            this.label4.Name = "label4";
            this.tablePanel3.SetRow(this.label4, 0);
            this.label4.Size = new System.Drawing.Size(194, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            this.tablePanel3.SetColumn(this.txtTongTien, 3);
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Location = new System.Drawing.Point(605, 5);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.NullValuePrompt = "Tổng Tiền";
            this.txtTongTien.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.txtTongTien, 0);
            this.txtTongTien.Size = new System.Drawing.Size(192, 34);
            this.txtTongTien.TabIndex = 3;
            // 
            // lstvThanhToanTreHan
            // 
            this.lstvThanhToanTreHan.CheckBoxes = true;
            this.tablePnl.SetColumn(this.lstvThanhToanTreHan, 0);
            this.lstvThanhToanTreHan.ContextMenuStrip = this.contextMenu;
            this.lstvThanhToanTreHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvThanhToanTreHan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvThanhToanTreHan.HideSelection = false;
            this.lstvThanhToanTreHan.Location = new System.Drawing.Point(3, 103);
            this.lstvThanhToanTreHan.Name = "lstvThanhToanTreHan";
            this.tablePnl.SetRow(this.lstvThanhToanTreHan, 2);
            this.lstvThanhToanTreHan.Size = new System.Drawing.Size(801, 194);
            this.lstvThanhToanTreHan.TabIndex = 2;
            this.lstvThanhToanTreHan.UseCompatibleStateImageBehavior = false;
            this.lstvThanhToanTreHan.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvThanhToanTreHan_ItemChecked);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHuyKhoanTre,
            this.btnChonTatCa,
            this.btnHuyTatCa});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(193, 82);
            // 
            // btnHuyKhoanTre
            // 
            this.btnHuyKhoanTre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyKhoanTre.Image = global::GUI.Properties.Resources.icons8_unavailable_16;
            this.btnHuyKhoanTre.Name = "btnHuyKhoanTre";
            this.btnHuyKhoanTre.Size = new System.Drawing.Size(192, 26);
            this.btnHuyKhoanTre.Text = "Hủy Khoản Trễ";
            this.btnHuyKhoanTre.Click += new System.EventHandler(this.btnHuyKhoanTre_Click);
            // 
            // btnChonTatCa
            // 
            this.btnChonTatCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonTatCa.Image = global::GUI.Properties.Resources.icons8_checkmark_16;
            this.btnChonTatCa.Name = "btnChonTatCa";
            this.btnChonTatCa.Size = new System.Drawing.Size(192, 26);
            this.btnChonTatCa.Text = "Chọn Tất Cả";
            this.btnChonTatCa.Click += new System.EventHandler(this.btnChonTatCa_Click);
            // 
            // btnHuyTatCa
            // 
            this.btnHuyTatCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTatCa.Image = global::GUI.Properties.Resources.icons8_multiply_16;
            this.btnHuyTatCa.Name = "btnHuyTatCa";
            this.btnHuyTatCa.Size = new System.Drawing.Size(192, 26);
            this.btnHuyTatCa.Text = "Hủy Tất Cả";
            this.btnHuyTatCa.Click += new System.EventHandler(this.btnHuyTatCa_Click);
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 507);
            this.Controls.Add(this.tablePnl);
            this.Name = "FormThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePnl)).EndInit();
            this.tablePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePnl;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnHuyKhoanTre;
        private System.Windows.Forms.ListView lstvThanhToanTreHan;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private System.Windows.Forms.ToolStripMenuItem btnChonTatCa;
        private System.Windows.Forms.ToolStripMenuItem btnHuyTatCa;
    }
}