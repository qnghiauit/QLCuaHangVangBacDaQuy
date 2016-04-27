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
using DTO;
using BUL;
using QuanLiBanVang.ExtendClass;

namespace QuanLiBanVang
{
    public partial class DanhSachPDV : DevExpress.XtraEditors.XtraForm
    {
        private BUL_PhieuDichVu _bulPhieuDichVu;
        private BUL_NhanVien _bulNhanVien;
        private BUL_KhachHang _bulKhachHang;
        private DataColumn _keyField;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private List<PHIEUDICHVU> _listPDV;
        public DanhSachPDV()
        {
            InitializeComponent();
            _bulNhanVien = new BUL_NhanVien();
            _bulKhachHang = new BUL_KhachHang();
            CreateDataTable();
        }
        private void CreateDataTable()
        {
            _bulPhieuDichVu = new BUL_PhieuDichVu();
            _dataTable = new DataTable();
            _keyField = _dataTable.Columns.Add("IDcache", typeof(int));
            _keyField.ReadOnly = true;
            _keyField.AutoIncrement = true;
            _dataTable.Columns.Add("SoPhieuDV", typeof(int));
            _dataTable.Columns.Add("TenKH", typeof(string));
            _dataTable.Columns.Add("TenNV", typeof(string));
            _dataTable.Columns.Add("NgayDangKy", typeof(DateTime));
            _dataTable.Columns.Add("NgayGiao", typeof(DateTime));
            _dataTable.Columns.Add("TongTien", typeof(int));
            gridControlDSPDV.DataSource = _dataTable;
            gridViewDSPDV.Columns[0].Visible = 
            gridViewDSPDV.Columns[1].Visible = false;
            gridViewDSPDV.Columns[2].Caption = "Tên khách hàng";
            gridViewDSPDV.Columns[3].Caption = "Tên nhân viên";
            gridViewDSPDV.Columns[4].Caption = "Ngày đăng ký";
            gridViewDSPDV.Columns[5].Caption = "Ngày giao";
            gridViewDSPDV.Columns[6].Caption = "Tổng tiền";
            gridViewDSPDV.OptionsMenu.EnableColumnMenu = false;;
        }
        private string GetTenKH(int id)
        {
            if (id == 0)
                return "Khách vãng lai";
            return _bulKhachHang.GetKhachhangById(id).TenKH;
        }
        private string GetTenNV(int id)
        {
            return _bulNhanVien.getStaffById(id).HoTen;
        }
        private void FillGridView()
        {
            _dataTable.Rows.Clear();
            _listPDV = _bulPhieuDichVu.GetAllPhieuDichVu();
            foreach (PHIEUDICHVU t in _listPDV)
            {
                _dataTable.Rows.Add(new object[] { 
                    null,
                    t.SoPhieuDV, 
                    GetTenKH(t.MaKH??0),
                    GetTenNV(t.MaNV),
                    t.NgayDangKy,
                    t.NgayGiao,
                    t.TongTien});
            }
            gridControlDSPDV.DataSource = _dataTable;
        }
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            NhapPhieuDichVu nhap = new NhapPhieuDichVu();
            DialogResult result = nhap.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
                FillGridView();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            OpenEditDialog();            
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDSPDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);
        }

        private void gridViewDSPDV_DoubleClick(object sender, EventArgs e)
        {
            OpenEditDialog();  
        }
        private void OpenEditDialog()
        {
            DataRow currentRow = gridViewDSPDV.GetDataRow(gridViewDSPDV.FocusedRowHandle);
            if (currentRow != null)
            {
                SuaPhieuDichVu sua = new SuaPhieuDichVu(Convert.ToInt32(currentRow[1]));
                DialogResult result = sua.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    _bulPhieuDichVu = null;
                    _bulPhieuDichVu = new BUL_PhieuDichVu();
                    FillGridView();
                }                
            }
        }

        private void DanhSachPDV_Load(object sender, EventArgs e)
        {
            FillGridView();
        }
    }
}