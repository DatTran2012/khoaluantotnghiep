using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ThanhPhanMonAnBLL
    {
        ThanhPhanMonAnDAL tpma = new ThanhPhanMonAnDAL();
        public DataTable GetDataByIDMonAn(int idma)
        {
            return tpma.GetDataByIDMonAn(idma);
        }
    }
}
