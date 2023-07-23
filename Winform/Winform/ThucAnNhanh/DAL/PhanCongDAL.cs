using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanCongDAL
    {
        PhanCongTableAdapter pc = new PhanCongTableAdapter();
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
            return pc.GetDataByNgayLam(ngaylam.ToShortDateString());
        }
        public DataTable GetDataTheoCa(int calam, DateTime ngaylam)
        {
            return pc.GetDataByCaLam(calam, ngaylam.ToShortDateString());
        }
        public int KTKC(string idnv, DateTime ngayLam, int calam)
        {
            return (int)pc.KTKC(idnv, ngayLam.ToShortDateString(), calam);
        }



        /// <summary>
        /// /
        /// </summary>
        /// <param name="calam"></param>
        /// <param name="ngaylam"></param>
        /// <returns></returns>
        public DataTable GetDataChuaCoCaLam(int calam, DateTime ngaylam)
        {
            return pc.GetDataByChuaCoCaLam(calam, ngaylam.ToShortDateString());
        }
       
        ///////
        //


        public bool insertPhanCong(string idnv, int calam, DateTime ngayLam, string diemDanh)
        {
            if (pc.Insert(idnv, calam, ngayLam, diemDanh) > 0)
                return true;
            return false;
        }
        public bool updateDiemDanh(string diemdanh, string idnv, int calam, string ngayLam)
        {
            if (pc.UpdateDiemDanh(diemdanh, idnv, calam, ngayLam) > 0)
                return true;
            return false;
        }
        public int kiemTraDiemDanh(string idnv, int calam, string ngaylam)
        {
            return (int)pc.KiemTraDiemDanh(idnv, calam, ngaylam);
        }
        public bool deletePhanCong(string idnv, int calam, string ngaylam)
        {
            if (pc.DeletePhanCong(idnv, calam, ngaylam) > 0)
                return true;
            return false;
        }
    }
}
