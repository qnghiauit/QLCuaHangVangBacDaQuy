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

        /// <summary>
        /// Checks that if the receipt with id has and dept receipts or not ?
        /// </summary>
        /// <param name="id">id of the receipt to be checked</param>
        /// <returns>true if the are any adept receipts of this receipt</returns>
        public bool hasDebtReceipts(int id)
        {
            return this.dalPhieuBanHang.hasDebtReceipts(id);
        }

        /// <summary>
        /// Find all receipts belongs to frequenter with specifed ID
        /// </summary>
        /// <param name="id">id of frequenter</param>
        /// <returns>list receipts in BindingList</returns>
        public BindingList<PHIEUBANHANG> findReceiptsByFrequenterId(int id)
        {
            return this.dalPhieuBanHang.findReceiptsByFrequenterId(id);
        }

        /// <summary>
        /// Find all dept receipts belongs to receipt with specifed ID
        /// </summary>
        /// <param name="id">id of receipts</param>
        /// <returns>list dept receipts in BindingList</returns>
        public BindingList<PHIEUTHUTIENNO> findDeptReceiptsByReceiptId(int id)
        {
            return this.dalPhieuBanHang.findDeptReceiptsByReceiptId(id);
        }

        /// <summary>
        /// Find the last dept receipt of a recepit.
        /// </summary>
        /// <param name="id"> Id of the receipt</param>
        /// <returns>the last dept receipt of a recepit.</returns>
        public PHIEUTHUTIENNO findTheLastDeiptReceiptFromReceiptId(int id)
        {
            return this.dalPhieuBanHang.findTheLastDeiptReceiptFromReceiptId(id);
        }
    }
}
