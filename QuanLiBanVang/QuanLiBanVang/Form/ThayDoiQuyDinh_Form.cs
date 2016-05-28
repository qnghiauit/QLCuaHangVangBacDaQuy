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
    public partial class ThayDoiQuyDinh_Form : DevExpress.XtraEditors.XtraForm
    {
        private BUL.BUL_BangThamSo _bulAgurment;
         
        public ThayDoiQuyDinh_Form()
        {
            InitializeComponent();
            _bulAgurment = new BUL.BUL_BangThamSo();
        }

        private void ThayDoiQuyDinh_Form_Load(object sender, EventArgs e)
        {
            List<DTO.BANGTHAMSO> listAgurment = _bulAgurment.getAllAgurment();
            foreach (DTO.BANGTHAMSO item in listAgurment)
            {
                ExtendClass.ContainerItem cboItem = new ExtendClass.ContainerItem();
                cboItem.Text = item.TenThamSo;
                cboItem.Value = item;
                this.cboAgurment.Properties.Items.Add(cboItem);
            }
        }

        private void cboAgurment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtValue.Text =((this.cboAgurment.SelectedItem as ExtendClass.ContainerItem).Value as DTO.BANGTHAMSO).GiaTri.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = ((this.cboAgurment.SelectedItem as ExtendClass.ContainerItem).Value as DTO.BANGTHAMSO).TenThamSo;
            double value=0;
            if (name == "PhanTramTienGCThoNhan" || name == "TienTraToiThieu")
            {
                value = (double.Parse(this.txtValue.Text) / 100);
            }

            this._bulAgurment.updateAgurment(name, value);
            //((this.cboAgurment.SelectedItem as ExtendClass.ContainerItem).Value as DTO.BANGTHAMSO).GiaTri = double.Parse(this.txtValue.Text);
            //this._bulAgurment.updateAgurment(((this.cboAgurment.SelectedItem as ExtendClass.ContainerItem).Value as DTO.BANGTHAMSO).TenThamSo,
            //    (double)((this.cboAgurment.SelectedItem as ExtendClass.ContainerItem).Value as DTO.BANGTHAMSO).GiaTri);
            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}