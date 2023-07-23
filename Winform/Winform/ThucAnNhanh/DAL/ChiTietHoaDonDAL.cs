using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        ChiTietHoaDonTableAdapter cthd = new ChiTietHoaDonTableAdapter();
        public DataTable LoadTheoMaHD(int mahd)
        {
            return cthd.GetCTHDTheoMaHD(mahd);
        }
        public bool insertCTHD(int idhd, int idma, int sl, long giaban,long thanhtien)
        {
            if (cthd.Insert(idhd, idma, sl, giaban, thanhtien) > 0)
                return true;
            return false;
        }
    }
}
