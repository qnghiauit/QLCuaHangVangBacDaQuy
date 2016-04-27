using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;
using System.Data.Entity;
using DTO;

namespace DAL
{
    // Summary:
    // all operations for table NHACUNGCAP
    // 
    //
    //
    public class DAL_NhaCungCap
    {
        private DBQLCuaHangVangBacDaQuyEntities databaseContext = new DBQLCuaHangVangBacDaQuyEntities();

        public DAL_NhaCungCap()
        {
            this.databaseContext = new DBQLCuaHangVangBacDaQuyEntities();
        }
        
        // <summary>
        // returns all records in the NHACUNGCAP table
        //</summary>
        public BindingList<NHACUNGCAP> getAll()
        {
            this.databaseContext.NHACUNGCAPs.Load();
            return this.databaseContext.NHACUNGCAPs.Local.ToBindingList();
        }

        /// <summary>
        /// add new provider into database
        /// </summary>
        /// <param name="newProvider">the new provider to be saved</param>
        public void add(NHACUNGCAP newProvider)
        {
            this.databaseContext.NHACUNGCAPs.Add(newProvider);
            this.databaseContext.SaveChanges();
        }
    }
}
