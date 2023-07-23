using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomNhanVienDAL
    {
        NhomNhanVienTableAdapter nnv = new NhomNhanVienTableAdapter();
        public int? timLoaiNV(string manv)
        {
            return nnv.timLoaiNV(manv);
        }
        public bool InsertNhomNhanVien(string idnv, int idloai)
        {
            if (nnv.Insert(idnv, idloai) > 0)
                return true;
            return false;
        }
        public bool DeleteNhomNhanVien(string idnv, int idloai)
        {
            if (nnv.Delete(idnv, idloai) > 0)
                return true;
            return false;
        }
        
    }
}
