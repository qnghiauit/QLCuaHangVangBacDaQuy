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
    public partial class SuaSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        BUL.BUL_SanPham _bulSanPham;
        BUL.BUL_LoaiSanPham _bulLoaiSanPham;
        DTO.SANPHAM _product;
        public SuaSanPham_Form()
        {
            InitializeComponent();
            _bulSanPham = new BUL.BUL_SanPham();
            _product = new DTO.SANPHAM();
            _bulLoaiSanPham = new BUL.BUL_LoaiSanPham();
        }
        public SuaSanPham_Form(int id)
        {
            InitializeComponent();
            _bulSanPham = new BUL.BUL_SanPham();
            _bulLoaiSanPham = new BUL.BUL_LoaiSanPham();
            _product = _bulSanPham.getProductById(id);
        }
        private void SuaSanPham_Form_Load(object sender, EventArgs e)
        {
            _product = _bulSanPham.getProductById(1);
            List<DTO.LOAISANPHAM> _listProductType = _bulLoaiSanPham.getListProductType();
            foreach(DTO.LOAISANPHAM i in _listProductType)
            {
                ContainerItem item = new ContainerItem();
                item.Text = i.TenLoaiSP;
                item.Value = item;
                this.cboProductType.Properties.Items.Add(item);
            }
            for (int i = 0; i < cboProductType.Properties.Items.Count; i++)
            {
                if((cboProductType.Properties.Items[i] as DTO.LOAISANPHAM).MaLoaiSP == _product.MaLoaiSP)
                {
                    this.cboProductType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _product.TenSP = this.txtName.Text;
            _product.TrongLuong = float.Parse(this.txtWeight.Text);
            _product.MaLoaiSP = (this.cboProductType.SelectedItem as DTO.LOAISANPHAM).MaLoaiSP;
            _product.TinhTrang = (bool)this.radioGroupState.EditValue;
            //_bulSanPham.
        }
    }
}