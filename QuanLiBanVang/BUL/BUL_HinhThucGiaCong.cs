using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class BUL_HinhThucGiaCong
    {
        private DAL_HinhThucGiaCong dalHinhThucGiaCong;

        public BUL_HinhThucGiaCong()
        {
            dalHinhThucGiaCong = new DAL_HinhThucGiaCong();
        }
        public void AddNewHtgc(HINHTHUCGIACONG newHtgc)
        {
            dalHinhThucGiaCong.AddNewHtgc(newHtgc);
        }

        public List<HINHTHUCGIACONG> GetAllHtgc()
        {
            return dalHinhThucGiaCong.GetAllHtgc();
        }

        public HINHTHUCGIACONG GetHtgcById(int id)
        {
            return dalHinhThucGiaCong.GetHtgcById(id);
        }

        public void UpdateHtgc(HINHTHUCGIACONG updateHtgc)
        {
            dalHinhThucGiaCong.UpdateHtgc(updateHtgc);
        }

        public void DeleteHtgc(int id)
        {
            dalHinhThucGiaCong.DeleteHtgc(id);
        }
    }
}
