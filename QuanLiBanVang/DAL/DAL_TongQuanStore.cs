﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TongQuanStore
    {
        
        
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_TongQuanStore()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public decimal calculateIncomeInDate(DateTime t)
        {
            
            decimal? x =_context.CalculateRevenueInDate(t.Date).Single();
           
            if (x == null)
                return 0;
            else
                return x.Value;
            //return _context.CalculateIncomeInDate(t.Date).Single();
        }
        public decimal calculateCostInDate(DateTime t)
        {
            decimal? x = _context.CalculateFeeInDate(t.Date).Single();
            //int? x = _context.CalculateCostInDate(t.Date).Single();
            if (x == null)
                return 0;
            else
                return x.Value;
            //return _context.CalculateCostInDate(t.Date).Single().Value;
        }
        public DTO.CalculateNumberOfIncomeBill_Result calculateNumberOfIncomeBill(DateTime t)
        {
            return _context.CalculateNumberOfIncomeBill(t.Date).Single();
        }
        public DTO.CalculateNumberOfCostBill_Result calculateNumberOfCostBill(DateTime t)
        {
            return _context.CalculateNumberOfCostBill(t.Date).Single();
        }
        public DTO.CalculateStoreStatus_Result calculateStoreStatus()
        {
            return _context.CalculateStoreStatus().Single();
        }
        

    }
}
