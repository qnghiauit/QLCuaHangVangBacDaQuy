using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_CTPDV
    {
        private DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_CTPDV()
        {
            _context = new DBQLCuaHangVangBacDaQuyEntities();
        }
        public void AddNewCTPDV(CTPDV ctpdv)
        {
            _context.CTPDVs.Add(ctpdv);
            _context.SaveChanges();
        }
        public List<CTPDV> GetAllCTPDV()
        {
            return _context.CTPDVs.ToList();
        }
        public CTPDV GetCTPDVById(int id)
        {
            return _context.CTPDVs.Single(ctpdv => ctpdv.Id == id);
        }
        public List<CTPDV> GetAllCTPDVBySoPhieuDV(int sophieudv)
        {
            var query = from ctpdv in _context.CTPDVs
                        where ctpdv.SoPhieuDV == sophieudv
                        select ctpdv;
            return query.ToList();
        }
        public void UpdateCTPDV(CTPDV ctpdv)
        {
            var current = _context.CTPDVs.Find(ctpdv.Id);
            if(current != null)
            {
                current.MaLoaiSP = ctpdv.MaLoaiSP;
                current.MaDV = ctpdv.MaDV;
                current.SoLuong = ctpdv.SoLuong;
                current.TienCong = ctpdv.TienCong;
                current.ThanhTien = ctpdv.ThanhTien;
                _context.SaveChanges();
            }
        }
        public void DeleteCTPDVById(int id)
        {
            _context.CTPDVs.Remove(GetCTPDVById(id));
            _context.SaveChanges();
        }

        public List<CTPDV> GetCTPDVGiaCong()
        {
            var query = from ctpdv in _context.CTPDVs
                        where ctpdv.MaDV == 2select ctpdv;
            return query.ToList();
        }
    }
}
