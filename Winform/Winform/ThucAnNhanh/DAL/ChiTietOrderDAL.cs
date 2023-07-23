using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietOrderDAL
    {
        ChiTietOrderTableAdapter cto = new ChiTietOrderTableAdapter();
        public DataTable GetDataByIDOrder(int id)
        {
            return cto.GetDataByIDOrder(id);
        }
    }
}
