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
        BUL.BUL_NhomNguoiDung _bulGroupUser;
        
        public NhapNhanVien_Form()
        {
            InitializeComponent();
            _staff = new DTO.NHANVIEN();
            _bulStaff = new BUL.BUL_NhanVien();
            _bulPosition = new BUL.BUL_ChucVu();
            _bulGroupUser = new BUL.BUL_NhomNguoiDung();
        }

        private void NhapNhanVien_Form_Load(object sender, EventArgs e)
        {
            List<DTO.CHUCVU> _listPosition = new List<DTO.CHUCVU>();
            List<DTO.NHOMNGUOIDUNG> _listGroupUser = new List<DTO.NHOMNGUOIDUNG>();
            _listPosition = _bulPosition.getAllPosition();
            _listGroupUser = _bulGroupUser.getAllGroupUser();

            foreach (DTO.CHUCVU i in _listPosition)
            {
                ExtendClass.ContainerItem item = new ExtendClass.ContainerItem();
                item.Text = i.TenCV;
                item.Value = i;
                this.cboPosition.Properties.Items.Add(item);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}