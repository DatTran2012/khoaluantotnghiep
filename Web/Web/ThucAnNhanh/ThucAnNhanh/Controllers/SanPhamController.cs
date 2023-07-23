using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucAnNhanh.Models;

namespace ThucAnNhanh.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        ThucAnNhanhEntities1 db = new ThucAnNhanhEntities1();
        public ActionResult SanPhamNoiBat()
        {
            var lst_SP = db.MonAns.Where(s=> s.GiaKhuyenMai == s.GiaBan).Take(5).ToList();
            return PartialView("SanPhamNoiBat", lst_SP);
        }
        //[HttpPost]
        public ActionResult SapXepMAPartial(int id,int sort)
        {
            var ma = (from s in db.MonAns where s.LoaiMonAn.ID == id orderby s.GiaKhuyenMai ascending select s).ToList();
            var count = db.MonAns.Where(s => s.LoaiMonAn.ID == id).Count().ToString();
            var countTong = db.MonAns.Count().ToString();
            ViewBag.loai = count;
            ViewBag.tong = countTong;
            ViewBag.id = id;
            ViewBag.sort = sort;
            switch (sort)
            {
                case 1:
                    ma = ma.Where(s => s.ID_LoaiMA == id).ToList();
                    break;
                case 2:
                    ma = ma.OrderByDescending(s => s.GiaKhuyenMai).Where(s => s.ID_LoaiMA == id).ToList();
                    break;
                case 3:
                    ma = ma.OrderBy(s => s.GiaKhuyenMai).Where(s => s.ID_LoaiMA == id).ToList();

                    break;
                default:
                    break;
            }
            return PartialView(ma);
        }
        public ActionResult MonAnTheoLoai(int id)
        {
            var ma = (from s in db.MonAns where s.LoaiMonAn.ID == id orderby s.GiaKhuyenMai descending select s).ToList();
            var count = db.MonAns.Where(s => s.LoaiMonAn.ID == id).Count().ToString();
            var countTong = db.MonAns.Count().ToString();
          
            ViewBag.loai = count;
            ViewBag.tong = countTong;
            ViewBag.id = id;
            if (ma == null)
            {
                return HttpNotFound();
            }
            return View(ma);
        }
        public ActionResult ChiTienMA(int id)
        {
            
            var ma = db.MonAns.Where(s => s.ID == id).Single();
            //var thanhphan_list = (from s in db.NguyenLieux where s.ThanhPhanMonAns.Where(s=> s.ID_MonAn == id) == id select s.TenNguyenLieu).ToList();
            //ViewBag.tpma = tpma;
            if (ma == null)
            {
                return HttpNotFound();
            }
            return View(ma);
        }

    }
}