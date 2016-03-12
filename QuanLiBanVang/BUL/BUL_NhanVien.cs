using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_NhanVien
    {
        DAL.DAL_NhanVien _dalStaff;
        public BUL_NhanVien()
        {
            _dalStaff = new DAL.DAL_NhanVien();
        }
        public void addNewStaff(DTO.NHANVIEN staff)
        {
            _dalStaff.addNewStaff(staff);
        }
    }
}
