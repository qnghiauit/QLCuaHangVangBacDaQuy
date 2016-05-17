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
using DevExpress.XtraEditors.Controls;
using QuanLiBanVang.ExtendClass;
using BUL;
using DTO;

namespace QuanLiBanVang
{
    public partial class SuaPhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
        private BUL_PhieuDichVu _bulPhieuDichVu;
        private BUL_CTPDV _bulCTPDV;
        private PHIEUDICHVU _pdv;
        private List<KHACHHANG> _listKH;
        private List<DICHVU> _listDichVu;
        private List<LOAISANPHAM> _listLoaiSP;
        private ComboBoxItemCollection _comboboxItemsKH;
        private DataColumn _keyFeild;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private int _soPDV;
        private bool _isResultOK;
        public SuaPhieuDichVu(int soPDV)
        {
            InitializeComponent();
            _soPDV = soPDV;
            _isResultOK = false;
            _bulPhieuDichVu = new BUL_PhieuDichVu();
            _bulCTPDV = new BUL_CTPDV();
        }
        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            _comboboxItemsKH = this.comboBoxEditTenKhach.Properties.Items;
            simpleButtonOK.Enabled = false;
            checkEditKhachQuen.ReadOnly = true;
            AddDichVuToComboBoxEdit();
            AddLoaiSPToComboBoxEdit();
            CreateDataTable();
            LoadInfoPDV();        
        }
        private void LoadInfoPDV()
        {
            _pdv = _bulPhieuDichVu.GetPhieuDichVuById(_soPDV);
            LoadEmployeeName(_pdv.MaNV);
            this.dateEditNgayDK.DateTime = _pdv.NgayDangKy;
            this.dateEditNgayDK.ReadOnly = true;
            this.dateEditNgayGiao.DateTime = _pdv.NgayGiao;
            this.checkEditKhachQuen.ReadOnly =
            this.comboBoxEditTenKhach.ReadOnly = 
            this.textEditDiaChi.ReadOnly = true;
            int makh = _pdv.MaKH ?? 0;
            if (makh == 0)
            {
                this.checkEditKhachQuen.Checked = false;
                comboBoxEditTenKhach.Text = "Khách vãng lai";
            }
            else
            {
                this.checkEditKhachQuen.Checked = true;
                this.comboBoxEditTenKhach.SelectedIndex = _listKH.IndexOf(_listKH.Find(i => i.MaKH == makh));
            }
            LoadInfoCTPDV();
        }
        private void LoadInfoCTPDV()
        {
            List<CTPDV> listCTPDV = _bulCTPDV.GetAllCTPDVBySoPhieuDV(_soPDV);
            _dataTable.Rows.Clear();
            foreach (var item in listCTPDV)
            {
                _dataTable.Rows.Add(new object[] { 
                null, 
                item.Id, 
                item.SoPhieuDV, 
                /*MaLoaiSP*/item.MaLoaiSP == null?-1:item.MaLoaiSP, 
                /*TenLoaiSP*/item.MaLoaiSP == null?"Khác":_listLoaiSP.Find(i => i.MaLoaiSP == item.MaLoaiSP).TenLoaiSP, 
                /*MaDV*/item.MaDV,
                /*TenDV*/_listDichVu.Find(i => i.MaDV == item.MaDV).TenDV,
                /*Soluong*/item.SoLuong,
                /*TienCong*/item.TienCong,
                /*ThanhTien*/item.ThanhTien});
            }
            gridControlCTPDV.DataSource = _dataTable;
            CalculateTongTien();
        }
        private void LoadEmployeeName(int maNV)
        {
            BUL_NhanVien bulNhanVien = new BUL_NhanVien();
            NHANVIEN nv = bulNhanVien.getStaffById(maNV);
            this.textEditTenNhanVien.Text = nv.HoTen;
        }
        private void AddDichVuToComboBoxEdit()
        {
            BUL_DichVu bulDichVu = new BUL_DichVu();
            ComboBoxItemCollection comboboxItemsLoaiDV = this.comboBoxEditTenDV.Properties.Items;
            _listDichVu = bulDichVu.GetAllDichvus();
            comboboxItemsLoaiDV.BeginUpdate();
            try
            {
                foreach (var item in _listDichVu)
                {
                    ContainerItem dv = new ContainerItem();
                    dv.Text = item.TenDV;
                    dv.Value = item;
                    comboboxItemsLoaiDV.Add(dv);
                }
            }
            finally
            {
                comboboxItemsLoaiDV.EndUpdate();
            }
        }
        private void AddLoaiSPToComboBoxEdit()
        {
            BUL_LoaiSanPham bulLoaiSP = new BUL_LoaiSanPham();
            ComboBoxItemCollection comboboxItemsLoaiSP = this.comboBoxEditLoaiSP.Properties.Items;
            _listLoaiSP = bulLoaiSP.getAllProductType();
            comboboxItemsLoaiSP.BeginUpdate();
            try
            {
                ContainerItem spNull = new ContainerItem();
                spNull.Text = "Khác";
                spNull.Value = null;
                comboboxItemsLoaiSP.Add(spNull);

                foreach (LOAISANPHAM item in _listLoaiSP)
                {
                    ContainerItem sp = new ContainerItem();
                    sp.Text = item.TenLoaiSP;
                    sp.Value = item;
                    comboboxItemsLoaiSP.Add(sp);
                }
            }
            finally
            {
                comboboxItemsLoaiSP.EndUpdate();
            }
        }
        private void AddKhachHangToComboEdit()
        {
            ClearAllItemInComboboxKH();
            if(_listKH == null)
            {
                BUL_KhachHang bulKhachHang = new BUL_KhachHang();
                _listKH = bulKhachHang.GetAllKhachhangs();
            }
            _comboboxItemsKH.BeginUpdate();
            try
            {
                foreach (var item in _listKH)
                {
                    ContainerItem kh = new ContainerItem();
                    kh.Text = item.TenKH;
                    kh.Value = item;
                    _comboboxItemsKH.Add(kh);
                }
            }
            finally
            {
                _comboboxItemsKH.EndUpdate();
            }
        }
        private void ClearAllItemInComboboxKH()
        {
            while (_comboboxItemsKH.Count != 0)
            {
                _comboboxItemsKH.RemoveAt(0);
            }
            this.comboBoxEditTenKhach.SelectedIndex = -1;
        }
        private void checkEditKhachQuen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkEditKhachQuen.Checked)
            {
                this.comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
                AddKhachHangToComboEdit();
                this.comboBoxEditTenKhach.SelectedIndex = -1;
            }
            else
            {
                this.comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.Standard;
                ClearAllItemInComboboxKH();           
            }
        }
        private void gridViewCT_PDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);
        }
        private void CreateDataTable()
        {
            _dataTable = new DataTable();
            _keyFeild = _dataTable.Columns.Add("IDcache", typeof(int));
            _keyFeild.ReadOnly = true;
            _keyFeild.AutoIncrement = true;
            _dataTable.Columns.Add("Id", typeof(int));
            _dataTable.Columns.Add("SoPhieuDV", typeof(int));
            _dataTable.Columns.Add("MaLoaiSP", typeof(int));
            _dataTable.Columns.Add("TenLoaiSP", typeof(string));
            _dataTable.Columns.Add("MaDV", typeof(int));
            _dataTable.Columns.Add("TenDV", typeof(string));
            _dataTable.Columns.Add("SoLuong", typeof(int));
            _dataTable.Columns.Add("TienCong", typeof(int));
            _dataTable.Columns.Add("ThanhTien", typeof(int));
            gridControlCTPDV.DataSource = _dataTable;
            gridViewCT_PDV.Columns[0].Visible =
            gridViewCT_PDV.Columns[1].Visible =
            gridViewCT_PDV.Columns[2].Visible =
            gridViewCT_PDV.Columns[3].Visible =
            gridViewCT_PDV.Columns[5].Visible = false;
            gridViewCT_PDV.Columns[4].Caption = "Tên loại sản phẩm";
            gridViewCT_PDV.Columns[6].Caption = "Tên dịch vụ";
            gridViewCT_PDV.Columns[7].Caption = "Số lượng";
            gridViewCT_PDV.Columns[8].Caption = "Tiền công";
            gridViewCT_PDV.Columns[9].Caption = "Thành tiền";
            gridViewCT_PDV.OptionsMenu.EnableColumnMenu = false;
        }
        private void comboBoxEditTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUL_DichVu bulDichVu = new BUL_DichVu();
            DICHVU dv = (this.comboBoxEditTenDV.SelectedItem as ContainerItem).Value as DICHVU;
            decimal tiencong = bulDichVu.GetDichvuById(dv.MaDV).TienCong??0;
            this.textEditTienCong.Text = ((int)tiencong).ToString();
            CalculateThanhTien();
            if (dv.MaDV == 2)
                textEditTienCong.ReadOnly = false;
            else
                textEditTienCong.ReadOnly = true;
        }
        private void textEditSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void CalculateThanhTien()
        {
            int tiencong = Int32.Parse(this.textEditTienCong.Text == "" ? "0" : textEditTienCong.Text);
            int soluong = Int32.Parse(this.textEditSoLuong.Text == "" ? "0" : this.textEditSoLuong.Text);
            textEditThanhTien.Text = (tiencong * soluong).ToString();
        }
        private bool CheckLogicError()
        {
            if (this.comboBoxEditLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Loại sản phẩm không được để trống!\nChọn Khác nếu cửa hàng không kinh doanh loại sản phẩm này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditLoaiSP.Focus();
                return false;
            }
            if (this.comboBoxEditTenDV.SelectedIndex == -1)
            {
                MessageBox.Show("Tên dịch vụ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditTenDV.Focus();
                return false;
            }
            if (this.textEditSoLuong.Text == "" || Int32.Parse(this.textEditSoLuong.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textEditSoLuong.Focus();
                return false;
            }
            return true;
        }
        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (!CheckLogicError())
                return;
            LOAISANPHAM lsp = (this.comboBoxEditLoaiSP.SelectedItem as ContainerItem).Value as LOAISANPHAM;
            DICHVU dv = (this.comboBoxEditTenDV.SelectedItem as ContainerItem).Value as DICHVU;

            CTPDV ctpdv = new CTPDV();
            ctpdv.SoPhieuDV = _soPDV;
            if (lsp != null)
                ctpdv.MaLoaiSP = lsp.MaLoaiSP;
            ctpdv.MaDV = dv.MaDV;
            ctpdv.SoLuong = Int32.Parse(this.textEditSoLuong.Text);
            ctpdv.TienCong = Int32.Parse(this.textEditTienCong.Text);
            ctpdv.ThanhTien = Int32.Parse(this.textEditThanhTien.Text);
            _bulCTPDV.AddNewCTPDV(ctpdv);
            //Neu ok het
            MessageBox.Show("Thêm chi tiết phiếu dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInfoCTPDV();
            _isResultOK = true;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (_dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Mỗi phiếu dịch vụ phải có ít nhất 1 chi tiết phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            DataRow currentRow = gridViewCT_PDV.GetDataRow(gridViewCT_PDV.FocusedRowHandle);
            if (currentRow != null)
            {
                int id = Int32.Parse(currentRow[1].ToString());
                _bulCTPDV.DeleteCTPDVById(id);
                //Neu ok het
                MessageBox.Show("Xoá chi tiết phiếu dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInfoCTPDV();
                _isResultOK = true;
            }                
        }
        private void CalculateTongTien()
        {
            int tongtien = 0;
            for (int i = 0; i < _dataTable.Rows.Count;i++ )
            {
                tongtien += (int)_dataTable.Rows[i][9];
            }
            this.textEditTongTien.Text = tongtien.ToString();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            //Check logic condition
            if (this.dateEditNgayGiao.Text == "")
            {
                MessageBox.Show("Ngày giao không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateEditNgayDK.Focus();
                return;
            }
            if(this.dateEditNgayDK.DateTime > this.dateEditNgayGiao.DateTime)
            {
                MessageBox.Show("Ngày giao phải lớn hơn hoặc bằng ngày đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateEditNgayGiao.Focus();
                return;
            }
            if(this._dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Mỗi phiếu dịch vụ phải có ít nhất 1 chi tiết phiếu dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditLoaiSP.Focus();
                return;
            }

            //Update PDV
            _pdv.NgayGiao = this.dateEditNgayGiao.DateTime;
            _bulPhieuDichVu.UpdatePhieuDichVu(_pdv);
            //Neu ok het
            MessageBox.Show("Sửa phiếu dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.simpleButtonOK.Enabled = false;
            _isResultOK = true;

        }

        private void NhapPhieuDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isResultOK)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            DataRow currentRow = gridViewCT_PDV.GetDataRow(gridViewCT_PDV.FocusedRowHandle);
            if (currentRow != null)
            {
                int id = Int32.Parse(currentRow[1].ToString());
                if (!CheckLogicError())
                    return;
                LOAISANPHAM lsp = (this.comboBoxEditLoaiSP.SelectedItem as ContainerItem).Value as LOAISANPHAM;
                DICHVU dv = (this.comboBoxEditTenDV.SelectedItem as ContainerItem).Value as DICHVU;

                CTPDV ctpdv = _bulCTPDV.GetCTPDVById(id);
                if (lsp != null)
                    ctpdv.MaLoaiSP = lsp.MaLoaiSP;
                else
                    ctpdv.MaLoaiSP = null;
                ctpdv.MaDV = dv.MaDV;
                ctpdv.SoLuong = Int32.Parse(this.textEditSoLuong.Text);
                ctpdv.TienCong = Int32.Parse(this.textEditTienCong.Text);
                ctpdv.ThanhTien = Int32.Parse(this.textEditThanhTien.Text);
                _bulCTPDV.UpdateCTPDV(ctpdv);
                //Neu ok het
                MessageBox.Show("Sửa chi tiết phiếu dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInfoCTPDV();
                _isResultOK = true;
            }           
        }

        private void gridViewCT_PDV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow currentRow = gridViewCT_PDV.GetDataRow(gridViewCT_PDV.FocusedRowHandle);
            if (currentRow != null)
            {
                int malsp = Convert.ToInt32(currentRow["MaLoaiSP"]);
                if(malsp == -1)
                    this.comboBoxEditLoaiSP.SelectedIndex = 0;
                else
                    this.comboBoxEditLoaiSP.SelectedIndex = _listLoaiSP.IndexOf(_listLoaiSP.Find(sp => sp.MaLoaiSP == malsp)) +1 ;//+1 vì "Khác" ở vị trí 0
                this.comboBoxEditTenDV.SelectedIndex = _listDichVu.IndexOf(_listDichVu.Find(dv => dv.MaDV == Convert.ToInt32(currentRow["MaDV"])));
                this.textEditSoLuong.Text = currentRow["SoLuong"].ToString();
                this.textEditTienCong.Text = currentRow["TienCong"].ToString();
                this.textEditThanhTien.Text = currentRow["ThanhTien"].ToString();
            }
        }

        private void dateEditNgayGiao_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dateEditNgayGiao.DateTime != _pdv.NgayGiao)
                this.simpleButtonOK.Enabled = true;
            else
                this.simpleButtonOK.Enabled = false;
        }

        private void textEditTienCong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        

        
        
    }
}