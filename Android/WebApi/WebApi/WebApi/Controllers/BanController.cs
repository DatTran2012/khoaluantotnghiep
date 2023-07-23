using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class BanController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public HttpResponseMessage GetListBan()
        {
            List<BanAn> list = db.BanAns.ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetListBanTrong()
        {
            List<BanAn> list = db.BanAns.Where(t => t.TinhTrang == 0).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public HttpResponseMessage GetListBanCoKhach()
        {
            List<BanAn> list = db.BanAns.Where(t => t.TinhTrang == 1).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public BanAn GetBanAn(int id)
        {
            return db.BanAns.FirstOrDefault(x => x.ID == id);
        }

        [HttpPut]
        public HttpResponseMessage UpdateTTBan([FromBody] BanAn ban)
        {
            try
            {
                BanAn ba = db.BanAns.FirstOrDefault(b => b.ID == ban.ID);
                ba.TinhTrang = ban.TinhTrang;
                db.SubmitChanges();
                return Request.CreateResponse(HttpStatusCode.OK, ba);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
