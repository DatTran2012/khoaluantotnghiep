using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucAnNhanh.ReportExcel
{
    public class ChiTietPhieuNhap
    {
        private string _STT;
        private string _IDPN;
        private string _IDNL;
        private string _TenNL;
        private string _DVT;
        private int _SoLuongNhap;
        private long _GiaNhap;
        private long _ThanhTien;

        public long ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public long GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
        public int SoLuongNhap { get => _SoLuongNhap; set => _SoLuongNhap = value; }
        public string IDNL { get => _IDNL; set => _IDNL = value; }
        public string IDPN { get => _IDPN; set => _IDPN = value; }
        public string STT { get => _STT; set => _STT = value; }
        public string TenNL { get => _TenNL; set => _TenNL = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
    }
}
