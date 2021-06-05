namespace GUI.FormDichVu
{
    partial class FormDatTruoc
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
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btn_CheckDatTruoc = new DevExpress.XtraBars.Navigation.NavButton();
            this.btn_DanhSachDatTruoc = new DevExpress.XtraBars.Navigation.NavButton();
            this.pnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.btn_CheckDatTruoc);
            this.tileNavPane1.Buttons.Add(this.btn_DanhSachDatTruoc);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Margin = new System.Windows.Forms.Padding(4);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(1200, 66);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // btn_CheckDatTruoc
            // 
            this.btn_CheckDatTruoc.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.btn_CheckDatTruoc.Caption = "Liên Hệ Đặt Trước";
            this.btn_CheckDatTruoc.Name = "btn_CheckDatTruoc";
            this.btn_CheckDatTruoc.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btn_CheckDatTruoc_ElementClick);
            // 
            // btn_DanhSachDatTruoc
            // 
            this.btn_DanhSachDatTruoc.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.btn_DanhSachDatTruoc.Caption = "Danh Sách Đặt Trước";
            this.btn_DanhSachDatTruoc.Name = "btn_DanhSachDatTruoc";
            this.btn_DanhSachDatTruoc.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btn_DanhSachDatTruoc_ElementClick);
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 66);
            this.pnl.Margin = new System.Windows.Forms.Padding(4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1200, 592);
            this.pnl.TabIndex = 1;
            // 
            // FormDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.tileNavPane1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDatTruoc";
            this.Text = "FormDatTruoc";
            this.Load += new System.EventHandler(this.FormDatTruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton btn_CheckDatTruoc;
        private DevExpress.XtraBars.Navigation.NavButton btn_DanhSachDatTruoc;
        private System.Windows.Forms.Panel pnl;
    }
}