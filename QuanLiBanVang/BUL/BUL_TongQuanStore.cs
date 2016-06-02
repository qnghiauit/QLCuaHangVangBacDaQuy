using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_TongQuanStore
    {
        private DAL.DAL_TongQuanStore _dalTongQuan;
        public BUL_TongQuanStore()
        {
            _dalTongQuan = new DAL.DAL_TongQuanStore();
        }
        public int calculateIncomeInDate(DateTime t)
        {
            return _dalTongQuan.calculateIncomeInDate(t);
        }
        public int calculateCostInDate(DateTime t)
        {
            return _dalTongQuan.calculateCostInDate(t);
        }
        public DTO.CalculateNumberOfIncomeBill_Result calculateNumberOfIncomeBill(DateTime t)
        {
            return _dalTongQuan.calculateNumberOfIncomeBill(t);
        }
        public DTO.CalculateNumberOfCostBill_Result calculateNumberOfCostBill(DateTime t)
        {
            return _dalTongQuan.calculateNumberOfCostBill(t);
        }
        public DTO.CalculateStoreStatus_Result calculateStoreStatus()
        {
            return _dalTongQuan.calculateStoreStatus();
        }
    }
}
