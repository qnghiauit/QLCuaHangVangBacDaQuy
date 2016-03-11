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
using QuanLiBanVang.ExtendClass;
namespace QuanLiBanVang.Form
{
    public partial class NhapSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        private BUL.BUL_SanPham _bulSanPham;
        private BUL.BUL_LoaiSanPham _bulLoaiSanPham;
        public NhapSanPham_Form()
        {
            InitializeComponent();
            _bulSanPham = new BUL.BUL_SanPham();
            _bulLoaiSanPham = new BUL.BUL_LoaiSanPham();
        }
        public bool CheckControlValidation()
        {
            foreach (Control control in this.groupControlInfo.Controls)
            {
                if (control is TextEdit)
                {
                    if ((control as TextEdit).Text == "")
                    {
                        return false;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    if((control as ComboBoxEdit).SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.CheckControlValidation())
            {
                MessageBox.Show("Ban chua nhap day du thong tin can thiet.Vui long nhap lai!");
            }
            else
            {
                DTO.SANPHAM _product = new DTO.SANPHAM();

                _product.TenSP = this.txtName.Text;
                _product.MaLoaiSP = (this.cboProductType.SelectedItem as DTO.LOAISANPHAM).MaLoaiSP;
                _product.TrongLuong = float.Parse(this.txtWeight.Text);
                _product.TinhTrang = (bool)(this.radioGroupState.EditValue);

                _bulSanPham.addNewProduct(_product);
            }
        }

        private void NhapSanPham_Form_Load(object sender, EventArgs e)
        {
            this.cboProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            List<DTO.LOAISANPHAM> listProductType = _bulLoaiSanPham.getListProductType();
            foreach(DTO.LOAISANPHAM item in listProductType)
            {
                ExtendClass.ContainerItem cboItem = new ContainerItem();
                cboItem.Text = item.TenLoaiSP;
                cboItem.Value = item;
                this.cboProductType.Properties.Items.Add(cboItem);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}