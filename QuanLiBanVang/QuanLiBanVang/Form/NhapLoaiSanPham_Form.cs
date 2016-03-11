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
    public partial class NhapLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        DTO.LOAISANPHAM _newProductType;
        BUL.BUL_LoaiSanPham _bulProductType;
        public NhapLoaiSanPham_Form()
        {
            InitializeComponent();
            _newProductType = new DTO.LOAISANPHAM();
            _bulProductType = new BUL.BUL_LoaiSanPham();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _newProductType.PhanTramLoiNhuan = float.Parse(this.txtPercent.Text);
            _newProductType.TenLoaiSP = this.txtName.Text;
            _bulProductType.addNewProductType(_newProductType);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}