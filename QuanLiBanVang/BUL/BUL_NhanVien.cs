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
        public void updateStaff(DTO.NHANVIEN updateStaff)
        {
            _dalStaff.updateStaff(updateStaff);
        }
        public DTO.NHANVIEN getStaffById(int id)
        {
            return _dalStaff.getStaffById(id);
        }
        public DTO.NHANVIEN getLastStaff()
        {
            return _dalStaff.getLastStaff();
        }
        public void deleteStaff(int id)
        {
            _dalStaff.deleteStaff(id);
        }
        public List<DTO.NHANVIEN> getAllStaff()
        {
            return _dalStaff.getAllStaff();
        }
        public DTO.NHANVIEN getStaffByUsername(string username)
        {
            try
            {
               return _dalStaff.getStaffByUsername(username);
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }
    }
}
