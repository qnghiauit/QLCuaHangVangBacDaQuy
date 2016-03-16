using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DevExpress.XtraEditors;
using DTO;
using QuanLiBanVang.ExtendClass;

namespace QuanLiBanVang
{
    public partial class DanhSachDichVu : DevExpress.XtraEditors.XtraForm
    {
        private BUL_DichVu _bulDichVu;
        private DataColumn _keyField;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private List<DICHVU> _listDichvu;

        private DataTable CreateDataTable()
        {
            _dataTable = new DataTable();
            _keyField = _dataTable.Columns.Add("IDcache", typeof(int));
            _keyField.ReadOnly = true;
            _keyField.AutoIncrement = true;
            _dataTable.Columns.Add("MaDV", typeof(int));
            _dataTable.Columns.Add("TenDV", typeof(string));
            _dataTable.Columns.Add("TienCong", typeof(int));
            _listDichvu = _bulDichVu.GetAllDichvus();
            foreach (DICHVU t in _listDichvu)
            {
                _dataTable.Rows.Add(new object[] { null, t.MaDV, t.TenDV,t.TienCong });
            }
            return _dataTable;
        }

        private void FillGridView()
        {
            gridControlDSDV.DataSource = CreateDataTable();
        }
        public DanhSachDichVu()
        {
            InitializeComponent();
            _bulDichVu = new BUL_DichVu();
            FillGridView();
            gridViewDSDV.Columns[0].Visible = false;
            gridViewDSDV.Columns[1].Visible = false;
            gridViewDSDV.Columns[2].Caption = "Tên dịch vụ";
            gridViewDSDV.Columns[3].Caption = "Tiền công";
            gridViewDSDV.OptionsMenu.EnableColumnMenu = false;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            NhapDichVu nhap = new NhapDichVu();
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
            DataRow currentRow = gridViewDSDV.GetDataRow(gridViewDSDV.FocusedRowHandle);
            if (currentRow != null)
            {
                int id = Int32.Parse(currentRow[1].ToString());
                SuaDichVu sua = new SuaDichVu(id);
                DialogResult dialogResult = sua.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _bulDichVu = null;
                    _bulDichVu = new BUL_DichVu();
                    FillGridView();
                }
            }
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {
            DataRow currentRow = gridViewDSDV.GetDataRow(gridViewDSDV.FocusedRowHandle);
            if (currentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắc muốn xoá?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int id = Int32.Parse(currentRow[1].ToString());
                    _bulDichVu.DeleteDichVu(id);
                    FillGridView();
                }
            }
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewDSDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);}

        private void gridViewDSDV_DoubleClick(object sender, EventArgs e)
        {
            OpenEditDialog();
        }
    }
}