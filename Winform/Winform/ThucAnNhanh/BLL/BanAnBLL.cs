using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanAnBLL
    {
        BanAnDAL ba = new BanAnDAL();
        public DataTable GetData()
        {
            return ba.GetData();
        }
        public int demBanTrong()
        {
            return ba.demBanTrong();
        }
        public int demBanCoKhach()
        {
            return ba.demBanCoKhach();
        }
        public bool updateTTBan(int idban)
        {
            return ba.updateTTBan(idban);
        }
    }
}
