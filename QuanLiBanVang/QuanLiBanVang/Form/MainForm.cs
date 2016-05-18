using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiBanVang
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        [System.STAThread]
        public static void ThreadProcess()
        {
            Application.Run(new MainForm());
        }
        private void InitInventoryReport()
        {
            
            BUL.BUL_BaoCaoTonKho bulReport = new BUL.BUL_BaoCaoTonKho();
            if (!bulReport.isReportExisted(DateTime.Now.Date))
            {
                BUL.BUL_SanPham bulProduct = new BUL.BUL_SanPham();
                List<DTO.SANPHAM> listproduct = bulProduct.getAllProduct();
                foreach (DTO.SANPHAM i in listproduct)
                {
                    DTO.BAOCAOTONKHO report = new DTO.BAOCAOTONKHO();
                    report.NgayBC = DateTime.Now.Date;
                    report.MaSP = i.MaSP;
                    report.TonDau = i.SoLuongTon;
                    bulReport.addNewInventoryReport(report);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        //Open from or focus if opened
        public void OpenChildForm(XtraForm form)
        {
            //Check before open
            if (!IsFormOpened(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }
        //Check if a form is opened already      
        private bool IsFormOpened(XtraForm form)
        {
            bool IsOpenend = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Active this form
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }

        private void barButtonItemDSKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachKH dsKhachHangFrom = new DanhSachKH();
            OpenChildForm(dsKhachHangFrom);
        }

        private void barButtonItemDSNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemDSThoGiaCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachTho dsThoForm = new DanhSachTho();
            OpenChildForm(dsThoForm);
        }

        private void barButtonItemDSPhieuDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachPDV danhSachPdv = new DanhSachPDV();
            OpenChildForm(danhSachPdv);
        }

        private void barButtonItemDSPhieuGC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachPGC danhSachPgc = new DanhSachPGC();
            OpenChildForm(danhSachPgc);
        }

        private void barButtonItemThemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapKhachHang nhapKhachHang = new NhapKhachHang();
            OpenChildForm(nhapKhachHang);
        }

        private void barButtonItemThemTho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapTho nhapTho = new NhapTho();
            OpenChildForm(nhapTho);
        }

        private void barButtonItemThemPGC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapPhieuGiaCong_Form nhapPhieuGiaCong = new NhapPhieuGiaCong_Form();
            OpenChildForm(nhapPhieuGiaCong);
        }

        private void barButtonItemLapPhieuDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapPhieuDichVu nhapPhieuDichVu = new NhapPhieuDichVu();
            OpenChildForm(nhapPhieuDichVu);
        }

    }
}
