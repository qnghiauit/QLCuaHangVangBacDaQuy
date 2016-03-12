using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_NhanVien()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public void addNewStaff(DTO.NHANVIEN staff)
        {
            _context.NHANVIENs.Add(staff);
            _context.SaveChanges();
        }
        
    }
}
