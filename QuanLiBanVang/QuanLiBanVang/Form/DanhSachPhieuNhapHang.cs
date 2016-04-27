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
using QuanLiBanVang.Model;
using BUL;
using DTO;

namespace QuanLiBanVang.Form
{
    public partial class DanhSachPhieuNhapHang : DevExpress.XtraEditors.XtraForm
    {
        private BUL_PhieuNhapHang bulImportReceipt;
        public DanhSachPhieuNhapHang()
        {
            InitializeComponent();
            this.bulImportReceipt = new BUL_PhieuNhapHang();
            this.gridControl1.DataSource = this.bulImportReceipt.getAll(); // binding data for gridview
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANG selectedImportReceipt = (PHIEUNHAPHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            // start the form
            PhieuNhapHang viewImportDetailForm = new PhieuNhapHang(ActionType.ACTION_VIEW, selectedImportReceipt);
            // show form 
            viewImportDetailForm.ShowDialog();
        }

        private void DanhSachPhieuNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuNhapHang newImportReceipt = new PhieuNhapHang(ActionType.ACTION_CREATE_NEW, null);
            newImportReceipt.ShowDialog();
        }


    }
}