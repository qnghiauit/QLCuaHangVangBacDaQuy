using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class BUL_CTGiaCongSP
    {
        private DAL_CTGiaCongSP _dalCtGiaCongSp;

        public BUL_CTGiaCongSP()
        {
            _dalCtGiaCongSp = new DAL_CTGiaCongSP();
        }
        public List<CTGIACONGSP> GetAll()
        {
            return _dalCtGiaCongSp.GetAll();
        }

        public void UpdateCTGiaCongSP(int id, string htgc)
        {
            _dalCtGiaCongSp.UpdateCTGiaCongSP(id,htgc);
        }
    }
}
