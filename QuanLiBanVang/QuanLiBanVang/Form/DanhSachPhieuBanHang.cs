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
using System.Collections.ObjectModel;
using QuanLiBanVang.Model;
using DTO;
using BUL;
using System.Data.Entity;

namespace QuanLiBanVang.Form
{
    public partial class DanhSachPhieuBanHang : DevExpress.XtraEditors.XtraForm
    {
        private BUL_PhieuBanHang bulPhieuBanHang = new BUL_PhieuBanHang();
        public DanhSachPhieuBanHang()
        {
            InitializeComponent();
            // reference to grid view data source
            // Binding data into gridview
            this.gridControlListReceipts.DataSource = this.bulPhieuBanHang.toBindingList();
        }

        private void DanhSachPhieuBanHang_Load(object sender, EventArgs e)
        {

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // update new data state
            // this.bulPhieuBanHang = new BUL_PhieuBanHang();
            // this.gridControlListReceipts.DataSource = this.bulPhieuBanHang.toBindingList();

            if (this.gridView1.SelectedRowsCount < 0 || this.gridView1.SelectedRowsCount > 1 || this.gridView1.DataRowCount == 0) return;
            // get item from focused row of gridview
            PHIEUBANHANG focusedRow = (PHIEUBANHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            // open new form
            PhieuBanHang detailForm = new PhieuBanHang(ActionType.ACTION_VIEW, focusedRow);
            detailForm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PhieuBanHang newReceipt = new PhieuBanHang(ActionType.ACTION_CREATE_NEW, null);
            newReceipt.ShowDialog();
        }

        //private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // update new data state
        //    //   this.bulPhieuBanHang = new BUL_PhieuBanHang();
        //    //   this.gridControlListReceipts.DataSource = this.bulPhieuBanHang.toBindingList();

        //    if (this.gridView1.SelectedRowsCount < 0 || this.gridView1.SelectedRowsCount > 1) return;
        //    // get item from focused row of gridview
        //    PHIEUBANHANG focusedRow = (PHIEUBANHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);

        //    if (!this.bulPhieuBanHang.hasDebtReceipts(focusedRow.SoPhieuBH))
        //    {
        //        SuaPhieuBanHang updateReceipt = new SuaPhieuBanHang(focusedRow);
        //        updateReceipt.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không thể sửa phiếu bán hàng có nợ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // update new data state
            this.bulPhieuBanHang = new BUL_PhieuBanHang();
            this.gridControlListReceipts.RefreshDataSource();
            this.gridControlListReceipts.DataSource = this.bulPhieuBanHang.toBindingList();
        }
    }
}