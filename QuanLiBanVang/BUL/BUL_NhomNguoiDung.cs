using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_NhomNguoiDung
    {
        DAL.DAL_NhomNguoiDung _dalGroupUser;
        public BUL_NhomNguoiDung()
        {
            this._dalGroupUser = new DAL.DAL_NhomNguoiDung();
        }
        public List<DTO.NHOMNGUOIDUNG> getAllGroupUser()
        {
            return _dalGroupUser.getAllGroupUser();
        }
    }
}
