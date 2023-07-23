using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Model
{
    public class HoaDonCTHD
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public int ID { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongTien { get; set; }
        public string ID_NhanVien { get; set; }
        public int ID_KhachHang { get; set; }
        public int ID_BanAn { get; set; }
        public string TinhTrang { get; set; }
        public List<ChiTietHoaDon> ListCTHD { get; set; }
    }
}