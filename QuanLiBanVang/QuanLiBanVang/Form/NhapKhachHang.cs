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
    public partial class NhapKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private BUL_KhachHang _bulKhachHang;
        public NhapKhachHang()
        {
            InitializeComponent();
            _bulKhachHang = new BUL_KhachHang();
        }

        private void simpleButtonOk_Click(object sender, EventArgs e)
        {
            if (this.textEditTenKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            KHACHHANG khachhang = new KHACHHANG
            {
                TenKH = this.textEditTenKH.Text,
                DiaChi = this.textEditDiaChi.Text,
                SDT = this.textEditSDT.Text
            };
            _bulKhachHang.AddNewClient(khachhang);
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