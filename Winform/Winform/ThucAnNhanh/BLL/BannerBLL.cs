using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BannerBLL
    {
        BannerDAL bn = new BannerDAL();
        public DataTable GetData()
        {
            return bn.GetData();
        }
        public DataTable GetDataTheoID(int id)
        {
            return bn.GetDataTheoID(id);
        }
    }
}
