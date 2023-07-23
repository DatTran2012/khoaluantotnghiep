using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        PhieuNhapTableAdapter pn = new PhieuNhapTableAdapter();
        public DataTable GetDataPN()
        {
            return pn.GetDataPN();
        }    
        public bool InsertPN(int id, DateTime ngayNhap, long tongTienNhap, string idnv)
        {
            if (pn.Insert(id, ngayNhap, tongTienNhap, idnv) > 0)
                return true;
            return false;
        }
        public int timPNMax()
        {
            if (pn.TimIDMax() != null)
            {
                return (int)pn.TimIDMax();
            }
            else
                return 0;
        }
        public long TinhTongThang(DateTime ngayNhap)
        {
            if (pn.TinhTongThang(ngayNhap) == null)
                return 0;
            return (long)pn.TinhTongThang(ngayNhap);

        }
    }
}
