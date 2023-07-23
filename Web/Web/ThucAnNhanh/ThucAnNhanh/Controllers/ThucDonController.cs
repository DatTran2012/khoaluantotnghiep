using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucAnNhanh.Models;

namespace ThucAnNhanh.Controllers
{
    public class ThucDonController : Controller
    {
        // GET: ThucDon
        public ActionResult ThucDonPartial()
        {
            var ds_LoaiMA = new List<LoaiMonAn>();
            using (ThucAnNhanhEntities1 db = new ThucAnNhanhEntities1())
            {
                ds_LoaiMA = db.LoaiMonAns.ToList();
            }
            ViewBag.LoaiMA = ds_LoaiMA;
            return PartialView("_Nav");
        }
     
    }
}