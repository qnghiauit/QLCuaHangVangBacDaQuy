using System;
using System.Windows.Forms;
using BUL;
using DevExpress.XtraEditors;
using DTO;
using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class NhapTho : XtraForm
    {
        private BUL_Tho _bulTho;
        public NhapTho()
        {
            InitializeComponent();
            _bulTho = new BUL_Tho();}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenTho.Text))
            {
                MessageBox.Show(Resources.NhapPhieuGiaCong_TenThoEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEditSDT.Text))
            {
                MessageBox.Show(Resources.NhapKhachHang_SDTEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEditDiaChi.Text))
            {
                MessageBox.Show(Resources.NhapKhachHang_DiaChiEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            THO newTho = new THO
            {
                TenTho = textEditTenTho.Text,
                SDT = textEditSDT.Text,
                DiaChi = textEditDiaChi.Text
            };
            _bulTho.AddNewWorker(newTho);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NhapTho_SizeChanged(object sender, EventArgs e)
        {
            groupControl1.Left = (ClientSize.Width - groupControl1.Width) / 2;
            simpleButtonHuy.Left = groupControl1.Right - simpleButtonOK.Width;
            simpleButtonOK.Left = simpleButtonHuy.Left - simpleButtonOK.Width - 10; 
        }
    }
}