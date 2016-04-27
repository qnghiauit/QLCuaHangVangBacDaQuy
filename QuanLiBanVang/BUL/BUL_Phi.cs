using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_Phi
    {
        DAL.DAL_Phi _dalPaymentType;
        public BUL_Phi()
        {
            _dalPaymentType = new DAL.DAL_Phi();
        }
        public void addNewPaymentType(DTO.PHI paymenttype)
        {
            _dalPaymentType.addNewPaymentType(paymenttype);
        }
        public List<DTO.PHI> getAllPaymentType()
        {
            return _dalPaymentType.getAllPaymentType();
        }
        public DTO.PHI getPaymentTypeById(int id)
        {
            return _dalPaymentType.getPaymentById(id);
        }
        public DTO.PHI updatePaymentType(DTO.PHI paymenttype)
        {
            return _dalPaymentType.updatePaymentType(paymenttype);
        }
        public void deletePaymentType(int id)
        {
            _dalPaymentType.deletePaymentType(id);
        }
        public DTO.PHI getLastPaymentType()
        {
            return _dalPaymentType.getLastPaymentType();
        }
    }
}
