using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class PhanCongBLL
    {
        PhanCongDAL pc = new PhanCongDAL();

        public DataTable GetData()
        {
            return pc.GetData();
        }
        public DataTable GetDataPhanCong()
        {
            return pc.GetDataPhanCong();
        }
        public DataTable GetDataTheoNgay(DateTime ngaylam)
        {
            return pc.GetDataTheoNgay(ngaylam);

        }
        public DataTable GetDataTheoCa(int calam, DateTime ngaylam)
        {
            return pc.GetDataTheoCa(calam, ngaylam);
        }
        public int KTKC(string idnv, DateTime ngayLam, int calam)
        {
            return pc.KTKC(idnv, ngayLam, calam);
        }



        public DataTable GetDataChuaCoCaLam(int calam, DateTime ngaylam)
        {
            return pc.GetDataChuaCoCaLam(calam, ngaylam);
        }




        public bool insertPhanCong(string idnv, int calam, DateTime ngayLam, string diemDanh)
        {
            return pc.insertPhanCong(idnv, calam, ngayLam, diemDanh);
        }
        public bool updateDiemDanh(string diemdanh, string idnv, int calam, string ngayLam)
        {
            return pc.updateDiemDanh(diemdanh, idnv, calam, ngayLam);
        }
        public int kiemTraDiemDanh(string idnv, int calam, string ngaylam)
        {
            return pc.kiemTraDiemDanh(idnv, calam, ngaylam);
        }
        public bool deletePhanCong(string idnv, int calam, string ngaylam)
        {
            return pc.deletePhanCong(idnv, calam, ngaylam);
        }
    }
}
