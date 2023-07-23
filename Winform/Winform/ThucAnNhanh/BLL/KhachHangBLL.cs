using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL kh = new KhachHangDAL();
        public DataTable TimKHTheoSDT(string sdt)
        {
            return kh.TimKHTheoSDT(sdt);
        }
        public DataTable GetData()
        {
            return kh.GetData();
        }
        public bool InsertKH(string tenkh, string gioitinh, string ngaysinh, string diachi, string sdt, string email, string matkhau)
        {
            return kh.InsertKH(tenkh, gioitinh, ngaysinh, diachi, sdt, email, matkhau);
        }
        public int KTKC(int id)
        {
            return kh.KTKC(id);
        }

        public bool UpdateKH(string tenkh, string gioitinh, string ngaysinh, string diachi, string sdt, string email, int id)
        {
            return kh.UpdateKH(tenkh, gioitinh, ngaysinh, diachi, sdt, email, id);
        }
        public string timTenKH(int id)
        {
            return kh.timTenKH(id);
        }
        public DataTable GetDataTheoIDKH(int id)
        {
            return kh.GetDataTheoIDKH(id);
        }
    }
}
