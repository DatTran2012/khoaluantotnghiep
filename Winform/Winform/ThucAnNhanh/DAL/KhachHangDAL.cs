using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        KhachHangTableAdapter kh = new KhachHangTableAdapter();
        public DataTable TimKHTheoSDT(string sdt)
        {
            return kh.GetDataBySDT(sdt);
        }
        public DataTable GetData()
        {
            return kh.GetData();
        }    
        public bool InsertKH(string tenkh, string gioitinh, string ngaysinh, string diachi, string sdt, string email, string matkhau)
        {
            if(kh.InsertKH(tenkh, gioitinh,  ngaysinh, diachi, sdt, email, matkhau)> 0)
            {
                return true;
            }
            return false;
        }

        public int KTKC(int id)
        {
            return (int)kh.KTKC(id);
        }
        public bool UpdateKH(string tenkh, string gioitinh, string ngaysinh, string diachi, string sdt, string email, int id)
        {
            if (kh.UpdateKH(tenkh, gioitinh, ngaysinh, diachi, sdt, email, id) > 0)
                return true;
            return false;
        }
        public string timTenKH(int id)
        {
            return kh.layTenKH(id);
        }
        public DataTable GetDataTheoIDKH(int id)
        {
            return kh.GetDataByIDKH(id);
        }
    }
}
