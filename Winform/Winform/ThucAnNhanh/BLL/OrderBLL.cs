using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBLL
    {
        OrderDAL od = new OrderDAL();
        public DataTable GetDataChoXacNhan()
        {
            return od.GetDataChoXacNhan();
        }
        public DataTable GetDataTheoIDOrder(int id)
        {
            return od.GetDataTheoIDOrder(id);
        }
        public bool UpdateTT(string tt, int id)
        {
            return od.UpdateTT(tt, id);
        }
    }
}
