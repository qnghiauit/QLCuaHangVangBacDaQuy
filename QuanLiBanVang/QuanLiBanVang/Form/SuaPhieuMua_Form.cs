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
    public partial class SuaPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {
        private ExtendClass.MyCache _myCache;

        private DataTable _detailTable;
        private BUL.BUL_CTPM _bulBuyDetail;
        private BUL.BUL_PhieuMua _bulBuyBill;
        private BUL.BUL_SanPham _bulProduct;
        private BUL.BUL_LoaiSanPham _bulProductType;
        private BUL.BUL_KhachHang _bulClient;

        private DTO.PHIEUMUAHANG _buyBill;
        public SuaPhieuMua_Form()
        {
            InitializeComponent();
            _myCache = new ExtendClass.MyCache("Id");
            _bulBuyBill = new BUL.BUL_PhieuMua();
            _bulBuyDetail = new BUL.BUL_CTPM();
            _bulProduct = new BUL.BUL_SanPham();
            _bulProductType = new BUL.BUL_LoaiSanPham();
            _bulClient = new BUL.BUL_KhachHang();
            _detailTable = new DataTable();
        }
        public SuaPhieuMua_Form(int id)
        {
            InitializeComponent();
            _myCache = new ExtendClass.MyCache("Id");
            _bulBuyBill = new BUL.BUL_PhieuMua();
            _bulBuyDetail = new BUL.BUL_CTPM();
            _bulProduct = new BUL.BUL_SanPham();
            _bulProductType = new BUL.BUL_LoaiSanPham();
            _bulClient = new BUL.BUL_KhachHang();
            _detailTable = new DataTable();
            _buyBill = _bulBuyBill.getBuyBillById(id);
        }

        public void createTable()
        {
            _detailTable.Columns.Add("PaymentBillId", typeof(int));
            _detailTable.Columns.Add("Serial", typeof(int));
            _detailTable.Columns.Add("ProductId", typeof(int));
            _detailTable.Columns.Add("ProductTypeId", typeof(int));
            _detailTable.Columns.Add("Tên sản phẩm", typeof(string));
            _detailTable.Columns.Add("Loại sản phẩm", typeof(string));
            _detailTable.Columns.Add("Số lượng", typeof(int));
            _detailTable.Columns.Add("Trọng lượng", typeof(float));
            _detailTable.Columns.Add("Giá mua", typeof(decimal));
            _detailTable.Columns.Add("Thành tiền", typeof(decimal));
        }
        public void addNewRowToDataTable(DTO.CTPMH buydetail, string product, string producttype)
        {
            var datarow = _detailTable.NewRow();
            datarow[0] = buydetail.SoPhieuMua;
       
                datarow[1] = buydetail.STT;
            
            if (buydetail.MaSP != null)
            {
                datarow[2] = buydetail.MaSP;
            }
            if (buydetail.MaLoaiSP != null)
            {
                datarow[3] = buydetail.MaLoaiSP;
            }
            datarow[4] = product;
            datarow[5] = producttype;
            datarow[6] = buydetail.SoLuong;
            datarow[7] = buydetail.TrongLuong;
            datarow[8] = buydetail.GiaMua;
            datarow[9] = buydetail.Thanhtien;
            _detailTable.Rows.Add(datarow);
        }
        public bool CheckControlValidation()
        {
            foreach (Control control in this.groupControlGeneralInfo.Controls)
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
                    if ((control as ComboBoxEdit).SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            foreach (Control control in this.groupControlDetail.Controls)
            {
                if (control is TextEdit)
                {
                    if ((control as TextEdit).Text == "")
                    {
                        return false;
                    }
                }
            }
            if (this.dgvBuy.RowCount == 0)
            {
                return false;
            }
            return true;
        }
        private void SuaPhieuMua_Form_Load(object sender, EventArgs e)
        {
            //if (_buyBill != null)
            //{
                List<DTO.KHACHHANG> listClient = _bulClient.GetAllKhachhangs();
                List<DTO.SANPHAM> listProduct = _bulProduct.getAllProduct();
                List<DTO.LOAISANPHAM> listProductType = _bulProductType.getAllProductType();
                List<DTO.CTPMH> listBuyDetails = _bulBuyDetail.getBuyDetailsByBillId(_buyBill.SoPhieuMua);
                this.createTable();
                ExtendClass.ContainerItem blankItem = new ExtendClass.ContainerItem();
                blankItem.Text = "";
                blankItem.Value = null;
                this.cboProduct.Properties.Items.Add(blankItem);
                this.cboProductType.Properties.Items.Add(blankItem);
                foreach (DTO.SANPHAM i in listProduct)
                {
                    ExtendClass.ContainerItem item = new ExtendClass.ContainerItem();
                    item.Text = i.TenSP;
                    item.Value = item;
                    this.cboProduct.Properties.Items.Add(item);
                }
                foreach (DTO.LOAISANPHAM i in listProductType)
                {
                    ExtendClass.ContainerItem item = new ExtendClass.ContainerItem();
                    item.Text = i.TenLoaiSP;
                    item.Value = i;
                    this.cboProductType.Properties.Items.Add(item);
                }
                foreach (DTO.KHACHHANG i in listClient)
                {
                    ExtendClass.ContainerItem item = new ExtendClass.ContainerItem();
                    item.Text = i.TenKH;
                    item.Value = i;
                    this.cboClientName.Properties.Items.Add(item);
                }
                if (this._buyBill.MaKH.ToString() != "")
                {
                    this.rdoClientType.SelectedIndex = 1;
                    for (int i = 0; i < this.cboClientName.Properties.Items.Count; i++)
                    {
                        ExtendClass.ContainerItem item = this.cboClientName.Properties.Items[i] as ExtendClass.ContainerItem;
                        DTO.KHACHHANG client = item.Value as DTO.KHACHHANG;
                        if (client.MaKH == _buyBill.MaKH)
                        {
                            this.cboClientName.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    this.rdoClientType.SelectedIndex = 0;
                }
                this.dtpkCreateDate.EditValue = _buyBill.NgayMua;
                foreach (DTO.CTPMH i in listBuyDetails)
                {
                    string product = "";
                    string producttype = "";
                    if (i.MaSP.ToString() != "")
                    {
                        product = _bulProduct.getProductById((int)i.MaSP).TenSP;
                    }
                    if (i.MaLoaiSP.ToString() != "")
                    {
                        producttype = _bulProductType.getProductTypeNameById((int)i.MaLoaiSP);
                    }
                    this.addNewRowToDataTable(i, product, producttype);
                }
                this.dgvBuyList.DataSource = this._detailTable;
            //}
        }

        private void dgvBuy_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                e.Value = _myCache.getValue(e.Row);
            }
            if (e.IsSetData)
            {
                _myCache.setValue(e.Row, e.Value);
            }
        }

        private void rdoClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdoClientType.SelectedIndex == 0)
            {
                this.cboClientName.Enabled = false;
            }
            else
            {
                this.cboClientName.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO.CTPMH detail = new DTO.CTPMH();
            string product = "";
            string producttype = "";
            if (this.cboProduct.SelectedIndex != -1 && this.cboProduct.SelectedIndex != 0)
            {
                detail.MaSP = ((this.cboProduct.SelectedItem as ExtendClass.ContainerItem).Value as DTO.SANPHAM).MaSP;
                product = ((this.cboProduct.SelectedItem as ExtendClass.ContainerItem).Value as DTO.SANPHAM).TenSP;
            }
            if (this.cboProductType.SelectedIndex != -1 && this.cboProductType.SelectedIndex != 0)
            {
                detail.MaLoaiSP = ((this.cboProductType.SelectedItem as ExtendClass.ContainerItem).Value as DTO.LOAISANPHAM).MaLoaiSP;
                producttype = ((this.cboProductType.SelectedItem as ExtendClass.ContainerItem).Value as DTO.LOAISANPHAM).TenLoaiSP;
            }
            detail.SoPhieuMua = _buyBill.SoPhieuMua;
            detail.TrongLuong = float.Parse(txtWeight.Text);
            detail.SoLuong = int.Parse(txtQuantity.Text);
            detail.GiaMua = decimal.Parse(txtPrice.Text);
            detail.Thanhtien = (decimal)(detail.SoLuong * detail.GiaMua);
            
            double total = double.Parse(lbTotal.Text);
            total += (double)detail.Thanhtien;
            this.lbTotal.Text = total.ToString();

            this._bulBuyDetail.addNewBuyDetail(detail);
            
            this.addNewRowToDataTable(detail, product, producttype);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = null;
            int pos = -1;
            foreach (int i in this.dgvBuy.GetSelectedRows())
            {
                row = dgvBuy.GetDataRow(i);
                pos = i;
                break;
            }
            if (pos != -1)
            {
                this._bulBuyDetail.deleteBuyDetail((int)row[0], (int)row[1]);
                this.dgvBuy.DeleteRow(pos);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._buyBill.NgayMua = ((DateTime)this.dtpkCreateDate.EditValue).Date;
            if (this.rdoClientType.SelectedIndex == 0)
            {
                this._buyBill.MaKH = (int?)null;
            }
            else
            {
                this._buyBill.MaKH = ((this.cboClientName.SelectedItem as ExtendClass.ContainerItem).Value as DTO.KHACHHANG).MaKH;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}