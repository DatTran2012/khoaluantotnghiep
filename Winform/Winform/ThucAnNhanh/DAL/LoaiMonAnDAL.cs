using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiMonAnDAL
    {
        LoaiMonAnTableAdapter lma = new LoaiMonAnTableAdapter();
        public DataTable GetData()
        {
            return lma.GetData();
        }
       
    }
}
