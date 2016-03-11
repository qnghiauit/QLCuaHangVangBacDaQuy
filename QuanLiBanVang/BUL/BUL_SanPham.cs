using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_SanPham
    {
        private DAL.DAL_SanPham _dalSanPham;
        public BUL_SanPham()
        {
            _dalSanPham = new DAL.DAL_SanPham();
        }   
        public void addNewProduct(DTO.SANPHAM product)
        {
            _dalSanPham.addNewProduct(product);
        }
        
    }
}
