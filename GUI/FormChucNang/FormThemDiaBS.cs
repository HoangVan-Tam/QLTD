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
    public partial class FormThemDiaBS : Form
    {
        private int idTitle;
        private DiskBUL db;
        public FormThemDiaBS(int idTitle)
        {
            InitializeComponent();
            this.idTitle = idTitle;
            db = new DiskBUL();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemDiaBS_Load(object sender, EventArgs e)
        {
            LoadView();
        }
        private void LoadView()
        {
            txt_TieuDe.Text = this.idTitle.ToString();
        }

        private void btn_ThemDiaBS_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLuongDia.CheckSoLuong() == false)
                    return;
                DialogResult result = MessageBox.Show("Xác nhận thêm đĩa bản sao", "Thêm đĩa bản sao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    int count = Int32.Parse(txt_SoLuongDia.Text.ToString());
                    while (count > 0)
                    {
                        Disk disk = new Disk { IdTitle = Int32.Parse(txt_TieuDe.Text.ToString()) };
                        if (db.AddDisk(disk) == false)
                        {
                            MessageBox.Show("Thêm thất bại", "Thêm tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        count--;
                    }
                    MessageBox.Show("Thêm thành công", "Thêm đĩa bản sao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
