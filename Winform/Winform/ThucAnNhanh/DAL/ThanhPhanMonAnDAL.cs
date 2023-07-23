using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThanhPhanMonAnDAL
    {
        ThanhPhanMonAnTableAdapter tpma = new ThanhPhanMonAnTableAdapter();
        public DataTable GetDataByIDMonAn(int idma)
        {
            return tpma.GetDataByIDMonAn(idma);
        }
    }
}
