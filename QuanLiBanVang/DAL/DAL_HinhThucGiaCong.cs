using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HinhThucGiaCong
    {
        private DBQLCuaHangVangBacDaQuyEntities _context;

        public DAL_HinhThucGiaCong()
        {
            _context = new DBQLCuaHangVangBacDaQuyEntities();
        }

        public void AddNewHtgc(HINHTHUCGIACONG newHtgc)
        {
            _context.HINHTHUCGIACONGs.Add(newHtgc);
            _context.SaveChanges();
        }

        public List<HINHTHUCGIACONG> GetAllHtgc()
        {
            return _context.HINHTHUCGIACONGs.ToList();
        }

        public HINHTHUCGIACONG GetHtgcById(int id)
        {
            return _context.HINHTHUCGIACONGs.Single(ht => ht.MaHTGC == id);
        }

        public void UpdateHtgc(HINHTHUCGIACONG updateHtgc)
        {
            var currentHtgc = _context.HINHTHUCGIACONGs.Find(updateHtgc.MaHTGC);
            if (currentHtgc != null)
            {
                currentHtgc.TenHTGC = updateHtgc.TenHTGC;
                _context.SaveChanges();
            }
        }

        public void DeleteHtgc(int id)
        {
            _context.HINHTHUCGIACONGs.Remove(GetHtgcById(id));
            _context.SaveChanges();
        }
    }
}
