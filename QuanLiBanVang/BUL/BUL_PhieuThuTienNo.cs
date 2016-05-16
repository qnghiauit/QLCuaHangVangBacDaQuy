using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
   public class BUL_PhieuThuTienNo
    {
        private DAL_PhieuThuTienNo dalDeptReceipt;

        public BUL_PhieuThuTienNo()
        {
            this.dalDeptReceipt = new DAL_PhieuThuTienNo();
        }

       /// <summary>
       /// save new PHIEUTHUTIENNO into database. 
        /// Throw NullArgumentException if the newDeptReceipt is null
       /// </summary>
       /// <param name="newDeptReceipt"> the PHIEUTHUTIENNO to be saved</param>
        public void add(PHIEUTHUTIENNO newDeptReceipt)
        {
            this.dalDeptReceipt.add(newDeptReceipt);
        }
    }
}
