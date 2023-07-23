using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiNhanVienBLL
    {
        LoaiNhanVienDAL lnv = new LoaiNhanVienDAL();
        public DataTable GetData()
        {
            return lnv.GetData();
        }
        public string layTenLoaiNV(int id)
        {
            return lnv.layTenLoaiNV(id);
        }
    }
}
