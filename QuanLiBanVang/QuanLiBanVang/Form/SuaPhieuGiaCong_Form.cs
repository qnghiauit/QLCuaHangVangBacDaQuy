using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLiBanVang.ExtendClass;
using BUL;
using DevExpress.XtraEditors.Controls;
using DTO;

namespace QuanLiBanVang
{
    public partial class SuaPhieuGiaCong_Form : DevExpress.XtraEditors.XtraForm
    {
        private DataColumn _keyFeild;
        private DataTable _dataTableCtspCanGiaCong;
        private DataTable _dataTableCtpgcReview;
        private MyCache _cache = new MyCache("IDcache");
        private int _maNV;
        private int _soPGC;
        private bool _isResultOk;
        private ComboBoxItemCollection _comboboxItemsTho;
        public SuaPhieuGiaCong_Form(int soPGC = 1)
        {
            InitializeComponent();
            _soPGC = soPGC;           
            _isResultOk = false;   
        }

        private void PhieuGiaCong_Load(object sender, EventArgs e)
        {
            dateEditNgayNhanHang.DateTime = DateTime.Today;
            LoadThongTinPgc();
            CreateDataTableCtpdvCanGiaCong();
            LoadCtpdvCanGiaCong();
            CreateDataTableCTPGC_review();
            LoadCtpgc_review();        
        }
        private void LoadThongTinPgc()
        {
            BUL_PhieuGiaCong bulPhieuGiaCong = new BUL_PhieuGiaCong();
            PHIEUGIACONG pgc = bulPhieuGiaCong.GetPhieuGiaCongById(_soPGC);
            _maNV = pgc.MaNV;
            LoadEmployeeName(_maNV);
            LoadTho(pgc.MaTho);
            this.dateEditNgayNhanHang.DateTime = pgc.NgayNhanHang;
            this.dateEditNgayThanhToan.DateTime = pgc.NgayThanhToan;          
        }
        private void CreateDataTableCtpdvCanGiaCong()
        {
            _dataTableCtspCanGiaCong = new DataTable();
            _keyFeild = _dataTableCtspCanGiaCong.Columns.Add("IDcache", typeof(int));
            _keyFeild.ReadOnly = true;
            _keyFeild.AutoIncrement = true;
            _dataTableCtspCanGiaCong.Columns.Add("Id", typeof(int));
            _dataTableCtspCanGiaCong.Columns.Add("SoPhieuDV", typeof(int));
            _dataTableCtspCanGiaCong.Columns.Add("MaLoaiSP", typeof(int));
            _dataTableCtspCanGiaCong.Columns.Add("TenLoaiSP", typeof(string));
            _dataTableCtspCanGiaCong.Columns.Add("HTGC", typeof(string));
            _dataTableCtspCanGiaCong.Columns.Add("SoLuong", typeof(int));            
            gridControlCTSPGC.DataSource = _dataTableCtspCanGiaCong;
            gridViewCTSPGC.Columns[0].Visible =
                gridViewCTSPGC.Columns[1].Visible =
                    gridViewCTSPGC.Columns[2].Visible =
                        gridViewCTSPGC.Columns[3].Visible =false;
            gridViewCTSPGC.Columns[4].Caption = "Tên loại sản phẩm";
            gridViewCTSPGC.Columns[5].Caption = "Hình thức gia công";
            gridViewCTSPGC.Columns[6].Caption = "Số lượng";
            gridViewCTSPGC.OptionsMenu.EnableColumnMenu = false;

        }
        private void CreateDataTableCTPGC_review()
        {
            _dataTableCtpgcReview = new DataTable();
            _keyFeild = _dataTableCtpgcReview.Columns.Add("IDcache", typeof(int));
            _keyFeild.ReadOnly = true;
            _keyFeild.AutoIncrement = true;
            _dataTableCtpgcReview.Columns.Add("SoPhieuDV", typeof(int));
            _dataTableCtpgcReview.Columns.Add("Id", typeof(int));
            _dataTableCtpgcReview.Columns.Add("MaLoaiSP", typeof(int));
            _dataTableCtpgcReview.Columns.Add("TenLoaiSP", typeof(string));
            _dataTableCtpgcReview.Columns.Add("HTGC", typeof(string));
            _dataTableCtpgcReview.Columns.Add("SoLuong", typeof(int));
            _dataTableCtpgcReview.Columns.Add("TienCong", typeof(int));
            _dataTableCtpgcReview.Columns.Add("ThanhTien", typeof(int));
            gridControlCTPGC_review.DataSource = _dataTableCtpgcReview;
            gridViewCTPGC_review.Columns[0].Visible =
                gridViewCTPGC_review.Columns[1].Visible =
                    gridViewCTPGC_review.Columns[2].Visible =
                        gridViewCTPGC_review.Columns[3].Visible = false;
            gridViewCTPGC_review.Columns[4].Caption = "Tên loại sản phẩm";
            gridViewCTPGC_review.Columns[5].Caption = "Hình thức gia công";
            gridViewCTPGC_review.Columns[6].Caption = "Số lượng";
            gridViewCTPGC_review.Columns[7].Caption = "Tiền công";
            gridViewCTPGC_review.Columns[8].Caption = "Thành tiền";
            gridViewCTPGC_review.OptionsMenu.EnableColumnMenu = false;

        }
        private void gridViewCT_PDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);
        }

        private void gridViewCTPGC_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);
        }
        private void LoadEmployeeName(int maNV)
        {
            BUL_NhanVien bulNhanVien = new BUL_NhanVien();
            NHANVIEN nv = bulNhanVien.getStaffById(maNV);
            this.textEditTenNhanVien.Text = nv.HoTen;
        }

        private void LoadTho(int matho)
        {
            BUL_Tho bulTho = new BUL_Tho();
            List<THO> listThos = bulTho.GetAllWorkerList();
            comboBoxEditTenTho.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            _comboboxItemsTho = comboBoxEditTenTho.Properties.Items;
            _comboboxItemsTho.BeginUpdate();
            try
            {foreach (var item in listThos)
                {
                    ContainerItem tho = new ContainerItem();
                    tho.Text = item.TenTho;
                    tho.Value = item;
                    _comboboxItemsTho.Add(tho);
                }
            }
            finally
            {
                _comboboxItemsTho.EndUpdate();
            }
            this.comboBoxEditTenTho.SelectedIndex = listThos.IndexOf(listThos.Find(i => i.MaTho == matho));
        }
        private void LoadCtpdvCanGiaCong()
        {
            BUL_LoaiSanPham bulLoaiSp = new BUL_LoaiSanPham();
            List<LOAISANPHAM> listLoaiSp = bulLoaiSp.getAllProductType();
            BUL_CTPDV bulCtpdv = new BUL_CTPDV();
            List<CTPDV> listCtpdv = bulCtpdv.GetCTPDVGiaCong();
            BUL_CTGiaCongSP bulCtGiaCongSp = new BUL_CTGiaCongSP();
            List<CTGIACONGSP> listCtgiacongsps = bulCtGiaCongSp.GetAll();
            BUL_CTPGC bulCtpgc = new BUL_CTPGC();
            _dataTableCtspCanGiaCong.Rows.Clear();
            foreach (var item in listCtpdv){
                _dataTableCtspCanGiaCong.Rows.Add(new object[]
                {
                    null,
                    item.Id,
                    item.SoPhieuDV,
                    /*MaLoaiSP*/item.MaLoaiSP == null ? -1 : item.MaLoaiSP,
                    /*TenLoaiSP*/item.MaLoaiSP == null ? "Khác" : listLoaiSp.Find(i => i.MaLoaiSP == item.MaLoaiSP).TenLoaiSP,
                    /*HTGC*/listCtgiacongsps.Find(i => i.Id == item.Id).HinhThucGiaCong,
                    /*Soluong*/item.SoLuong - bulCtpgc.GetSoluongByIdPDV(item.Id),                  
                });
            }
            gridControlCTSPGC.DataSource = _dataTableCtspCanGiaCong;

            gridViewCTSPGC.Columns["SoPhieuDV"].GroupIndex = 0;
            gridViewCTSPGC.ExpandAllGroups();
        }
        private void LoadCtpgc_review()
        {
            BUL_LoaiSanPham bulLoaiSp = new BUL_LoaiSanPham();
            BUL_CTPDV bulCtpdv = new BUL_CTPDV();
            List<LOAISANPHAM> listLoaiSp = bulLoaiSp.getAllProductType();
            BUL_CTPGC bulCtpgc = new BUL_CTPGC();
            List<CTPGC> listCtpgc = bulCtpgc.GetAllCTPGCBySoPhieuGC(_soPGC);
            BUL_CTGiaCongSP bulCtGiaCongSp = new BUL_CTGiaCongSP();
            List<CTGIACONGSP> listCtgiacongsps = bulCtGiaCongSp.GetAll();
            _dataTableCtpgcReview.Rows.Clear();
            foreach (var item in listCtpgc)
            {
                CTPDV ctpdv = bulCtpdv.GetCTPDVById(item.Id);
                _dataTableCtpgcReview.Rows.Add(new object[]
                {
                    null,
                    ctpdv.SoPhieuDV,
                    item.Id,
                    /*MaLoaiSP*/ctpdv.MaLoaiSP,
                    /*TenLoaiSP*/ctpdv.MaLoaiSP == null ? "Khác" : listLoaiSp.Find(i => i.MaLoaiSP == ctpdv.MaLoaiSP).TenLoaiSP,
                    /*HTGC*/listCtgiacongsps.Find(i => i.Id == item.Id).HinhThucGiaCong,
                    /*Soluong*/item.SoLuong,
                    /*TienCong*/item.TienCong,
                    /*ThanhTien*/item.ThanhTien
                });
            }
            gridControlCTPGC_review.DataSource = _dataTableCtpgcReview;
            gridViewCTPGC_review.Columns["SoPhieuDV"].GroupIndex = 0;
            gridViewCTPGC_review.ExpandAllGroups();
            CalculateTongTien();
        }
        private void gridViewCTPGC_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow currentRow = gridViewCTSPGC.GetDataRow(gridViewCTSPGC.FocusedRowHandle);
            if (currentRow != null)
            {
                textEditTenLoaiSP.Text = currentRow["TenLoaiSP"].ToString();
                textEditHTGC.Text = currentRow["HTGC"].ToString();
                textEditSoLuong.Text = currentRow["SoLuong"].ToString();}
        }
        private void textEditSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void textEditTienCong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void CalculateThanhTien()
        {
            string soluong = textEditSoLuong.Text;
            string tiencong = textEditTienCong.Text;
            if(soluong.Equals("") || tiencong.Equals(""))
                return;
            textEditThanhTien.Text = (Int32.Parse(soluong)*Int32.Parse(tiencong)).ToString();
        }

        private bool CheckLogicError()
        {
            string tenLoaiSp = textEditTenLoaiSP.Text;
            string soLuong = textEditSoLuong.Text;
            string tienCong = textEditTienCong.Text;
            if (tenLoaiSp.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn sản phẩm cần gia công!", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (soLuong.Equals("") || soLuong.Equals("0"))
            {
                MessageBox.Show("Bạn phải nhập vào số lượng lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tienCong.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập vào tiền công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRow currentRow = gridViewCTSPGC.GetDataRow(gridViewCTSPGC.FocusedRowHandle);
            if (Int32.Parse(soLuong) > Int32.Parse(currentRow["SoLuong"].ToString()))
            {
                MessageBox.Show("Số lượng gia công không được lớn hơn số lượng sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if(!CheckLogicError())
                return;
            string tenLoaiSp = textEditTenLoaiSP.Text;
            string soLuong = textEditSoLuong.Text;
            string tienCong = textEditTienCong.Text;
            string thanhTien = textEditThanhTien.Text;
            DataRow currentRow = gridViewCTSPGC.GetDataRow(gridViewCTSPGC.FocusedRowHandle);
            CTPGC ctpgc = new CTPGC
            {
                SoPhieuGC = _soPGC,
                Id = Convert.ToInt32(currentRow["Id"]),
                SoLuong = Convert.ToInt32(soLuong),
                TrongLuong = 0.1,
                TienCong = Convert.ToInt32(tienCong),
                ThanhTien = Convert.ToInt32(thanhTien)
            };
            BUL_CTPGC bulCtpgc = new BUL_CTPGC();
            

            DataRow drReview = _dataTableCtpgcReview.Select("Id=" + currentRow["Id"]).FirstOrDefault();
            //Neu da co trong datatable_review thi se cong them so luong va cap nhat tien cong 
            //moi nhat vao. Neu chua co thi moi add dong moi
            if (drReview != null)
            {
                ctpgc.SoLuong += Convert.ToInt32(drReview["SoLuong"]);
                ctpgc.TienCong = Convert.ToInt32(tienCong);
                ctpgc.ThanhTien = ctpgc.SoLuong * ctpgc.TienCong;
                bulCtpgc.UpdateCTPGC(ctpgc);
            }
            else
            {
                bulCtpgc.AddNewCTPGC(ctpgc);
            }

            //Neu ok het
            MessageBox.Show("Thêm chi tiết phiếu gia công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //LoadInfoCTPDV();
            _isResultOk = true;
            //UpdateDataTableCTSPCanGiaCong
            LoadCtpdvCanGiaCong();
            LoadCtpgc_review();
        }
        private void CalculateTongTien()
        {
            int tongtien = 0;
            for (int i = 0; i < _dataTableCtpgcReview.Rows.Count; i++)
            {
                tongtien += (int)_dataTableCtpgcReview.Rows[i][8];
            }
            textEditTongTien.Text = tongtien.ToString();
        }
        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (_dataTableCtpgcReview.Rows.Count == 1)
            {
                MessageBox.Show("Mỗi phiếu dịch vụ phải có ít nhất 1 chi tiết phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow currentRow = gridViewCTPGC_review.GetDataRow(gridViewCTPGC_review.FocusedRowHandle);
            if (currentRow != null)
            {
                int id = Convert.ToInt32(currentRow["Id"]);
                BUL_CTPGC bulCtpgc = new BUL_CTPGC();
                bulCtpgc.DeleteCTPGC(_soPGC,id);
                //Neu ok het
                MessageBox.Show("Xoá chi tiết phiếu gia công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCtpgc_review();
                LoadCtpdvCanGiaCong();_isResultOk = true;               
            }
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            //Check logic condition
            if (comboBoxEditTenTho.SelectedIndex == -1)
            {
                MessageBox.Show("Tên thợ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditTenTho.Focus();
                return;
            }
            if (dateEditNgayNhanHang.Text.Equals(""))
            {
                MessageBox.Show("Ngày nhận hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditNgayNhanHang.Focus();
                return;
            }
            if (dateEditNgayThanhToan.Text.Equals(""))
            {
                MessageBox.Show("Ngày thanh toán không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditNgayThanhToan.Focus();
                return;
            }
            if (dateEditNgayNhanHang.DateTime > dateEditNgayThanhToan.DateTime)
            {
                MessageBox.Show("Ngày thanh toán phải lớn hơn hoặc bằng ngày nhận hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEditNgayThanhToan.Focus();
                return;
            }
            if (_dataTableCtpgcReview.Rows.Count == 0)
            {
                MessageBox.Show("Mỗi phiếu gia công phải có ít nhất 1 chi tiết phiếu gia công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Create PGC
            BUL_PhieuGiaCong bulPhieuGiaCong = new BUL_PhieuGiaCong();
            PHIEUGIACONG phieugiacong = new PHIEUGIACONG();
            phieugiacong.NgayNhanHang = dateEditNgayNhanHang.DateTime;
            phieugiacong.NgayThanhToan = dateEditNgayThanhToan.DateTime;
            phieugiacong.MaTho = ((THO) ((ContainerItem) comboBoxEditTenTho.SelectedItem).Value).MaTho;
            phieugiacong.TongTien = Int32.Parse(textEditTongTien.Text);
            phieugiacong.MaNV = _maNV;
            bulPhieuGiaCong.UpdatePhieuGiaCong(phieugiacong);
            //Neu ok het
            MessageBox.Show("Sửa phiếu gia công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            simpleButtonLuu.Enabled = false;
            simpleButtonThem.Enabled = false;
            simpleButtonXoa.Enabled = false;
            simpleButtonSua.Enabled = false;
            _isResultOk = true;simpleButtonExit.Text = "Thoát";
        }
        private void PhieuGiaCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isResultOk)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(textEditSoLuong.Text);
            DataRow drReview = gridViewCTPGC_review.GetDataRow(gridViewCTPGC_review.FocusedRowHandle);
            BUL_CTPDV bulCtpdv = new BUL_CTPDV();
            int slTrenPDV = bulCtpdv.GetSoLuongById(Convert.ToInt32(drReview["Id"]));
            if (soluong > slTrenPDV)
            {
                MessageBox.Show("Số lượng nhập vào lớn hơn số lượng sản phẩm nhận từ khách hàng"
                    + "\nSố lượng tối đa có thể nhập: " + slTrenPDV, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUL_CTPGC bulCtpgc = new BUL_CTPGC();
            CTPGC ctpgc = new CTPGC();
            ctpgc.Id = Convert.ToInt32(drReview["Id"]);
            ctpgc.SoPhieuGC = _soPGC;
            ctpgc.TrongLuong = 0.1;
            ctpgc.SoLuong = Convert.ToInt32(soluong);
            ctpgc.TienCong = Convert.ToInt32(textEditTienCong.Text);
            ctpgc.ThanhTien = Convert.ToInt32(textEditTongTien.Text);
            bulCtpgc.UpdateCTPGC(ctpgc);
            MessageBox.Show("Sửa chi tiết phiếu gia công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCtpgc_review();
            LoadCtpdvCanGiaCong();}

        private void gridViewCTPGC_review_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow currentRow = gridViewCTPGC_review.GetDataRow(gridViewCTPGC_review.FocusedRowHandle);
            if (currentRow != null)
            {
                textEditTenLoaiSP.Text = currentRow["TenLoaiSP"].ToString();
                textEditHTGC.Text = currentRow["HTGC"].ToString();
                textEditSoLuong.Text = currentRow["SoLuong"].ToString();
                textEditTienCong.Text = currentRow["TienCong"].ToString();
                textEditSoLuong.Text = currentRow["SoLuong"].ToString();
            }
        }


    }
}