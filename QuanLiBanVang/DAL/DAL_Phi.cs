using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Phi
    {
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_Phi()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public void addNewPaymentType(DTO.PHI paymenttype)
        {
            _context.PHIs.Add(paymenttype);
            _context.SaveChanges();
        }
        public List<DTO.PHI> getAllPaymentType()
        {
            return _context.PHIs.ToList();
        }
        public DTO.PHI getPaymentById(int id)
        {
            return _context.PHIs.Single(p => p.MaPhi == id);
        }
        public void deletePaymentType(int id)
        {
            var target = _context.PHIs.Find(id);
            _context.PHIs.Remove(target);
            _context.SaveChanges();
        }
        public DTO.PHI updatePaymentType(DTO.PHI updatepaymenttype)
        {
            var current = _context.PHIs.Find(updatepaymenttype.MaPhi);
            if (current != null)
            {
                current.TenPhi = updatepaymenttype.TenPhi;
            }
            return updatepaymenttype;
        }
        public DTO.PHI getLastPaymentType()
        {
            var max = _context.PHIs.Max(p => p.MaPhi);
            return _context.PHIs.Single(p => p.MaPhi == max);
        }
    }
}
