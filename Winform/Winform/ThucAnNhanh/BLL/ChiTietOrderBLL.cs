using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietOrderBLL
    {
        ChiTietOrderDAL cto = new ChiTietOrderDAL();
        public DataTable GetDataByIDOrder(int id)
        {
            return cto.GetDataByIDOrder(id);
        }
    }
}
