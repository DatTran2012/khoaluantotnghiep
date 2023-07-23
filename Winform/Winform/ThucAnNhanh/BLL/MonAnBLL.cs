using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonAnBLL
    {
        MonAnDAL ma = new MonAnDAL();
        public DataTable GetData()
        {
            return ma.GetData();
        }
        public bool InsertMonAn(int id, string tenMA, string anh, string mota, int tinhtrang, int idloai, int giaban, int giakm)
        {
            return ma.themMonAn(id, tenMA, anh, mota, tinhtrang, idloai, giaban, giakm);
        }
        public DataTable GetMonAnTheoLoai(int maloai)
        {
            return ma.GetMonAnTheoLoai(maloai);
        }
        public bool InsertMA(string tenma, string anh, string mota, int tt, int maloai, long gb, long gkm)
        {
            return ma.InsertMA(tenma, anh, mota, tt, maloai, gb, gkm);
        }
        public int KTKC(int id)
        {
            return ma.KTKC(id);
        }
        public bool UpdateMA(string tenma, string anh, string mota,  int maloai, int id)
        {
            return ma.UpdateMA(tenma, anh, mota,  maloai, id);
        }
    }
}
