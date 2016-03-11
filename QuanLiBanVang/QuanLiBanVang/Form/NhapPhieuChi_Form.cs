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

namespace QuanLiBanVang.Form
{
    public partial class NhapPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {
        public NhapPhieuChi_Form()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhapPhieuChi_Form_Load(object sender, EventArgs e)
        {
            this.dtpkCreateDate.EditValue = DateTime.Now;
            this.dtpkCreateDate.Enabled = false;
        }
    }
}