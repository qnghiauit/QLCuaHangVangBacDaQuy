using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DevExpress.XtraEditors;
using DTO;

namespace QuanLiBanVang
{
    public partial class SuaDichVu : DevExpress.XtraEditors.XtraForm
    {
        private BUL_DichVu _bulDichVu;
        private DICHVU _dichvu;
        public SuaDichVu(int id)
        {
            InitializeComponent();
            _bulDichVu = new BUL_DichVu();
            _dichvu = _bulDichVu.GetDichvuById(id);
            this.textEditTenDV.Text = _dichvu.TenDV;
            string tiencong = _dichvu.TienCong.ToString();
            this.textEditTienCong.Text = tiencong.Remove(tiencong.IndexOf("."));
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            if (this.textEditTenDV.Text == "")
            {
                MessageBox.Show("Tên dịch vụ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.textEditTienCong.Text == "")
            {
                MessageBox.Show("Tiền công không được để trống!\nNếu tiền công phụ thuộc vào chi tiết gia công thì nhập vào 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _dichvu.TenDV = this.textEditTenDV.Text;
            _dichvu.TienCong = Int32.Parse(this.textEditTienCong.Text);
            _bulDichVu.UpdateDichVu(_dichvu);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}