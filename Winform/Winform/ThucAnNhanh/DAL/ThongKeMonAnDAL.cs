using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeMonAnDAL
    {
        ThongKeMonAnTableAdapter tk = new ThongKeMonAnTableAdapter();
        public DataTable GetData(int id)
        {
            return tk.GetData(id);
        }
    }
}
