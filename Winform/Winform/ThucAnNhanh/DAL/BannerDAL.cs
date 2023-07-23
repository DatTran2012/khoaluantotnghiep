using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BannerDAL
    {
        BannerTableAdapter bn = new BannerTableAdapter();
        public DataTable GetData()
        {
            return bn.GetData();
        }
        public DataTable GetDataTheoID(int id)
        {
            return bn.GetDataByTheoID(id);
        }
    }
}
