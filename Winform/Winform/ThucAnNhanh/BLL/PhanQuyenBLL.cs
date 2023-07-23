using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL pq = new PhanQuyenDAL();
        public int kiemTraQuyen(int maloai, int mamh)
        {
            return pq.kiemTraQuyen(maloai, mamh);
        }
    }
}
