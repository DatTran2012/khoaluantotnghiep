using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CTHDController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public HttpResponseMessage GetCTHDLists()
        {

            List<ChiTietHoaDon> list = db.ChiTietHoaDons.ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetByMaHD(int id)
        {
            List<ChiTietHoaDon> cthd = db.ChiTietHoaDons.Where(x => x.ID_HoaDon == id).ToList();
            if (cthd != null)
                return Request.CreateResponse(HttpStatusCode.OK, cthd);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPost]
        public HttpResponseMessage InsertCTHD([FromBody] ChiTietHoaDon cthd)
        {
            try
            {
                db.ChiTietHoaDons.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return Request.CreateResponse(HttpStatusCode.Created, cthd);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        public HttpResponseMessage InsertListCTHD([FromBody] List<ChiTietHoaDon> cthds)
        {
            try
            {
                foreach (ChiTietHoaDon ct in cthds)
                {
                    db.ChiTietHoaDons.InsertOnSubmit(ct);
                    db.SubmitChanges();
                }
                return Request.CreateResponse(HttpStatusCode.OK, cthds);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteCTHD([FromBody] ChiTietHoaDon cthd)
        {
            try
            {
                db.ChiTietHoaDons.DeleteOnSubmit(cthd);
                db.SubmitChanges();
                List<ChiTietHoaDon> list = db.ChiTietHoaDons.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
