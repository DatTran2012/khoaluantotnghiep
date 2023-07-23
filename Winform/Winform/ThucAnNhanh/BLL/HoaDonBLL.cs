using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hd = new HoaDonDAL();
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
            return hd.insertHD(id, ngaylap, tongtien, idnv, idkh, soban, tinhtrang);
        }
        public int layMaHDMax()
        {
            return hd.layMaHDMax();
        }
        public int TimMaHD(int idBan)
        {
            return hd.TimMaHD(idBan);
        }
        public DataTable GetDataYCThanhToan()
        {
            return hd.GetDataYCThanhToan();
        }
        public bool UpdateTTTT(int idkh, string tttt, int id)
        {
            return hd.UpdateTTTT(idkh, tttt, id);
        }
        public long TinhDoanhThuHomQua()
        {
            return hd.TinhDoanhThuHomQua();
        }
        public long TinhDoanhThuHomNay()
        {
            return hd.TinhDoanhThuHomNay();
        }
        public int TinhTongThang(DateTime ngayLap)
        {          
                return (int)hd.TinhTongThang(ngayLap);           
        }
    }
}
