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
    public partial class SuaHinhThucGiaCong : DevExpress.XtraEditors.XtraForm
    {
        private BUL_HinhThucGiaCong bulHinhThucGiaCong;
        private HINHTHUCGIACONG updateHinhthucgiacong;
        public SuaHinhThucGiaCong(int id)
        {
            InitializeComponent();
            bulHinhThucGiaCong = new BUL_HinhThucGiaCong();
            updateHinhthucgiacong = bulHinhThucGiaCong.GetHtgcById(id);
            this.textEditTenHTGC.Text = updateHinhthucgiacong.TenHTGC;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.textEditTenHTGC.Text == "")
            {
                MessageBox.Show("Tên hình thức gia công không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            updateHinhthucgiacong.TenHTGC = this.textEditTenHTGC.Text;
            bulHinhThucGiaCong.UpdateHtgc(updateHinhthucgiacong);
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