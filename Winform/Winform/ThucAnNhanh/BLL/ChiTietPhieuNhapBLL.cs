using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL ctpn = new ChiTietPhieuNhapDAL();
        public DataTable GetDataTheoMaPN(int id)
        {
            return ctpn.GetDataTheoMaPN(id);
        }
        public bool InsertCTPN(int idpn, int idnl, int sl, long gianhap, long thanhtien)
        {
            return ctpn.InsertCTPN(idpn, idnl, sl, gianhap, thanhtien);
                }
    }
}
