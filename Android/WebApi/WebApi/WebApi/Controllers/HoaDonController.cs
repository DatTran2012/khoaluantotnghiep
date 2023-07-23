using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class HoaDonController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public HttpResponseMessage GetListHoaDon()
        {
            List<HoaDon> list = db.HoaDons.ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HoaDon GetHoaDon(int id)
        {
            return db.HoaDons.FirstOrDefault(x => x.ID == id);
        }

        [HttpGet]
        public HoaDon GetListByIDBan(int id)
        {
            return db.HoaDons.FirstOrDefault(i => i.ID_BanAn == id && i.TinhTrang == "Chưa thanh toán");
        }

        //[HttpGet]
        //public HttpResponseMessage GetCountHoaDon()
        //{
        //    List<HoaDon> list = db.HoaDons.ToList();
        //    if (list != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, list.Count);
        //    else return Request.CreateResponse(HttpStatusCode.NotFound);
        //}

        [HttpPost]
        public HttpResponseMessage CreateHoaDon([FromBody] HoaDon hd)
        {
            try
            {
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();// Thêm User đã được truyền ở tham số User u
                return Request.CreateResponse(HttpStatusCode.Created, hd);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateHD([FromBody] HoaDon hd)
        {
            try
            {
                HoaDon hoadon = db.HoaDons.FirstOrDefault(h => h.ID == hd.ID);//không tồn tại false
                hoadon.TinhTrang = "Yêu cầu thanh toán";
                db.SubmitChanges();//xác nhận chỉnh sửa
                List<HoaDon> list = db.HoaDons.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
