using System;
using System.Collections.Generic;using System.Data;
using System.Windows.Forms;
using BUL;
using DTO;
using QuanLiBanVang.ExtendClass;

namespace QuanLiBanVang
{
    public partial class DanhSachHTGC : DevExpress.XtraEditors.XtraForm
    {
        private BUL_HinhThucGiaCong _bulHinhThucGiaCong;
        private DataColumn _keyField;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private List<HINHTHUCGIACONG> _listHtgc;

        private DataTable CreateDataTable()
        {
            _dataTable = new DataTable();
            _keyField = _dataTable.Columns.Add("IDcache", typeof(int));
            _keyField.ReadOnly = true;
            _keyField.AutoIncrement = true;
            _dataTable.Columns.Add("MaHTGC", typeof (int));
            _dataTable.Columns.Add("TenHTGC", typeof (string));
            _listHtgc = _bulHinhThucGiaCong.GetAllHtgc();
            foreach (HINHTHUCGIACONG t in _listHtgc)
            {
                _dataTable.Rows.Add(new object[] {null,t.MaHTGC, t.TenHTGC});
            }
            return _dataTable;
        }

        private void FillGridView()
        {
            gridControlDS.DataSource = CreateDataTable();
        }
        public DanhSachHTGC()
        {
            InitializeComponent();
            _bulHinhThucGiaCong = new BUL_HinhThucGiaCong();      
            FillGridView();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
            gridView1.Columns[2].Caption = "Tên hình thức gia công";
            gridView1.OptionsMenu.EnableColumnMenu = false;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            NhapHinhThucGiaCong nhap = new NhapHinhThucGiaCong();
            DialogResult dialogResult = nhap.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FillGridView();
            }
            
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            OpenEditDialog();
        }

        private void OpenEditDialog()
        {
            DataRow currentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (currentRow != null)
            {
                int id = Int32.Parse(currentRow[1].ToString());
                SuaHinhThucGiaCong sua = new SuaHinhThucGiaCong(id);
                DialogResult dialogResult = sua.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _bulHinhThucGiaCong = null;
                    _bulHinhThucGiaCong = new BUL_HinhThucGiaCong();
                    FillGridView();
                }
            }
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {
            DataRow currentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (currentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắc muốn xoá?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int id = Int32.Parse(currentRow[1].ToString());
                    _bulHinhThucGiaCong.DeleteHtgc(id);
                    FillGridView();
                }            
            }
        }

        private void gridView1_CustomUnboundColumnData_1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenEditDialog();
        }

    }
}