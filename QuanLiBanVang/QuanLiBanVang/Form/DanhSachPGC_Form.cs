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
    public partial class DanhSachPGC : DevExpress.XtraEditors.XtraForm
    {
        private BUL_PhieuGiaCong _bulPhieuGiaCong;
        private BUL_NhanVien _bulNhanVien;
        private BUL_Tho _bulTho;
        private DataColumn _keyField;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private List<PHIEUGIACONG> _listPGC;
        public DanhSachPGC()
        {
            InitializeComponent();
            _bulNhanVien = new BUL_NhanVien();
            _bulTho = new BUL_Tho();
            CreateDataTable();
        }
        private void CreateDataTable()
        {
            _bulPhieuGiaCong = new BUL_PhieuGiaCong();
            _dataTable = new DataTable();
            _keyField = _dataTable.Columns.Add("IDcache", typeof(int));
            _keyField.ReadOnly = true;
            _keyField.AutoIncrement = true;
            _dataTable.Columns.Add("SoPhieuGC", typeof(int));
            _dataTable.Columns.Add("TenTho", typeof(string));
            _dataTable.Columns.Add("TenNV", typeof(string));
            _dataTable.Columns.Add("NgayNhanHang", typeof(DateTime));
            _dataTable.Columns.Add("NgayThanhToan", typeof(DateTime));
            _dataTable.Columns.Add("TongTien", typeof(int));
            gridControlDSPDV.DataSource = _dataTable;
            gridViewDSPDV.Columns[0].Visible = 
            gridViewDSPDV.Columns[1].Visible = false;
            gridViewDSPDV.Columns[2].Caption = "Tên thợ";
            gridViewDSPDV.Columns[3].Caption = "Tên nhân viên lập";
            gridViewDSPDV.Columns[4].Caption = "Ngày nhận hàng";
            gridViewDSPDV.Columns[5].Caption = "Ngày thanh toán";
            gridViewDSPDV.Columns[6].Caption = "Tổng tiền";
            gridViewDSPDV.OptionsMenu.EnableColumnMenu = false;;
        }
        private string GetTenTho(int id)
        {
            return _bulTho.GetWorkerById(id).TenTho;
        }
        private string GetTenNv(int id)
        {
            return _bulNhanVien.getStaffById(id).HoTen;
        }
        private void FillDataTable()
        {
            _dataTable.Rows.Clear();
            _listPGC = _bulPhieuGiaCong.GetAllPhieuGiaCong();
            foreach (PHIEUGIACONG t in _listPGC)
            {
                _dataTable.Rows.Add(new object[] { 
                    null,
                    t.SoPhieuGC, 
                    GetTenTho(t.MaTho),
                    GetTenNv(t.MaNV),
                    t.NgayNhanHang,
                    t.NgayThanhToan,
                    t.TongTien});
            }
            gridControlDSPDV.DataSource = _dataTable;
        }
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            NhapPhieuGiaCong_Form nhap = new NhapPhieuGiaCong_Form();
            DialogResult result = nhap.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
                FillDataTable();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            OpenEditDialog();            
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá phiếu gia công này", "Cảnh báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Cancel)
                return;
            else
            {
                DataRow currentRow = gridViewDSPDV.GetDataRow(gridViewDSPDV.FocusedRowHandle);
                _bulPhieuGiaCong.DeletePhieuGiaCong(Convert.ToInt32(currentRow[1]));
                FillDataTable();
            }
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
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
                SuaPhieuGiaCong_Form sua = new SuaPhieuGiaCong_Form(Convert.ToInt32(currentRow[1]));
                DialogResult result = sua.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    _bulPhieuGiaCong = null;
                    _bulPhieuGiaCong = new BUL_PhieuGiaCong();
                    FillDataTable();
                }                
            }
        }

        private void DanhSachPDV_Load(object sender, EventArgs e)
        {
            FillDataTable();
        }
    }
}