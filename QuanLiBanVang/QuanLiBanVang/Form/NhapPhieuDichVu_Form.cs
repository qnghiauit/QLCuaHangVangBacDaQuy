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
    public partial class NhapPhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
        private List<KHACHHANG> _listKH;
        private ComboBoxItemCollection _comboboxItemsKH;
        private DataColumn _keyFeild;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private int _maNV;
        private bool _isResultOK;
        public NhapPhieuDichVu(int maNV = 4)
        {
            InitializeComponent();
            _maNV = maNV;
            _isResultOK = false;      
        }
        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            _comboboxItemsKH = this.comboBoxEditTenKhach.Properties.Items;
            AddDichVuToComboBoxEdit();
            AddLoaiSPToComboBoxEdit();
            CreateDataTable();
            this.dateEditNgayDK.DateTime = DateTime.Today;
            LoadEmployeeName();
        }
        private void LoadEmployeeName()
        {
            BUL_NhanVien bulNhanVien = new BUL_NhanVien();
            NHANVIEN nv = bulNhanVien.getStaffById(_maNV);
            this.textEditTenNhanVien.Text = nv.HoTen;
        }
        private void AddDichVuToComboBoxEdit()
        {
            BUL_DichVu bulDichVu = new BUL_DichVu();
            ComboBoxItemCollection comboboxItemsLoaiDV = this.comboBoxEditTenDV.Properties.Items;
            List<DICHVU> listDichVu = bulDichVu.GetAllDichvus();
            comboboxItemsLoaiDV.BeginUpdate();
            try
            {
                foreach (var item in listDichVu)
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
            List<LOAISANPHAM> listLoaiSP = bulLoaiSP.getAllProductType();
            comboboxItemsLoaiSP.BeginUpdate();
            try
            {
                ContainerItem spNull = new ContainerItem();
                spNull.Text = "Khác";
                spNull.Value = null;
                comboboxItemsLoaiSP.Add(spNull);

                foreach (LOAISANPHAM item in listLoaiSP)
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
            int tiencong = Int32.Parse(this.textEditTienCong.Text == ""? "0": textEditTienCong.Text);
            int soluong = Int32.Parse(this.textEditSoLuong.Text == "" ? "0" : this.textEditSoLuong.Text);
            textEditThanhTien.Text = (tiencong * soluong).ToString();
        }
        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if(this.comboBoxEditLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Loại sản phẩm không được để trống!\nChọn Khác nếu cửa hàng không kinh doanh loại sản phẩm này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditLoaiSP.Focus();
                return;
            }
            if(this.comboBoxEditTenDV.SelectedIndex == -1)
            {
                MessageBox.Show("Tên dịch vụ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditTenDV.Focus();
                return;
            }
            if(this.textEditSoLuong.Text == "" || Int32.Parse(this.textEditSoLuong.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textEditSoLuong.Focus();
                return;
            }
            LOAISANPHAM lsp = (this.comboBoxEditLoaiSP.SelectedItem as ContainerItem).Value as LOAISANPHAM;
            DICHVU dv = (this.comboBoxEditTenDV.SelectedItem as ContainerItem).Value as DICHVU;
            _dataTable.Rows.Add(new object[] { 
                null, 
                null, 
                null, 
                /*MaLoaiSP*/lsp == null?-1:lsp.MaLoaiSP, 
                /*TenLoaiSP*/lsp == null?"Khác":lsp.TenLoaiSP, 
                /*MaDV*/dv.MaDV,
                /*TenDV*/dv.TenDV,
                /*Soluong*/Int32.Parse(this.textEditSoLuong.Text),
                /*TienCong*/Int32.Parse(this.textEditTienCong.Text),
                /*ThanhTien*/Int32.Parse(this.textEditThanhTien.Text)});

            gridControlCTPDV.DataSource = _dataTable;
            CalculateTongTien();
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            DataRow currentRow = gridViewCT_PDV.GetDataRow(gridViewCT_PDV.FocusedRowHandle);
            if (currentRow != null)
            {
                _dataTable.Rows.Remove(currentRow);
            }
            CalculateTongTien();
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
            if(this.dateEditNgayDK.Text == "")
            {
                MessageBox.Show("Ngày đăng kí không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateEditNgayDK.Focus();
                return;
            }
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
            if(this.checkEditKhachQuen.Checked && this.comboBoxEditTenKhach.SelectedIndex == -1)
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditTenKhach.Focus();
                return;
            }
            if(this._dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Mỗi phiếu dịch vụ phải có ít nhất 1 chi tiết phiếu dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEditLoaiSP.Focus();
                return;
            }

            //Create PDV
            BUL_PhieuDichVu bulPhieuDichVu = new BUL_PhieuDichVu();
            PHIEUDICHVU phieudichvu = new PHIEUDICHVU();
            if (this.checkEditKhachQuen.Checked)
            {
                KHACHHANG kh = (this.comboBoxEditTenKhach.SelectedItem as ContainerItem).Value as KHACHHANG;
                phieudichvu.MaKH = kh.MaKH;
            }
            phieudichvu.MaNV = _maNV;
            phieudichvu.NgayDangKy = this.dateEditNgayDK.DateTime;
            phieudichvu.NgayGiao = this.dateEditNgayGiao.DateTime;
            phieudichvu.TongTien = Int32.Parse(this.textEditTongTien.Text);
            int sophieudv = bulPhieuDichVu.AddNewPhieuDichVu(phieudichvu);

            //Create CTPDV
            BUL_CTPDV bulCTPDV = new BUL_CTPDV();
            foreach (DataRow row in _dataTable.Rows)
            {
                CTPDV ctpdv = new CTPDV();
                ctpdv.SoPhieuDV = sophieudv;
                int maloaisp = Convert.ToInt32(row["MaLoaiSP"]);
                if (maloaisp != -1)
                    ctpdv.MaLoaiSP = maloaisp;
                ctpdv.MaDV = Convert.ToInt32(row["MaDV"]);
                ctpdv.SoLuong = Convert.ToInt32(row["SoLuong"]);
                ctpdv.TienCong = Convert.ToInt32(row["TienCong"]);
                ctpdv.ThanhTien = Convert.ToInt32(row["ThanhTien"]);
                bulCTPDV.AddNewCTPDV(ctpdv);
            }

            //Neu ok het
            MessageBox.Show("Phiếu dịch vụ được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.simpleButtonOK.Enabled = false;
            this.simpleButtonThem.Enabled = false;
            this.simpleButtonXoa.Enabled = false;
            _isResultOK = true;

        }

        private void NhapPhieuDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isResultOK)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void textEditTienCong_EditValueChanged_1(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        

        
        
    }
}