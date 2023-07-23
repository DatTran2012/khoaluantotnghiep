using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucAnNhanh.Models;

namespace ThucAnNhanh.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        ThucAnNhanhEntities1 db = new ThucAnNhanhEntities1();
        public ActionResult Index()
        {
            var loai_MA = db.LoaiMonAns.ToList();
            var monan = db.MonAns.Take(3).ToList();
            ViewBag.monan = monan;
            return View(loai_MA);
        }

    }
}