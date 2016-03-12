using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiSanPham
    {
        DTO.DBQLCuaHangVangBacDaQuyEntities _context;
        public DAL_LoaiSanPham()
        {
            _context = new DTO.DBQLCuaHangVangBacDaQuyEntities();
        }
        public void addNewProductType(DTO.LOAISANPHAM productType)
        {
            
            _context.LOAISANPHAMs.Add(productType);
            _context.SaveChanges();
        }
        public List<DTO.LOAISANPHAM> getListProductType()
        {
           
            List<DTO.LOAISANPHAM> _listProductType = new List<DTO.LOAISANPHAM>();
            var query = from productType in _context.LOAISANPHAMs
                        select productType;
            _listProductType = query.ToList();
            return _listProductType;
        }
        public DTO.LOAISANPHAM getProductTypeById(int Id)
        {
            var query = from productType in _context.LOAISANPHAMs
                        where productType.MaLoaiSP == Id
                        select productType;
            return query.Single();
        }
        public void updateProductType(DTO.LOAISANPHAM updateProductType)
        {
            var current = _context.LOAISANPHAMs.Find(updateProductType.MaLoaiSP);
            if (current != null)
            {
                current.MaLoaiSP = updateProductType.MaLoaiSP;
                current.PhanTramLoiNhuan = updateProductType.PhanTramLoiNhuan;
                current.TenLoaiSP = updateProductType.TenLoaiSP;
                _context.SaveChanges();
            }
        }
    }
}
