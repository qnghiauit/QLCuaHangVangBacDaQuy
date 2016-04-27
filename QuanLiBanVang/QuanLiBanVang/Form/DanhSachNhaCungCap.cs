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
using System.Data.Entity;
using QuanLiBanVang.Model;
using DTO;
namespace QuanLiBanVang.Form
{
    public partial class DanhSachNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        // database context
        private BUL_NhaCungCap bulProvider;
        public DanhSachNhaCungCap()
        {
            InitializeComponent();
            this.bulProvider = new BUL_NhaCungCap();
            // start to get all providers from database and binding into the view list
            this.gridControlDanhSachNhaCungCap.DataSource = this.bulProvider.getAll();
        }

        private void DanhSachNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // doing nothing if no rows selected or number of selected rows is greater than 1 
            if (this.gridView1.GetSelectedRows().Count() == 0 || this.gridView1.GetSelectedRows().Count() > 1) { return; }
            // otherwise , show detail form for the selected row
            NHACUNGCAP selectedProvider = (NHACUNGCAP)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            NhaCungCap viewExistedProviderForm = new NhaCungCap(ActionType.ACTION_VIEW, selectedProvider);
            viewExistedProviderForm.ShowDialog();

        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            NhaCungCap newProviderForm = new NhaCungCap();
            newProviderForm.ShowDialog();
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}