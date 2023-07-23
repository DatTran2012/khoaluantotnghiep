using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL cthd = new ChiTietHoaDonDAL();
        public DataTable LoadTheoMaHD(int mahd)
        {
            return cthd.LoadTheoMaHD(mahd);
        }
        public bool insertCTHD(int idhd, int idma, int sl, long giaban, long thanhtien)
        {
            return cthd.insertCTHD(idhd, idma, sl, giaban, thanhtien);
        }
    }
}
