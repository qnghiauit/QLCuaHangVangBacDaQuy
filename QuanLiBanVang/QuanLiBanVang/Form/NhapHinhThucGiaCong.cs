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

namespace QuanLiBanVang
{
    public partial class NhapHinhThucGiaCong : DevExpress.XtraEditors.XtraForm
    {
        private BUL_HinhThucGiaCong bulHinhThucGiaCong;
        public NhapHinhThucGiaCong()
        {
            InitializeComponent();
            bulHinhThucGiaCong = new BUL_HinhThucGiaCong();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.textEditTenHTGC.Text == "")
            {
                MessageBox.Show("Tên hình thức gia công không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HINHTHUCGIACONG newHinhthucgiacong = new HINHTHUCGIACONG
            {
                TenHTGC = this.textEditTenHTGC.Text        
            };
            bulHinhThucGiaCong.AddNewHtgc(newHinhthucgiacong);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}