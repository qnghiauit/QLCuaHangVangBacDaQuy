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
    public partial class NhapTho : DevExpress.XtraEditors.XtraForm
    {
        private BUL_Tho _bulTho;
        public NhapTho()
        {
            InitializeComponent();
            _bulTho = new BUL_Tho();}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.textEditTenTho.Text == "")
            {
                MessageBox.Show("Tên thợ gia công không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.textEditSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.textEditDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            THO newTho = new THO
            {
                TenTho = this.textEditTenTho.Text,
                SDT = this.textEditSDT.Text,
                DiaChi = this.textEditDiaChi.Text
            };
            _bulTho.AddNewWorker(newTho);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NhapTho_SizeChanged(object sender, EventArgs e)
        {
            groupControl1.Left = (ClientSize.Width - groupControl1.Width) / 2;
            simpleButtonHuy.Left = groupControl1.Right - simpleButtonOK.Width;
            simpleButtonOK.Left = simpleButtonHuy.Left - simpleButtonOK.Width - 10; 
        }
    }
}