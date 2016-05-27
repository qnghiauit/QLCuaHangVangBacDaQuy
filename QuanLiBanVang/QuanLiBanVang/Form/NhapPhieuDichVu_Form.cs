﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using QuanLiBanVang.ExtendClass;
using BUL;
using DTO;

namespace QuanLiBanVang
{
    public partial class NhapPhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
        private List<KHACHHANG> _listKh;
        private ComboBoxItemCollection _comboboxItemsKh;
        private DataColumn _keyFeild;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private int _maNV;
        private bool _isResultOk;
        public NhapPhieuDichVu(int maNv = 4)
        {
            InitializeComponent();
            _maNV = maNv;
            _isResultOk = false;      
        }
        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            _comboboxItemsKh = comboBoxEditTenKhach.Properties.Items;
            AddDichVuToComboBoxEdit();
            AddLoaiSpToComboBoxEdit();
            CreateDataTable();
            dateEditNgayDK.DateTime = DateTime.Today;
            LoadEmployeeName();
        }
        private void LoadEmployeeName()
        {
            BUL_NhanVien bulNhanVien = new BUL_NhanVien();
            NHANVIEN nv = bulNhanVien.getStaffById(_maNV);
            textEditTenNhanVien.Text = nv.HoTen;
        }
        private void AddDichVuToComboBoxEdit()
        {
            BUL_DichVu bulDichVu = new BUL_DichVu();
            ComboBoxItemCollection comboboxItemsLoaiDv = comboBoxEditTenDV.Properties.Items;
            List<DICHVU> listDichVu = bulDichVu.GetAllDichvus();
            comboboxItemsLoaiDv.BeginUpdate();
            try
            {
                foreach (var item in listDichVu)
                {
                    ContainerItem dv = new ContainerItem();
                    dv.Text = item.TenDV;
                    dv.Value = item;
                    comboboxItemsLoaiDv.Add(dv);
                }
            }
            finally
            {
                comboboxItemsLoaiDv.EndUpdate();
            }
        }
        private void AddLoaiSpToComboBoxEdit()
        {
            BUL_LoaiSanPham bulLoaiSp = new BUL_LoaiSanPham();
            ComboBoxItemCollection comboboxItemsLoaiSp = comboBoxEditLoaiSP.Properties.Items;
            List<LOAISANPHAM> listLoaiSp = bulLoaiSp.getAllProductType();
            comboboxItemsLoaiSp.BeginUpdate();
            try
            {
                ContainerItem spNull = new ContainerItem();
                spNull.Text = "Khác";
                spNull.Value = null;
                comboboxItemsLoaiSp.Add(spNull);

                foreach (LOAISANPHAM item in listLoaiSp)
                {
                    ContainerItem sp = new ContainerItem();
                    sp.Text = item.TenLoaiSP;
                    sp.Value = item;
                    comboboxItemsLoaiSp.Add(sp);
                }
            }
            finally
            {
                comboboxItemsLoaiSp.EndUpdate();
            }
        }
        private void AddKhachHangToComboEdit()
        {
            ClearAllItemInComboboxKh();
            if(_listKh == null)
            {
                BUL_KhachHang bulKhachHang = new BUL_KhachHang();
                _listKh = bulKhachHang.GetAllKhachhangs();
            }
            _comboboxItemsKh.BeginUpdate();
            try
            {
                foreach (var item in _listKh)
                {
                    ContainerItem kh = new ContainerItem();
                    kh.Text = item.TenKH;
                    kh.Value = item;
                    _comboboxItemsKh.Add(kh);
                }
            }
            finally
            {
                _comboboxItemsKh.EndUpdate();
            }
        }
        private void ClearAllItemInComboboxKh()
        {
            while (_comboboxItemsKh.Count != 0)
            {
                _comboboxItemsKh.RemoveAt(0);
            }
            comboBoxEditTenKhach.SelectedIndex = -1;
        }
        private void checkEditKhachQuen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditKhachQuen.Checked)
            {
                comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
                AddKhachHangToComboEdit();
                comboBoxEditTenKhach.SelectedIndex = -1;
            }
            else
            {
                comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.Standard;
                ClearAllItemInComboboxKh();           
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
            _dataTable.Columns.Add("GhiChu", typeof (string));
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
            gridViewCT_PDV.Columns[10].Caption = "Ghi chú";
            gridViewCT_PDV.OptionsMenu.EnableColumnMenu = false;
        }
        private void comboBoxEditTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {            
            BUL_DichVu bulDichVu = new BUL_DichVu();
            DICHVU dv = (comboBoxEditTenDV.SelectedItem as ContainerItem).Value as DICHVU;
            decimal tiencong = bulDichVu.GetDichvuById(dv.MaDV).TienCong??0;
            textEditTienCong.Text = ((int)tiencong).ToString();
            CalculateThanhTien();
            if (dv.MaDV == 2)
            {
                textEditTienCong.ReadOnly = false;
                textEditHTGC.ReadOnly = false;
            }
            else
            {
                textEditTienCong.ReadOnly = true;
                textEditHTGC.Text = string.Empty;
                textEditHTGC.ReadOnly = true;
            }
        }
        private void textEditSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void CalculateThanhTien()
        {
            int tiencong = Int32.Parse(textEditTienCong.Text == ""? "0": textEditTienCong.Text);
            int soluong = Int32.Parse(textEditSoLuong.Text == "" ? "0" : textEditSoLuong.Text);
            textEditThanhTien.Text = (tiencong * soluong).ToString();
        }
        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if(comboBoxEditLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Loại sản phẩm không được để trống!\nChọn Khác nếu cửa hàng không kinh doanh loại sản phẩm này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditLoaiSP.Focus();
                return;
            }
            if(comboBoxEditTenDV.SelectedIndex == -1)
            {
                MessageBox.Show("Tên dịch vụ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditTenDV.Focus();
                return;
            }
            if(textEditSoLuong.Text == "" || Int32.Parse(textEditSoLuong.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEditSoLuong.Focus();
                return;
            }
            if (textEditHTGC.Text.Equals("") && comboBoxEditTenDV.Text.Equals("Gia công"))
            {
                MessageBox.Show("Bạn phải nhập hình thức gia công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEditHTGC.Focus();
                return;
            }
            LOAISANPHAM lsp = (comboBoxEditLoaiSP.SelectedItem as ContainerItem).Value as LOAISANPHAM;
            DICHVU dv = (comboBoxEditTenDV.SelectedItem as ContainerItem).Value as DICHVU;
            _dataTable.Rows.Add(new object[] { 
                null, 
                null, 
                null, 
                /*MaLoaiSP*/lsp == null?-1:lsp.MaLoaiSP, 
                /*TenLoaiSP*/lsp == null?"Khác":lsp.TenLoaiSP, 
                /*MaDV*/dv.MaDV,
                /*TenDV*/dv.TenDV,
                /*Soluong*/Int32.Parse(textEditSoLuong.Text),
                /*TienCong*/Int32.Parse(textEditTienCong.Text),
                /*ThanhTien*/Int32.Parse(textEditThanhTien.Text),
                /*GhiChu*/textEditHTGC.Text
            });

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
            textEditTongTien.Text = tongtien.ToString();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            //Check logic condition
            if(dateEditNgayDK.Text == "")
            {
                MessageBox.Show("Ngày đăng kí không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditNgayDK.Focus();
                return;
            }
            if (dateEditNgayGiao.Text == "")
            {
                MessageBox.Show("Ngày giao không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditNgayDK.Focus();
                return;
            }
            if(dateEditNgayDK.DateTime > dateEditNgayGiao.DateTime)
            {
                MessageBox.Show("Ngày giao phải lớn hơn hoặc bằng ngày đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditNgayGiao.Focus();
                return;
            }
            if(checkEditKhachQuen.Checked && comboBoxEditTenKhach.SelectedIndex == -1)
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditTenKhach.Focus();
                return;
            }
            if(_dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Mỗi phiếu dịch vụ phải có ít nhất 1 chi tiết phiếu dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditLoaiSP.Focus();
                return;
            }

            //Create PDV
            BUL_PhieuDichVu bulPhieuDichVu = new BUL_PhieuDichVu();
            PHIEUDICHVU phieudichvu = new PHIEUDICHVU();
            if (checkEditKhachQuen.Checked)
            {
                KHACHHANG kh = (comboBoxEditTenKhach.SelectedItem as ContainerItem).Value as KHACHHANG;
                phieudichvu.MaKH = kh.MaKH;
            }
            phieudichvu.MaNV = _maNV;
            phieudichvu.NgayDangKy = dateEditNgayDK.DateTime;
            phieudichvu.NgayGiao = dateEditNgayGiao.DateTime;
            phieudichvu.TongTien = Int32.Parse(textEditTongTien.Text);
            int sophieudv = bulPhieuDichVu.AddNewPhieuDichVu(phieudichvu);

            //Create CTPDV
            BUL_CTPDV bulCtpdv = new BUL_CTPDV();
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
                ctpdv.GhiChu = row["GhiChu"].ToString();
                bulCtpdv.AddNewCTPDV(ctpdv);
            }

            //Neu ok het
            MessageBox.Show("Phiếu dịch vụ được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            simpleButtonOK.Enabled = false;
            simpleButtonThem.Enabled = false;
            simpleButtonXoa.Enabled = false;
            _isResultOk = true;

        }

        private void NhapPhieuDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isResultOk)
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