using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_LoaiSanPham
    {
        private DAL.DAL_LoaiSanPham _dalProductType;
        public BUL_LoaiSanPham()
        {
            _dalProductType = new DAL.DAL_LoaiSanPham();
        }
        public void addNewProductType(DTO.LOAISANPHAM producttype)
        {
            _dalProductType.addNewProductType(producttype);
        }
        public List<DTO.LOAISANPHAM> getListProductType()
        {
            return _dalProductType.getListProductType();
        }
        public DTO.LOAISANPHAM getProductTypeById(int id)
        {
            return _dalProductType.getProductTypeById(id);
        }
        public void updateProductType(DTO.LOAISANPHAM updateProductType)
        {
            _dalProductType.updateProductType(updateProductType);
        }
    }
}
