using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class OrderDAL
    {
        OrderTableAdapter od = new OrderTableAdapter();
        public DataTable GetDataChoXacNhan()
        {
            return od.GetDataByChoXacNhan();
        }
        public DataTable GetDataTheoIDOrder(int id)
        {
            return od.GetDataByIDOrder(id);
        }

        public bool UpdateTT(string tt, int id)
        {
            if (od.UpdateTT(tt, id) > 0)
                return true;
            return false;
        }
    }
}
