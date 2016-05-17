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
using BUL;
using DTO;
using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.Model;

namespace QuanLiBanVang.Form
{
    public partial class DanhSachPhieuThuNo : DevExpress.XtraEditors.XtraForm
    {
        private BUL_KhachHang bulKhachHang;
        private BUL_PhieuBanHang bulPhieuBanHang;
        public DanhSachPhieuThuNo()
        {
            InitializeComponent();
            this.bulKhachHang = new BUL_KhachHang();
        }

        private void DanhSachPhieuThuNo_Load(object sender, EventArgs e)
        {
            // load danh sach khach hang into combobox
            List<KHACHHANG> listKhachHangs = this.bulKhachHang.GetAllKhachhangs();
            foreach (KHACHHANG item in listKhachHangs)
            {
                this.comboBoxEditKhachHang.Properties.Items.Add(new ContainerItem
                {
                    Text = item.TenKH + "-" + item.SDT,
                    Value = item
                });
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.gridControlDanhSachPhieuNo.DataSource = null;
            // see all receipts of selected frequenter //
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditKhachHang.SelectedItem;
            KHACHHANG selectedFrequenter = (KHACHHANG)selectedItem.Value;

            this.bulPhieuBanHang = new BUL_PhieuBanHang();
            this.gridControlPhieuBanHang.RefreshDataSource();
            this.gridControlPhieuBanHang.DataSource = this.bulPhieuBanHang.findReceiptsByFrequenterId(selectedFrequenter.MaKH);
        }

        private void xemPhiếuNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridView1.DataRowCount == 0)
            {
                return;
            }
            PHIEUBANHANG selectedReceipt = (PHIEUBANHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            // start to look up all dept receipts
            this.bulPhieuBanHang = new BUL_PhieuBanHang();
            this.gridControlDanhSachPhieuNo.RefreshDataSource();
            this.gridControlDanhSachPhieuNo.DataSource = this.bulPhieuBanHang.findDeptReceiptsByReceiptId(selectedReceipt.SoPhieuBH);
        }

        private void lậpPhiếuNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the focused row
            if (this.gridView1.DataRowCount == 0)
            {
                return;
            }
            PHIEUBANHANG selectedReceipt = (PHIEUBANHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            // check if this recept has dept recepit or not ?
            if (this.bulPhieuBanHang.hasDebtReceipts(selectedReceipt.SoPhieuBH) == false)
            {
                // create the first dept receipt
                PhieuThuTienNo firstDeptReceiptForm = new PhieuThuTienNo(selectedReceipt);
                firstDeptReceiptForm.ShowDialog();
            }
            else
            {
                // get the last dept recpeit
                PHIEUTHUTIENNO lastDeptReceip = this.bulPhieuBanHang.findTheLastDeiptReceiptFromReceiptId(selectedReceipt.SoPhieuBH);
                // check if user paid for all the depts
                if (decimal.Equals(lastDeptReceip.SoTienConLai, decimal.Zero))
                {
                    MessageBox.Show("Phiếu bán hàng này đã được trả nợ hết !", ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // start to show the form
                PhieuThuTienNo deptReceiptForm = new PhieuThuTienNo(lastDeptReceip);
                deptReceiptForm.ShowDialog();

            }
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}