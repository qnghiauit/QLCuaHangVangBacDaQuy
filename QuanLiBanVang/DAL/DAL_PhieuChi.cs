using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuChi
    {
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_PhieuChi()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public void addNewPaymentBill(DTO.PHIEUCHI bill)
        {
            _context.PHIEUCHIs.Add(bill);
            _context.SaveChanges();
        }
    }
}
