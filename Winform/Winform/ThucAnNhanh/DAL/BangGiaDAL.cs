using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class BangGiaDAL
    {
        BangGiaTableAdapter bg = new BangGiaTableAdapter();
        public DataTable GetData()
        {
            return bg.GetDataFULL();
        }
        public bool InsertBangGia(int id, DateTime ngayAD, int giaban, int giakm)
        {
            if (bg.Insert(id, ngayAD, giaban, giakm) > 0)
                return true;
            return false;
        }
        public int? KTKC(int id, string ngayad)
        {
            return bg.KTKC(id, ngayad);
        }
        public bool UpdateBangGia(int giakm, int id, string ngayAD)
        {
            if(bg.UpdateBangGia(giakm, id, ngayAD) > 0)
            {
                return true;
            }
            return false;
        }
       
    }
}
