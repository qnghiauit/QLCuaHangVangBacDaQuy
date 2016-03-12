using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhomNguoiDung
    {
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_NhomNguoiDung()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public List<DTO.NHOMNGUOIDUNG> getAllGroupUser()
        {
            var query = from groupuser in _context.NHOMNGUOIDUNGs
                        select groupuser;
            return query.ToList();
        }
    }
}
