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
    public partial class NhapCTGiaCongSP_Form : DevExpress.XtraEditors.XtraForm
    {
        private DataColumn _keyFeild;
        private DataTable _dataTable;
        private MyCache _cache = new MyCache("IDcache");

        public NhapCTGiaCongSP_Form()
        {
            InitializeComponent();
            CreateDataTable();
            LoadData();}

        private void CreateDataTable()
        {
            _dataTable = new DataTable();
            _keyFeild = _dataTable.Columns.Add("IDcache", typeof (int));
            _keyFeild.ReadOnly = true;
            _keyFeild.AutoIncrement = true;
            _dataTable.Columns.Add("Id", typeof (int));
            _dataTable.Columns.Add("SoPhieuDV", typeof (int));
            _dataTable.Columns.Add("MaLoaiSP", typeof (int));
            _dataTable.Columns.Add("TenLoaiSP", typeof (string));
            _dataTable.Columns.Add("SoLuong", typeof (int));
            _dataTable.Columns.Add("HTGC", typeof (string));
            _dataTable.Columns.Add("IsEdit", typeof(bool));
            gridControlCTGCSP.DataSource = _dataTable;
            gridViewCTGCSP.Columns[0].Visible =
                gridViewCTGCSP.Columns[1].Visible =
                    gridViewCTGCSP.Columns[2].Visible =
                        gridViewCTGCSP.Columns[3].Visible =
                            gridViewCTGCSP.Columns[7].Visible = false;
            gridViewCTGCSP.Columns[4].Caption = "Tên loại sản phẩm";
            gridViewCTGCSP.Columns[6].Caption = "Hình thức gia công";
            gridViewCTGCSP.Columns[5].Caption = "Số lượng";
            gridViewCTGCSP.OptionsMenu.EnableColumnMenu = false;
        }

        private void LoadData()
        {
            BUL_LoaiSanPham bulLoaiSP = new BUL_LoaiSanPham();
            List<LOAISANPHAM> _listLoaiSP = bulLoaiSP.getAllProductType();
            BUL_CTPDV _bulCTPDV = new BUL_CTPDV();
            List<CTPDV> listCTPDV = _bulCTPDV.GetCTPDVGiaCong();
            BUL_CTGiaCongSP _bulCtGiaCongSp = new BUL_CTGiaCongSP();
            List<CTGIACONGSP> _listCtgiacongsps = _bulCtGiaCongSp.GetAll();
            _dataTable.Rows.Clear();
            foreach (var item in listCTPDV)
            {
                _dataTable.Rows.Add(new object[]
                {
                    null,
                    item.Id,item.SoPhieuDV,
                    /*MaLoaiSP*/item.MaLoaiSP == null ? -1 : item.MaLoaiSP,
                    /*TenLoaiSP*/
                    item.MaLoaiSP == null ? "Khác" : _listLoaiSP.Find(i => i.MaLoaiSP == item.MaLoaiSP).TenLoaiSP,
                    /*Soluong*/item.SoLuong,
                    /*HTGC*/_listCtgiacongsps.Find(i => i.Id == item.Id).HinhThucGiaCong
                });
            }
            gridControlCTGCSP.DataSource = _dataTable;

            gridViewCTGCSP.Columns["SoPhieuDV"].GroupIndex = 0;
            gridViewCTGCSP.ExpandAllGroups();

            //gridViewCTPGC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            //gridViewCTPGC.OptionsSelection.MultiSelect = true;}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BUL_CTGiaCongSP _bulCtGiaCongSp = new BUL_CTGiaCongSP();
            foreach (DataRow row in _dataTable.Rows)
            {
                _bulCtGiaCongSp.UpdateCTGiaCongSP(Convert.ToInt32(row["Id"]), row["HTGC"].ToString());
            }

        }
    }
}