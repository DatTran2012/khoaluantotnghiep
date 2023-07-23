using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MonAnController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        [HttpGet]
        public HttpResponseMessage GetListMonAn()
        {

            List<MonAn> list = db.MonAns.ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        public MonAn GetMonAn(int id)
        {
            return db.MonAns.FirstOrDefault(x => x.ID == id);
        }

        [HttpPost]
        public HttpResponseMessage CreateMonAn([FromBody] MonAn ma)
        {
            try
            {
                db.MonAns.InsertOnSubmit(ma);
                db.SubmitChanges();
                return Request.CreateResponse(HttpStatusCode.Created, ma);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
