using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BangGiaBLL
    {
        BangGiaDAL bg = new BangGiaDAL();
        public DataTable GetData()
        {
            return bg.GetData();
        }
        public bool InsertBG(int id, DateTime ngayAD, int giaban, int giakm)
        {
            return bg.InsertBangGia(id, ngayAD, giaban, giakm);
        }
        public int? KTKC(int id, string ngayad)
        {
            return bg.KTKC(id, ngayad);
        }
        public bool UpdateBangGia(int giakm, int id, string ngayAD)
        {
            return bg.UpdateBangGia(giakm, id, ngayAD);
        }
       
    }
}
