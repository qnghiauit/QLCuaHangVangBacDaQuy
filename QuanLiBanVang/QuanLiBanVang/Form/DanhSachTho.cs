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
    public partial class DanhSachTho : DevExpress.XtraEditors.XtraForm
    {
        private BUL_Tho _bulTho;
        private DataColumn _keyFeild;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");
        private List<THO> _listTho;
        public DanhSachTho()
        {
            InitializeComponent();
            _bulTho = new BUL_Tho();
            FillGridView();
            gridViewDSTho.Columns[0].Visible = false;
            gridViewDSTho.Columns[1].Visible = false;
            gridViewDSTho.Columns[2].Caption = "Tên thợ";
            gridViewDSTho.Columns[3].Caption = "Số điện thoại";
            gridViewDSTho.Columns[4].Caption = "Địa chỉ";
            gridViewDSTho.OptionsMenu.EnableColumnMenu = false;
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            NhapTho nhap = new NhapTho();
            DialogResult result = nhap.ShowDialog();
            if (result == DialogResult.OK)
            {
                FillGridView();
            }
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            OpenEditDialog();
        }

        private void OpenEditDialog()
        {
            DataRow currentRow = gridViewDSTho.GetDataRow(gridViewDSTho.FocusedRowHandle);
            if (currentRow != null)
            {
                int id = Int32.Parse(currentRow[1].ToString());
                SuaTho sua = new SuaTho(id);
                DialogResult dialogResult = sua.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _bulTho = null;
                    _bulTho = new BUL_Tho();
                    FillGridView();
                }
            }
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            DataRow currentRow = gridViewDSTho.GetDataRow(gridViewDSTho.FocusedRowHandle);
            if (currentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắc muốn xoá?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int id = Int32.Parse(currentRow[1].ToString());
                    _bulTho.DeleteWorker(id);
                    FillGridView();
                }
            }
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDSTho_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _cache.getValue(e.Row);
            if (e.IsSetData)
                _cache.setValue(e.Row, e.Value);
        }
        private void FillGridView()
        {
            gridControlDSTho.DataSource = CreateDataTable();
        }

        private DataTable CreateDataTable()
        {
            _dataTable = new DataTable();
            _keyFeild = _dataTable.Columns.Add("IDcache", typeof(int));
            _keyFeild.ReadOnly = true;
            _keyFeild.AutoIncrement = true;
            _dataTable.Columns.Add("MaTho", typeof(int));
            _dataTable.Columns.Add("TenTho", typeof(string));
            _dataTable.Columns.Add("SDT", typeof(string));
            _dataTable.Columns.Add("DiaChi", typeof(string));
            _listTho = _bulTho.GetAllWorkerList();
            foreach (THO t in _listTho)
            {
                _dataTable.Rows.Add(new object[] { null, t.MaTho, t.TenTho, t.SDT, t.DiaChi });
            }
            return _dataTable;
        }

        private void gridViewDSTho_DoubleClick(object sender, EventArgs e)
        {
            OpenEditDialog();
        }
    }
}