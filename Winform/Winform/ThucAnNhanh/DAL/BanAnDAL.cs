using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanAnDAL
    {
        BanAnTableAdapter ba = new BanAnTableAdapter();
        public DataTable GetData()
        {
            return ba.GetData();
        }
        public int demBanTrong()
        {
            return (int)ba.DemBanTrong();
        }
        public int demBanCoKhach()
        {
            return (int)ba.DemBanCoKhach();
        }
        public bool updateTTBan(int idban)
        {
            if (ba.UpdateTTBan(idban) > 0)
                return true;
            return false;
        }
    }
}
