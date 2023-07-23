using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PhanCongController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public HttpResponseMessage GetPhanCongByMaNV(String id)
        {

            List<PhanCong> list = db.PhanCongs.Where(x => x.IDNV == id).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetDaDiemDanh(String id)
        {

            List<PhanCong> list = db.PhanCongs.Where(x => x.IDNV == id && x.DiemDanh == "Đã điểm danh" && x.NgayLam.Month == DateTime.Now.Month).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetVang(String id)
        {

            List<PhanCong> list = db.PhanCongs.Where(x => x.IDNV == id && x.DiemDanh == "Vắng" && x.NgayLam.Month == DateTime.Now.Month).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetTre(String id)
        {

            List<PhanCong> list = db.PhanCongs.Where(x => x.IDNV == id && x.DiemDanh == "Đã điểm danh" && x.NgayLam.Month == DateTime.Now.Month).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetPhanCongByMaNVNgay(String id)
        {

            List<PhanCong> list = db.PhanCongs.Where(x => x.IDNV == id && x.NgayLam == DateTime.Now).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPut]
        public HttpResponseMessage UpdateDiemDanh([FromBody] PhanCong pc)
        {
            try
            {
                PhanCong pcong = db.PhanCongs.FirstOrDefault(p => p.IDNV == pc.IDNV && p.CaLam == pc.CaLam && p.NgayLam == pc.NgayLam);
                pcong.DiemDanh = pc.DiemDanh;
                db.SubmitChanges();
                return Request.CreateResponse(HttpStatusCode.OK, pc);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
