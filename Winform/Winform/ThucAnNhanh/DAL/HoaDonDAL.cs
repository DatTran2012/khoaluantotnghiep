using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        HoaDonTableAdapter hd = new HoaDonTableAdapter();
        public DataTable GetData()
        {
            return hd.GetData();
        }

        public DataTable GetDataHD()
        {
            return hd.GetDataHD();
        }
        public bool insertHD(int id, DateTime ngaylap, long tongtien, string idnv, int idkh, int soban, string tinhtrang)
        {
            if (hd.Insert(id, ngaylap, tongtien, idnv, idkh, soban, tinhtrang) > 0)
                return true;
            return false;
        }
        public int layMaHDMax()
        {
            if (hd.layMaHDMax() == null)
                return 0;
            else
                return (int)hd.layMaHDMax();
        }

        public int TimMaHD(int idBan)
        {
            if (hd.layMaHDMax() != null)
            {
                return (int)hd.layMaHDMax();
            }
            else
                return 0;
        }
        public DataTable GetDataYCThanhToan()
        {
            return hd.GetDataTTYeuCau();
        }
        public bool UpdateTTTT(int idkh, string tttt, int id)
        {
            if (hd.UpdateTTTT(idkh, tttt, id) > 0)
                return true;
            return false;
        }
        public long TinhDoanhThuHomQua()
        {
            if (hd.TinhDoanhThuHomQua() == null)
                return 0;            
            return (long)hd.TinhDoanhThuHomQua();
        }
        public long TinhDoanhThuHomNay()
        {
            if (hd.TinhDoanhThuHomNay() == null)
                return 0;
            return (long)hd.TinhDoanhThuHomNay();
        }

        public long TinhTongThang(DateTime ngayLap)
        {
            if (hd.TinhTongThang(ngayLap) == null)
                return 0;
            return (long)hd.TinhTongThang(ngayLap);
        
        }

    }
}
