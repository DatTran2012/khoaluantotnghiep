using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class LoaiNhanVienController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public List<LoaiNhanVien> GetLoaiNVLists()
        {
           
            return db.LoaiNhanViens.ToList();
        }

        [HttpGet]
        public LoaiNhanVien GetLoaiNV(int id)
        {
            return db.LoaiNhanViens.FirstOrDefault(x => x.ID == id);
        }

        [Route("post/LoaiNhanVien/{id}/{ten}")]
        [HttpPost]
        public bool PostLoaiNV(int id, string ten)
        {
            try
            {
                LoaiNhanVien loainv = new LoaiNhanVien();
                loainv.ID = id;
                loainv.TenLoaiNV = ten;
                db.LoaiNhanViens.InsertOnSubmit(loainv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateLoaiNV(int id, string name)
        {
            try
            {
                //lấy food tồn tại ra
                LoaiNhanVien food = db.LoaiNhanViens.FirstOrDefault(x => x.ID == id);
                if (food == null) return false;//không tồn tại false
                food.TenLoaiNV = name;
                db.SubmitChanges();//xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }

        [Route("delete/LoaiNhanVien/{id}")]
        [HttpDelete]
        public bool DeleteFood(int id)
        {
            //lấy food tồn tại ra
            LoaiNhanVien nv = db.LoaiNhanViens.FirstOrDefault(x => x.ID == id);
            if (nv == null) return false;
            db.LoaiNhanViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }
    }
}
