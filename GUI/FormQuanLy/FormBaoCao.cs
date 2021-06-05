    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entities;
using BUL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace GUI.FormQuanLy
{
    public partial class FormBaoCao : DevExpress.XtraEditors.XtraForm
    {
        private TitleBUL dbTitle;
        private ListRentedBUL dbRented;
        private CustomerBUL dbCustomer;
        private ListTitlePreOrderBUL dbListPre;
        private DiskBUL dbDisk;
        private const string STATUS_RENTED = "Rented";
        private const string STATUS_ONHOLD = "OnHold";
        private const string STATUS_INCOMPLETE = "Incompleted";
        private const string STATUS_UNPAID = "Unpaid";
        private const string FORMAT_DATE = "dd/MM/yyyy";
        private BindingSource bindingTitle;
        private BindingSource bindingCustomer;
        public FormBaoCao()
        {
            InitializeComponent();
            dbTitle = new TitleBUL();
            dbRented = new ListRentedBUL();
            dbCustomer = new CustomerBUL();
            dbListPre = new ListTitlePreOrderBUL();
            dbDisk = new DiskBUL();
            bindingTitle = new BindingSource();
            bindingCustomer = new BindingSource();
        }
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                AddInfoToSuccessForm();
                LoadView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            try
            {
                navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddInfoToSuccessForm()
        {
            ExpressionMethod.AddOptionToReportCustomer(cbx_ThongKeKH);
            ExpressionMethod.EditGridView(grvDuDoan);
            ExpressionMethod.EditGridView(grvKH);
            ExpressionMethod.EditGridView(grvTieuDe);
            ExpressionMethod.EditGridView(grvTreHan);
            tablePanel7.Rows[0].Height = tablePanel7.Rows[1].Height = 270;

        }
        private void LoadView()
        {
            ReportTitle();
            ExpressionMethod.LoadGridControl(grcKH, grvKH, bindingCustomer);
        }
        private void ReportTitle()
        {
            
            var dbBSThueCuaTitle = (from d in dbDisk.GetDisks()
                                    group d by d.IdTitle into titleGroup
                                    select new
                                    {
                                        Title = titleGroup.Key,
                                        SoLuongThue = titleGroup.Where(x => x.DiskRentalStatus.Equals(STATUS_RENTED)).Count(),
                                        SoLuongBSDatTruoc = titleGroup.Where(x => x.DiskRentalStatus.Equals(STATUS_ONHOLD)).Count(),
                                    })
                                        .Join(dbTitle.GetTitles(), bs => bs.Title, t => t.IdTitle, (bs, t) => new { idTitle = t.IdTitle, TitleName = t.NameTitle, SoLuongTrenKe = t.TotalDiskOnShelf, SoLuongThue = bs.SoLuongThue, SoLuongBSDatTruoc = bs.SoLuongBSDatTruoc });
            var dbDSDatTruoc = from pre in dbListPre.GetListTitlePreOrders().Where(x => x.StatusProcess.Equals(STATUS_INCOMPLETE))
                               group pre by pre.IdTitle into preListGroup
                               select new
                               {
                                   idTitle = preListGroup.Key,
                                   TongDatTruoc = preListGroup.Sum(x => x.NumberOfDisk)
                               };
            var db = dbBSThueCuaTitle 
                .GroupJoin(dbDSDatTruoc, bss => bss.idTitle, dt => dt.idTitle, (bss, dt) => new { bss, dt })
                .SelectMany(temp => temp.dt.DefaultIfEmpty(), (bs, temp) => new { bs = bs, dt = temp });
            List<ReportTitle> lst = new List<ReportTitle>();
            foreach (var item in db)
            {
                int? tongsodattruoc = 0;
                if (item.dt != null)
                    tongsodattruoc = item.dt.TongDatTruoc;
                lst.Add(new ReportTitle { TitleName = item.bs.bss.TitleName, TongSoBanSao = item.bs.bss.SoLuongThue + item.bs.bss.SoLuongTrenKe + item.bs.bss.SoLuongBSDatTruoc, TongSoBanSaoDuocDatTruoc = tongsodattruoc, TongSoBanSaoDuocThue = item.bs.bss.SoLuongThue, TongSoBanSaoTrongKho = item.bs.bss.SoLuongTrenKe, TongSoDatTruocDangXuLi = item.bs.bss.SoLuongBSDatTruoc });

            }
            bindingTitle.DataSource = lst;
            ExpressionMethod.LoadGridControl(grcTieuDe, grvTieuDe, bindingTitle);

        }
        private void LoadDataToGridView()
        {
            var dbAllRented = dbRented.GetListRenteds();
            List<ReportCustomer> lst = new List<ReportCustomer>();
            List<Customer> customers = dbCustomer.GetCustomers();
            switch (cbx_ThongKeKH.SelectedIndex)
            {
                case 1:
                    customers = customers.Where(x => dbAllRented.Find(rt => rt.IdCustomer == x.IdCustomer && rt.ExpectedReturnDate < DateTime.Today && rt.ActualReturnDate == null) != null).ToList();
                    break;
                case 2:
                    customers = customers.Where(x => dbAllRented.Find(rt => rt.IdCustomer == x.IdCustomer && rt != null && rt.StatusOnBill != null && rt.StatusOnBill.Equals(STATUS_UNPAID)) != null).ToList();
                    break;
            }
            foreach (var item in customers)
            {
                int sodiathue = dbAllRented.Where(x => x.IdCustomer == item.IdCustomer && x.StatusOnBill == null).Count();
                lst.Add(new ReportCustomer { Address = item.Address, CustomerName = item.CustomerName, idCustomer = item.IdCustomer, PhoneNumber = item.PhoneNumber, TotalDiskRent = sodiathue });
            }
            bindingCustomer.DataSource = lst;
        }

        private void cbx_ThongKeKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grvKH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (grvKH.GetSelectedRows().Count() > 0)
                {
                    int idCustomer = ((ReportCustomer)bindingCustomer[grvKH.GetSelectedRows()[0]]).idCustomer;
                    var dbAllRented = dbRented.GetListRenteds();
                    LoadDuDoanGridView(idCustomer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadDuDoanGridView(int idCustomer)
        {
            var dbAllRented = dbRented.GetListRenteds();
            var lstDuDoan = dbAllRented.Where(x => x.IdCustomer == idCustomer && x.StatusOnBill == null && x.ExpectedReturnDate < DateTime.Today).Select(x => new { IdDisk = x.IdDisk, ExpectedReturnDate = x.ExpectedReturnDate })
                .Join(dbDisk.GetDisks(), dd => dd.IdDisk, d => d.IdDisk, (dd, d) => new { dd, d })
                .Join(dbTitle.GetTitles(), ddd => ddd.d.IdTitle, t => t.IdTitle,(ddd,t)=> new{ IdDisk = ddd.dd.IdDisk, ExpectedReturnDate = ddd.dd.ExpectedReturnDate,Title=t.NameTitle });
            var bindingDuDoan = new BindingSource();
            bindingDuDoan.DataSource = lstDuDoan;
            ExpressionMethod.LoadGridControl(grcDuDoan, grvDuDoan, bindingDuDoan);
            var lstTreHan = dbAllRented.Where(x => x.IdCustomer == idCustomer && x.StatusOnBill != null && x.StatusOnBill.Equals(STATUS_UNPAID)).Select(x => new{IdDisk=x.IdDisk,ExpectedReturnDate=x.ExpectedReturnDate,ActualReturnDate=x.ActualReturnDate,LateFee=x.LateFee });
            var bindingTreHan = new BindingSource();
            bindingTreHan.DataSource = lstTreHan;
            ExpressionMethod.LoadGridControl(grcTreHan, grvTreHan, bindingTreHan);
            double? phitrehan = 0;
            foreach (var item in lstTreHan)
            {
                phitrehan += item.LateFee;
            }
            txtTongPhiNo.Text = phitrehan.ToString();
            
        }

        private void btn_ThongKeTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThongKeKH_Click(object sender, EventArgs e)
        {
            try
            {
                //string path = @"F:\Xay dung phan mem\XDPM_NHOM11\ThongKeKH.xlsx";
                string path = Application.StartupPath + @"\Report\ThongKeKhachHang_" + DateTime.Now.ToString(FORMAT_DATE).Replace(@"/", "") + @".xlsx";

                (grcKH.MainView as GridView).OptionsPrint.PrintHeader = true;
                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                advOptions.SheetName = "Thống Kê Khách Hàng";
                grcKH.ExportToXlsx(path, advOptions);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ThongKeTieuDe_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + @"\Report\ThongKeTieuDe_" + DateTime.Now.ToString(FORMAT_DATE).Replace(@"/", "") + @".xlsx";
                (grcTieuDe.MainView as GridView).OptionsPrint.PrintHeader = true;
                XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                advOptions.SheetName = "Thống Kê Tiêu Đề";
                grcTieuDe.ExportToXlsx(path, advOptions);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}