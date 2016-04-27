using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class BUL_PhieuBanHang
    {
        private DAL_PhieuBanHang dalPhieuBanHang;
        // constructor
        public BUL_PhieuBanHang()
        {
            this.dalPhieuBanHang = new DAL_PhieuBanHang();
        }

        public int count()
        {
            return this.dalPhieuBanHang.count();
        }

        //<summary>
        //  Returns the fields "SoPhieu" of the last record of table PHIEUBANHANGs
        //</summary>
        public int numberOfLastRecept()
        {
            return this.dalPhieuBanHang.numberOfLastRecepit();
        }
        public void add(PHIEUBANHANG newReceipt)
        {
            this.dalPhieuBanHang.add(newReceipt);
        }


        public List<PHIEUBANHANG> getAllReceipts()
        {
            return this.dalPhieuBanHang.getAll();
        }

        //<summary>
        // returns all records converted to Bindlist in PHIEUBANHANG table , 
        // will be the data source for gridview
        //</summary>
        public BindingList<PHIEUBANHANG> toBindingList()
        {
            return this.dalPhieuBanHang.toBindingList();
        }
    }
}
