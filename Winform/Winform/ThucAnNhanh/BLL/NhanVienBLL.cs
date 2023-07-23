using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv = new NhanVienDAL();
        public DataTable GetData()
        {
            return nv.GetData();
        }
       
        public string layTenNV(string manv)
        {
            return nv.layTenNV(manv);
        }
        public DataTable GetNhanVienTheoMaNV(string manv)
        {
            return nv.GetNhanVienTheoMaNV(manv);
        }
        public DataTable GetNhanVienTheoMaLoai(int idLoai)
        {
            return nv.GetNhanVienTheoMaLoai(idLoai);
        }
        public bool InsertNV(string id, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmt, string anh, DateTime ngayvl, string matkhau, int tinhtrang)
        {
            return nv.InsertNV(id, tennv, ngaysinh, gioitinh, diachi, sdt, cmt, anh, ngayvl, matkhau, tinhtrang);
        }
        
        public int? ktkc(string manv)
        {
            return nv.ktKhoaChinh(manv);
        }
       
        public bool UpdateNV(string tennv, string ngaysinh, string gioitinh, string diachi, string sdt, string cmt, string anh, string ngayvl, int trangthai, string id)
        {
            return nv.UpdateNV(tennv, ngaysinh, gioitinh, diachi, sdt, cmt, anh, ngayvl, trangthai, id);
        }
        public bool UpdateMK(string pass, string idnv)
        {
            return nv.UpdateMK(pass, idnv);
        }
    }
}
