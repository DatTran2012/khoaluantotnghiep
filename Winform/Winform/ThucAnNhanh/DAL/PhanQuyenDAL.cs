using DAL.DBThucAnNhanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        PhanQuyenTableAdapter pq = new PhanQuyenTableAdapter();
        public int kiemTraQuyen(int maloai, int mamh)
        {
            return (int)pq.KiemTraQuyen(maloai, mamh);
        }
    }
}
