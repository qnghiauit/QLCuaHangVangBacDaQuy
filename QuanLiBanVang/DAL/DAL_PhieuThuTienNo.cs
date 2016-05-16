using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_PhieuThuTienNo
    {
        DBQLCuaHangVangBacDaQuyEntities databaseContext;

        public DAL_PhieuThuTienNo()
        {
            this.databaseContext = new DBQLCuaHangVangBacDaQuyEntities();
        }

        /// <summary>
        /// insert new dept receipt into database
        /// </summary>
        /// <param name="newDeptReceipt"></param>
        public void add(PHIEUTHUTIENNO newDeptReceipt)
        {
            // make sure the argument is not null
            if (newDeptReceipt == null)
            {
                throw new ArgumentNullException();
            }
            this.databaseContext.PHIEUTHUTIENNOes.Add(newDeptReceipt);
            this.databaseContext.SaveChanges();
        }

    }
}
