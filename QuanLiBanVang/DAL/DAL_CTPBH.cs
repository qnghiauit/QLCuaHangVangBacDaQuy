using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;
using DTO;


namespace DAL
{
    public class DAL_CTPBH
    {
        private DTO.DBQLCuaHangVangBacDaQuyEntities databaseContext;

        public DAL_CTPBH()
        {
            this.databaseContext = new DTO.DBQLCuaHangVangBacDaQuyEntities();
            // load 
            this.databaseContext.CTPBHs.Load();
        }

        // returns number of rows in table
        public int count()
        {
            return this.databaseContext.CTPBHs.Count();
        }

        // add all details of a recepit
        public void insertRange(List<CTPBH> listOfReceiptDetails)
        {
            // make sure that the list is valid
            if (listOfReceiptDetails == null || listOfReceiptDetails.Count == 0)
            {
                throw new ArgumentNullException("[DAL_CTPBH => saveAll method] : null argument");
            }
            else // otherwise add this list into table
            {
                this.databaseContext.CTPBHs.AddRange(listOfReceiptDetails);
                // save change
                this.databaseContext.SaveChanges();
            }
        }


        //<sumamry>
        // from data access layer
        // returns all records in table CTPBH satisfied crterion
        // if cretion is null , returns all content of table
        //</summary>
        public BindingList<CTPBH> toBindingList(PHIEUBANHANG creterion)
        {
            BindingList<CTPBH> returnBindingList;
            if (creterion != null)
            {
                var query = from details in this.databaseContext.CTPBHs
                            where details.SoPhieuBH == creterion.SoPhieuBH
                            select details;
                returnBindingList = new BindingList<CTPBH>(query.ToList());
            }
            else
            {
                returnBindingList = this.databaseContext.CTPBHs.Local.ToBindingList();
            }
            
            //return the list 
            return returnBindingList;
        }
    }
}
