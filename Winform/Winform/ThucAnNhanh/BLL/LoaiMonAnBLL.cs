using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiMonAnBLL
    {
        LoaiMonAnDAL lma = new LoaiMonAnDAL();
        public DataTable GetData()
        {
            return lma.GetData();
        }
    }
}
