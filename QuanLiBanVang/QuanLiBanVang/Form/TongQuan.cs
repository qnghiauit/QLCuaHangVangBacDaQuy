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

namespace QuanLiBanVang
{
    public partial class TongQuan : DevExpress.XtraEditors.XtraForm
    {
        public TongQuan()
        {
            InitializeComponent();
        }

        private void TongQuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQLCuaHangVangBacDaQuyDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dBQLCuaHangVangBacDaQuyDataSet.SANPHAM);

        }
    }
}