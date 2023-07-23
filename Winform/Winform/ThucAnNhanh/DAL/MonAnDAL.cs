using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonAnDAL
    {
        MonAnTableAdapter ma = new MonAnTableAdapter();
        public DataTable GetData()
        {
            return ma.GetData();
        }
        public bool themMonAn(int id, string tenMA, string anh, string mota, int tinhtrang, int idloai, int giaban, int giakm)
        {
            if (ma.Insert(id, tenMA, anh, mota, tinhtrang, idloai, giaban, giakm) > 0)
                return true;
            else
                return false;
        }
        public DataTable GetMonAnTheoLoai(int maloai)
        {
            return ma.GetMonAnTheoMaLoai(maloai);
        }
        public bool InsertMA(string tenma, string anh, string mota, int tt, int maloai, long gb, long gkm)
        {
            if (ma.InsertMA(tenma, anh, mota, tt, maloai, gb, gkm) > 0)
                return true;
            return false;
        }
        public int KTKC(int id)
        {
            return (int)ma.KTKC(id);
        }
        public bool UpdateMA(string tenma, string anh, string mota, int maloai, int id)
        {
            if (ma.UpdateMA(tenma, anh, mota, maloai, id) > 0)
                return true;
            return false;
        }
    }
}
