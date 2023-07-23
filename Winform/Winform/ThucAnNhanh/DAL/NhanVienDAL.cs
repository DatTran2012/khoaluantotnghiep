using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        NhanVienTableAdapter nv = new NhanVienTableAdapter();
        public DataTable GetData()
        {
            return nv.GetData();
        }
      
        public string layTenNV(string manv)
        {
            return nv.LayTenNV(manv);
        }
        public DataTable GetNhanVienTheoMaNV(string manv)
        {
            return nv.GetNhanVienTheoMaNV(manv);
        }
        public DataTable GetNhanVienTheoMaLoai(int idLoai)
        {
            return nv.GetNhanVienTheoMaLoai(idLoai);
        }

        public bool InsertNV(string id, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmt, string anh, DateTime ngayvl, string matkhau, int trangthai)
        {
            if(nv.Insert(id, tennv, ngaysinh,gioitinh,diachi, sdt,cmt,anh, ngayvl, matkhau, trangthai) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateNV(string tennv, string ngaysinh, string gioitinh, string diachi, string sdt, string cmt, string anh, string ngayvl, int trangthai, string id)
        {
            if (nv.UpdateQuery(tennv, ngaysinh,gioitinh,diachi,sdt,cmt,anh,ngayvl, trangthai, id) > 0)
            {
                return true;
            }
            return false;
        }
        
        public int? ktKhoaChinh(string manv)
        {
            try
            {
                return nv.KTKC(manv);
            }
            catch
            {
                return 0;
            }
        }

       public bool UpdateMK(string pass, string idnv)
        {
            if (nv.UpdateMK(pass, idnv) > 0)
                return true;
            return false;
        }
    }
}
