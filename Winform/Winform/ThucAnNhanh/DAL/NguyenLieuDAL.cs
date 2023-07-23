using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguyenLieuDAL
    {
        NguyenLieuTableAdapter nl = new NguyenLieuTableAdapter();
        public DataTable GetData()
        {
            return nl.GetData();
        }
        public bool InsertNL(string tennl, string dvt)
        {
            if (nl.InsertNL(tennl, dvt) > 0)
                return true;
            return false;
        }
        public bool UpdateNL(string tennl, string dvt, int idnl)
        {
            if (nl.UpdateNL(tennl, dvt, idnl) > 0)
                return true;
            return false;
        }
        public bool UpdateSLTon(int slt, int id)
        {
            if (nl.UpdateSLTon(slt, id) > 0)
                return true;
            return false;
        }
        public DataTable GetDataByIDNL(int idnl)
        {
            return nl.GetDataByIDNL(idnl);
        }
    }
}
