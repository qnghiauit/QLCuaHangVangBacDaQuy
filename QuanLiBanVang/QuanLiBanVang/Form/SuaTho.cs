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
    public partial class SuaTho : DevExpress.XtraEditors.XtraForm
    {
        private BUL_Tho _bulTho;
        private THO _tho;
        public SuaTho(int id)
        {
            InitializeComponent();
            _bulTho = new BUL_Tho();
            _tho = _bulTho.GetWorkerById(id);
            this.textEditTenTho.Text = _tho.TenTho;
            this.textEditDiaChi.Text = _tho.DiaChi;
            this.textEditSDT.Text = _tho.SDT;
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
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
            _tho.TenTho = this.textEditTenTho.Text;
            _tho.DiaChi = this.textEditDiaChi.Text;
            _tho.SDT = this.textEditSDT.Text;
            _bulTho.UpdateWorker(_tho);
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