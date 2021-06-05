using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BUL;

namespace GUI.FormChucNang
{
    public partial class FormThemTD : Form
    {
        private TitleBUL db;
        public FormThemTD()
        {
            InitializeComponent();
            db = new TitleBUL();
        }

        private void FormThemTD_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.AddToComboBoxKindOfTitle(cbx_LoaiDia);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLuongDia.CheckSoLuong() == false)
                    return;
                DialogResult result = MessageBox.Show("Xác nhận thêm tiêu đề", "Thêm tiêu đề", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Title title = new Title { NameTitle = txt_TenTieuDe.Text.ToString(), IdDiskType = Int32.Parse(cbx_LoaiDia.SelectedValue.ToString()) };
                    if (db.AddTitle(title) == false)
                    {
                        MessageBox.Show("Thêm thất bại", "Thêm tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DiskBUL lstDisk = new DiskBUL();
                    int count = Int32.Parse(txt_SoLuongDia.Text.ToString());
                    int idTitleLast = db.GetLastTitle();
                    while (count > 0)
                    {
                        Disk disk = new Disk { IdTitle = idTitleLast };
                        if (lstDisk.AddDisk(disk) == false)
                        {
                            MessageBox.Show("Thêm thất bại", "Thêm tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        count--;
                    }
                    MessageBox.Show("Thêm thành công", "Thêm tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
