using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiNhanVienDAL
    {
        LoaiNhanVienTableAdapter lnv = new LoaiNhanVienTableAdapter();

        public DataTable GetData()
        {
            return lnv.GetData();
        }
        public string layTenLoaiNV (int id)
        {
            return lnv.layTenLoaiNV(id);
        }
    }
}
