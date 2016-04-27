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
        public DanhSachPhieuBanHang()
        {
            InitializeComponent();
            // reference to grid view data source
            // Binding data into gridview
            this.gridControlListReceipts.DataSource = new BUL_PhieuBanHang().toBindingList();
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
    }
}