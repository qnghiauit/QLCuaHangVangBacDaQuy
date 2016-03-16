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
    public partial class SuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private BUL_KhachHang _bulKhachHang;
        private KHACHHANG khachhang;
        public SuaKhachHang(int id)
        {
            InitializeComponent();
            _bulKhachHang = new BUL_KhachHang();
            khachhang = _bulKhachHang.GetKhachhangById(id);
            this.textEditTenKH.Text = khachhang.TenKH;
            this.textEditDiaChi.Text = khachhang.DiaChi;
            this.textEditSDT.Text = khachhang.SDT;
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
            khachhang.TenKH = this.textEditTenKH.Text;
            khachhang.DiaChi = this.textEditDiaChi.Text;
            khachhang.SDT = this.textEditSDT.Text;
            _bulKhachHang.UpdateKhachHang(khachhang);
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