using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguyenLieuBLL
    {
        NguyenLieuDAL nl = new NguyenLieuDAL();
        public DataTable GetData()
        {
            return nl.GetData();
        }
        public bool InsertNL(string tennl, string dvt)
        {
            return nl.InsertNL(tennl, dvt);
        }
        public bool UpdateNL(string tennl, string dvt, int idnl)
        {
            return nl.UpdateNL(tennl, dvt, idnl);
        }
        public bool UpdateSLTon(int slt, int id)
        {
            return nl.UpdateSLTon(slt, id);
        }
        public DataTable GetDataByIDNL(int idnl)
        {
            return nl.GetDataByIDNL(idnl);
        }
    }
}
