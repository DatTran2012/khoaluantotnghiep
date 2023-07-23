using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class NhanVienController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public HttpResponseMessage GetNVList()
        {
            List<NhanVien> list = db.NhanViens.ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetNV(string id)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.ID == id);
            if (nv != null)
                return Request.CreateResponse(HttpStatusCode.OK, nv);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPut]
        public HttpResponseMessage UpdateNV([FromBody] NhanVien nvien)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.ID == nvien.ID);
            if (nv != null)
            {
                nv.MatKhau = nvien.MatKhau;
                db.SubmitChanges();
                return Request.CreateResponse(HttpStatusCode.OK, nv);
            } 
            else 
                return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
