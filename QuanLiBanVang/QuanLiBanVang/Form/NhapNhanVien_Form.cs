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

namespace QuanLiBanVang.Form
{
    public partial class NhapNhanVien_Form : DevExpress.XtraEditors.XtraForm
    {
        DTO.NHANVIEN _staff;
        BUL.BUL_NhanVien _bulStaff;
        BUL.BUL_ChucVu _bulPosition;
        
        public NhapNhanVien_Form()
        {
            InitializeComponent();
            _staff = new DTO.NHANVIEN();
            _bulStaff = new BUL.BUL_NhanVien();
        }

    }
}