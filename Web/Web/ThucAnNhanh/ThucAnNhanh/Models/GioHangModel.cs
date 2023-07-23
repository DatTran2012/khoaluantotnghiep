using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucAnNhanh.Models
{
    public class GioHangModel
    {
        ThucAnNhanhEntities1 db = new ThucAnNhanhEntities1();
        public int id { get; set; }
        public int? id_loaimon { get; set; }
        public string tenma { get; set; }
        public string anh { get; set; }
        public int soluong { get; set; }
        public double giaban { get; set; }
        public double thanhtien { get { return soluong * giaban; } }

        public GioHangModel(int id)
        {
            this.id = id;
            MonAn ma = db.MonAns.Single(s => s.ID == this.id);
            id_loaimon = ma.ID_LoaiMA;
            tenma = ma.TenMA;
            anh = ma.Anh;
            giaban = double.Parse(ma.GiaBan.ToString());
            soluong = 1;
        }
    }
}