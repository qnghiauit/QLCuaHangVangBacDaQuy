using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_SanPham()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public void addNewProduct(DTO.SANPHAM product)
        {
            _context.SANPHAMs.Add(product);
            _context.SaveChanges();
            
        }
        public List<DTO.SANPHAM> getAllProduct()
        {
            List<DTO.SANPHAM> _listProduct = new List<DTO.SANPHAM>();
            var query = from product in _context.SANPHAMs
                        select product;
            _listProduct = query.ToList();
            return _listProduct;
        }
    }
}
