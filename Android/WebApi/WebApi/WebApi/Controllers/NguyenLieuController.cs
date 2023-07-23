using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class NguyenLieuController : ApiController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        [HttpGet]
        public HttpResponseMessage GetNguyenLieuByMaMA(int id)
        {

            List<ThanhPhanMonAn> list = db.ThanhPhanMonAns.Where(x => x.ID_MonAn == id).ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPut]
        public HttpResponseMessage UpdateSLTNGuyenLieu([FromBody] List<ChiTietHoaDon> cthds)
        {
            try
            {
                foreach (ChiTietHoaDon ct in cthds)
                {
                    List<ThanhPhanMonAn> list = db.ThanhPhanMonAns.Where(x => x.ID_MonAn == ct.ID_MonAn).ToList();
                    foreach (ThanhPhanMonAn tp in list)
                    {
                        NguyenLieu nguyenLieu = db.NguyenLieus.FirstOrDefault(n => n.ID == tp.ID_NguyenLieu);
                        if (nguyenLieu.SoLuongTon > 0)
                        {
                            nguyenLieu.SoLuongTon = nguyenLieu.SoLuongTon - (tp.DinhLuong * ct.SoLuong);
                            db.SubmitChanges();
                        } else
                        {

                        }
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, cthds);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
