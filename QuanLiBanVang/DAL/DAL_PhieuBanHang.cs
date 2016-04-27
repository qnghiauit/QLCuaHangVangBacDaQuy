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
    public class DAL_PhieuBanHang
    {
        private DTO.DBQLCuaHangVangBacDaQuyEntities databaseContext;
        // contructor
        public DAL_PhieuBanHang()
        {
            this.databaseContext = new DTO.DBQLCuaHangVangBacDaQuyEntities();
            // load
            this.databaseContext.PHIEUBANHANGs.Load();
        }


        // return number of rows int table PHIEUBANHANG
        public int count()
        {
            var count = this.databaseContext.PHIEUBANHANGs.Count();
            return (int)count;
        }

        //<summary>
        //  Returns the fields "SoPhieu" of the last record of table PHIEUBANHANGs
        //</summary>
        public int numberOfLastRecepit()
        {
            var query = (from phieubanhang in this.databaseContext.PHIEUBANHANGs
                         orderby phieubanhang.SoPhieuBH
                         select phieubanhang.SoPhieuBH).Single();
            return (int)query;

        }

        public void add(DTO.PHIEUBANHANG newReceipt)
        {
            // chu kt thu
            this.databaseContext.PHIEUBANHANGs.Add(newReceipt);
            this.databaseContext.SaveChanges();

        }

        //<summary>
        // returns all records in PHIEUBANHANG table
        //</summary>
        public List<PHIEUBANHANG> getAll()
        {
            // instance a List to make sure that the mothed will not return null
            List<PHIEUBANHANG> listReceitps = new List<PHIEUBANHANG>();
            if (this.databaseContext != null)
            {
                listReceitps.AddRange(databaseContext.PHIEUBANHANGs.ToList());
            }
            return listReceitps;
        }

        //<summary>
        // returns all records converted to Bindlist in PHIEUBANHANG table , 
        // will be the data source for gridview
        //</summary>
        public BindingList<PHIEUBANHANG> toBindingList()
        {
            return this.databaseContext.PHIEUBANHANGs.Local.ToBindingList();
        }

    
    }
}
