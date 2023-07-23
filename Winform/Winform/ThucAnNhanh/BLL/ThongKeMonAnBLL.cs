using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeMonAnBLL
    {
        ThongKeMonAnDAL tk = new ThongKeMonAnDAL();
        public DataTable GetData(int id)
        {
            return tk.GetData(id);
        }
    }
}
