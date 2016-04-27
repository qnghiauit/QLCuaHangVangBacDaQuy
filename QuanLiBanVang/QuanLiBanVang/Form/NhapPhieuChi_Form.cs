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

namespace QuanLiBanVang.Report
{
    public partial class NhapPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {
        private BUL.BUL_Phi _bulCostType;
        private BUL.BUL_PhieuChi _bulPaymentBill;
        private int _staffId;
        public NhapPhieuChi_Form()
        {
            InitializeComponent();
            _bulCostType = new BUL.BUL_Phi();
            _bulPaymentBill = new BUL.BUL_PhieuChi();
        }
        public NhapPhieuChi_Form(int staffid)
        {
            _bulCostType = new BUL.BUL_Phi();
            _bulPaymentBill = new BUL.BUL_PhieuChi();
            _staffId = staffid;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NhapPhieuChi_Form_Load(object sender, EventArgs e)
        {
            this.dtpkCreateDate.EditValue = DateTime.Now;
            this.dtpkCreateDate.Enabled = false;
            List<DTO.PHI> listPaymentType = new List<DTO.PHI>();
            listPaymentType = _bulCostType.getAllPaymentType(); ;
            foreach (DTO.PHI i in listPaymentType)
            {
                ExtendClass.ContainerItem item = new ExtendClass.ContainerItem();
                item.Text = i.TenPhi;
                item.Value = i;
                this.cboType.Properties.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO.PHIEUCHI newBill = new DTO.PHIEUCHI();
            newBill.MaPhi = ((this.cboType.SelectedItem as ExtendClass.ContainerItem).Value as DTO.PHIEUCHI).MaPhi;
            newBill.NgayLap = (DateTime)this.dtpkCreateDate.EditValue;
            newBill.SoTien = decimal.Parse(this.txtCost.Text);
            this._bulPaymentBill.addNewPaymentBill(newBill);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}