using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_CTGiaCongSP
    {
        private DBQLCuaHangVangBacDaQuyEntities _context;

        public DAL_CTGiaCongSP()
        {
            _context = new DBQLCuaHangVangBacDaQuyEntities();
        }
        public List<CTGIACONGSP> GetAll()
        {
            List<CTGIACONGSP> listSP = new List<CTGIACONGSP>();
            var query = from sp in _context.CTGIACONGSPs
                        select sp;
            listSP = query.ToList();
            return listSP;
        }

        public void UpdateCTGiaCongSP(int id, string htgc)
        {
            var current = _context.CTGIACONGSPs.Find(id);
            if (current != null)
            {
                current.HinhThucGiaCong = htgc;
                _context.SaveChanges();
            }
        }
    }
}
