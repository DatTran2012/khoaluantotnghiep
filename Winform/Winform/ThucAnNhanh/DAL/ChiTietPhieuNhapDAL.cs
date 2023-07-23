using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        ChiTietPhieuNhapTableAdapter ctpn = new ChiTietPhieuNhapTableAdapter();
        public DataTable GetDataTheoMaPN(int id)
        {
            return ctpn.GetDataTheoMaPN(id);
        }
        public bool InsertCTPN(int idpn, int idnl, int sl, long gianhap, long thanhtien)
        {
            if (ctpn.Insert(idpn, idnl, sl, gianhap, thanhtien) > 0)
                return true;
            return false;
        }
    }
}
