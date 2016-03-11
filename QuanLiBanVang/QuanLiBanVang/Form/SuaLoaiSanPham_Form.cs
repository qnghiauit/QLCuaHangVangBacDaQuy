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

namespace QuanLiBanVang.Form
{
    public partial class SuaLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        BUL.BUL_LoaiSanPham _bulProductType;
        public SuaLoaiSanPham_Form()
        {
            InitializeComponent();
            _bulProductType = new BUL.BUL_LoaiSanPham();
        }

        private void SuaLoaiSanPham_Form_Load(object sender, EventArgs e)
        {

        }
    }
}