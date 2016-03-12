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
    public partial class SuaLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        DTO.LOAISANPHAM _productType;
        BUL.BUL_LoaiSanPham _bulProductType;
        public SuaLoaiSanPham_Form()
        {
            InitializeComponent();
            _bulProductType = new BUL.BUL_LoaiSanPham();
            _productType = new DTO.LOAISANPHAM();
        }
        public SuaLoaiSanPham_Form(int id)
        {
            InitializeComponent();
            _bulProductType = new BUL.BUL_LoaiSanPham();
            _productType = new DTO.LOAISANPHAM();
            _productType = _bulProductType.getProductTypeById(id);
        }
        private void SuaLoaiSanPham_Form_Load(object sender, EventArgs e)
        {
            
            _productType = _bulProductType.getProductTypeById(1);
            if (_productType != null)
            {
                this.txtName.Text = _productType.TenLoaiSP;
                this.txtPercent.Text = _productType.PhanTramLoiNhuan.ToString(); ;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _productType.PhanTramLoiNhuan = float.Parse(txtPercent.Text);
            _productType.TenLoaiSP = txtName.Text;
            _bulProductType.updateProductType(_productType);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}