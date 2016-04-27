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

        //Tìm form đã mở hay chưa, mở rồi thì focus, chưa thì show mdi
        private void CheckMdiChildren(XtraForm form)
        {
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Text == form.Text)
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }
        private void barButtonItemDSKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // DanhSachKH dsKhachHangFrom = new DanhSachKH();
            //CheckMdiChildren(dsKhachHangFrom);
        }

        private void barButtonItemDSNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemDSThoGiaCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // DanhSachTho dsThoForm = new DanhSachTho();
           // CheckMdiChildren(dsThoForm);
        }
    }
}
