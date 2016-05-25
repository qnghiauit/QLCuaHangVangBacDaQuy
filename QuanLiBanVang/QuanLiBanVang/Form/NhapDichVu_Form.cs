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
    public partial class NhapDichVu : DevExpress.XtraEditors.XtraForm
    {
        private BUL_DichVu _bulDichVu;
        public NhapDichVu()
        {
            InitializeComponent();
            _bulDichVu = new BUL_DichVu();
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
            DICHVU newDichvu = new DICHVU();
            newDichvu.TenDV = this.textEditTenDV.Text;
            newDichvu.TienCong = Int32.Parse(this.textEditTienCong.Text);
            _bulDichVu.AddNewDichVu(newDichvu);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NhapDichVu_SizeChanged(object sender, EventArgs e)
        {
            groupControl1.Left = (ClientSize.Width - groupControl1.Width) / 2;
            simpleButtonHuy.Left = groupControl1.Right - simpleButtonOK.Width;
            simpleButtonOK.Left = simpleButtonHuy.Left - simpleButtonOK.Width - 10; 
        }
    }
}