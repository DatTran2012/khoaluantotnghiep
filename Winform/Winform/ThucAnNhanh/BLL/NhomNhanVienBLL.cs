using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomNhanVienBLL
    {
        NhomNhanVienDAL nnv = new NhomNhanVienDAL();
        public int timLoaiNV(string manv)
        {
            return (int)(nnv.timLoaiNV(manv));
        }
        public bool InsertNhomNhanVien(string idnv, int idloai)
        {
            return nnv.InsertNhomNhanVien(idnv, idloai);
        }
        public bool DeleteNhomNhanVien(string idnv, int idloai)
        {
            return nnv.DeleteNhomNhanVien(idnv, idloai);
        }
    }
}
