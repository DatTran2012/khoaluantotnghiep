using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   
   public class PhieuNhapBLL
    {
        PhieuNhapDAL pn = new PhieuNhapDAL();
        public DataTable GetDataPN()
        {
            return pn.GetDataPN();
        }
        public bool InsertPN(int id, DateTime ngayNhap, long tongTienNhap, string idnv)
        {
            return pn.InsertPN(id, ngayNhap, tongTienNhap, idnv);
        }
        public int timPNMax()
        {
            return pn.timPNMax();
        }
        public int TinhTongThang(DateTime ngayNhap)
        {
            return (int)pn.TinhTongThang(ngayNhap);
        }
    }
}
