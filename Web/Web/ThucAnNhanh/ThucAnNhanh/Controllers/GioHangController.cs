using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using ThucAnNhanh.Models;

namespace ThucAnNhanh.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        ThucAnNhanhEntities1 db = new ThucAnNhanhEntities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return PartialView();
        }
        //Tính tổng số lượng
        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHangModel> lst = Session["giohang"] as List<GioHangModel>;
            if (lst != null)
            {
                tsl = lst.Sum(sp => sp.soluong);
            }
            return tsl;
        }

        //Tính tổng tiền
        private double TongThanhTien()
        {
            double ttt = 0;
            List<GioHangModel> lst = Session["giohang"] as List<GioHangModel>;
            if (lst != null)
            {
                ttt += lst.Sum(sp => sp.thanhtien);
            }
            return ttt;
        }
        //Lấy giỏ hàng
        public List<GioHangModel> laygiohang()
        {
            List<GioHangModel> lst = Session["giohang"] as List<GioHangModel>;
            if (lst == null)
            {
                lst = new List<GioHangModel>();
                Session["giohang"] = lst;
            }
            return lst;
        }

        //Thêm giỏ hàng
        public JsonResult ThemGioHang(int id, int sl)
        {
            List<GioHangModel> lst = laygiohang();
            GioHangModel sanpham = lst.Find(sp => sp.id == id);
            if (sanpham == null)
            {
                sanpham = new GioHangModel(id);
                sanpham.soluong = sl;
                lst.Add(sanpham);
                //return Redirect(strURL);
                //return RedirectToAction("HienThiGioHang", "GioHang");
                //return RedirectToAction("MonAnTheoLoai", "SanPham", new { id = sanpham.id_loaimon });
                //return RedirectToAction("ThanhToan", "GioHang");
                return Json(new
                {
                    kq = true,
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                sanpham.soluong++;
                //return Redirect(strURL);
                //return RedirectToAction("HienThiGioHang", "GioHang");
                //return RedirectToAction("MonAnTheoLoai", "SanPham", new { id = sanpham.id_loaimon });
                //return RedirectToAction("ThanhToan", "GioHang");
                return Json(new
                {
                    kq = true,
                }, JsonRequestBehavior.AllowGet);

            }
        }
        [HttpPost]
        public ActionResult ThemGioHangTT(int id, FormCollection f)
        {
            List<GioHangModel> lst = laygiohang();
            GioHangModel sanpham = lst.Find(sp => sp.id == id);
            if (sanpham == null)
            {
                sanpham = new GioHangModel(id);
                sanpham.soluong = Convert.ToInt32(f["txtsl"]);
                lst.Add(sanpham);
                return RedirectToAction("ThanhToan", "GioHang");

            }
            else
            {
                sanpham.soluong++;
                return RedirectToAction("ThanhToan", "GioHang");
            }
        }

        public JsonResult ThemGioHangMA(int id)
        {
            List<GioHangModel> lst = laygiohang();

            GioHangModel sanpham = lst.Find(sp => sp.id == id);
            if (sanpham == null)
            {
                sanpham = new GioHangModel(id);
                lst.Add(sanpham);
                return Json(new
                {
                    kq = true,
                }, JsonRequestBehavior.AllowGet);
                //return Redirect(strURL);
                //return RedirectToAction("MonAnTheoLoai", "SanPham", new { id = sanpham.id_loaimon });
                //return RedirectToAction("ThanhToan", "GioHang");
            }
            else
            {
                sanpham.soluong++;
                return Json(new
                {
                    kq = true,
                }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("ThanhToan", "GioHang");
                //return Redirect(strURL);
                //return RedirectToAction("MonAnTheoLoai", "SanPham", new { id = sanpham.id_loaimon });
            }
        }

        //Hiển thị giỏ hàng
        public ActionResult HienThiGioHang()
        {
            if (Session["giohang"] == null)
            {
                return RedirectToAction("Index", "TrangChu");
            }
            //List<GioHangModel> lst = laygiohang();

            //ViewBag.TongSoLuong = TongSoLuong();
            //ViewBag.TongThanhTien = TongThanhTien();

            return View(/*lst*/);
        }
        [HttpPost]
        public ActionResult updateGH(FormCollection f)
        {
            string[] sl = f.GetValues("txtSoluong");
            List<GioHangModel> lst = laygiohang();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].soluong = Convert.ToInt32(sl[i]);
                Session["gioHang"] = lst;
            }
            return RedirectToAction("HienThiGioHang", "GioHang");
        }
        public JsonResult XoaGioHang(int id)
        {
            // Lay gio hang
            List<GioHangModel> lst = laygiohang();
            //Kiem tra xem sach can xoa co trong gio hang khong?
            GioHangModel sp = lst.Single(s => s.id == id);
            // neu co  thi tien hanh xoa
            if (sp != null)
            {
                lst.RemoveAll(s => s.id == id);
                //return RedirectToAction("HienThiGioHang", "GioHang");
                return Json(new
                {
                    kq = true,
                }, JsonRequestBehavior.AllowGet);
            }
            if (lst.Count == 0)
            {
                //return RedirectToAction("Index", "TrangChu");
                return Json(new
                {
                    kq = false,
                }, JsonRequestBehavior.AllowGet);
            }
            //return RedirectToAction("Index", "TrangChu");
            return Json(new
            {
                kq = false,
            }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult xoaALL()
        {
            List<GioHangModel> lst = laygiohang();
            if (lst.Count != 0)
            {
                lst.Clear();

                return RedirectToAction("HienThiGioHang", "GioHang");
            }

            if (lst.Count == 0)
            {
                return RedirectToAction("Index", "TrangChu");
            }
            return RedirectToAction("Index", "TrangChu");
        }
        [HttpGet]
        public ActionResult ThanhToan()
        {
            //if (Session["taikhoan"] == null)
            //{
            //    return RedirectToAction("DangNhap", "User");
            //}
            //if (session["giohang"] == null)
            //{

            //    return redirecttoaction("index", "trangchu");
            //}
            List<GioHangModel> lst = laygiohang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();


            return View(lst);
        }

        [HttpPost]
        public ActionResult ThanhToan(FormCollection f)
        {
            List<GioHangModel> lstGioHang = laygiohang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            try
            {
                KhachHang kh = (KhachHang)Session["taikhoan"];
                if (kh == null)
                {
                    Order order = new Order();
                    order.ID_KhachHang = 0;
                    order.TenKH = f["txttenKH"].ToString();
                    order.DiaChi = f["txtDiaChi"].ToString();
                    order.SDT = f["txtSDT"].ToString();
                    order.Email = f["txtEmail"].ToString();
                    order.GhiChu = f["txtGhiChu"].ToString();
                    order.TongTien = Convert.ToInt32(TongThanhTien());
                    order.TinhTrang = "Chờ xác nhận";
                    db.Orders.Add(order);
                    db.SaveChanges();
                    foreach (GioHangModel item in lstGioHang)
                    {
                        ChiTietOrder ct_order = new ChiTietOrder();
                        ct_order.ID_Order = order.ID;
                        ct_order.ID_MonAn = item.id;
                        ct_order.SoLuong = item.soluong;
                        ct_order.GiaBan = Convert.ToInt32(item.giaban);
                        ct_order.ThanhTien = Convert.ToInt32(item.thanhtien);
                        ct_order.TinhTrang = "Chờ xác nhận";
                        db.ChiTietOrders.Add(ct_order);
                        db.SaveChanges();
                    }
                    //Send mail
                    MailModel mailSubmit = new MailModel();
                    string html = ConvertViewToString("MailTemplate");
                    MailMessage mail = new MailMessage();
                    mail.To.Add(order.Email);
                    mail.From = new MailAddress(order.Email);
                    mail.Subject = "AFAST Có mặt khi bạn đói";
                    mail.Body = html;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("hmchoangcuong236@gmail.com", "Kioliki24"); // Enter seders User name and password       
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                else
                {
                    Order order = new Order();
                    order.ID_KhachHang = kh.ID;
                    order.GhiChu = f["txtGhiChu"].ToString();
                    //order.Email = kh.Email;
                    order.TongTien = Convert.ToInt32(TongThanhTien());
                    order.TinhTrang = "Chờ xác nhận";
                    db.Orders.Add(order);
                    db.SaveChanges();
                    foreach (GioHangModel item in lstGioHang)
                    {
                        ChiTietOrder ct_order = new ChiTietOrder();
                        ct_order.ID_Order = order.ID;
                        ct_order.ID_MonAn = item.id;
                        ct_order.SoLuong = item.soluong;
                        ct_order.GiaBan = Convert.ToInt32(item.giaban);
                        ct_order.ThanhTien = Convert.ToInt32(item.thanhtien);
                        ct_order.TinhTrang = "Chờ xác nhận";
                        db.ChiTietOrders.Add(ct_order);
                        db.SaveChanges();
                    }
                    //Send mail
                    MailModel mailSubmit = new MailModel();
                    string html = ConvertViewToString("MailTemplate");
                    MailMessage mail = new MailMessage();
                    mail.To.Add(kh.Email);
                    mail.From = new MailAddress(kh.Email);
                    mail.Subject = "AFAST Có mặt khi bạn đói";
                    mail.Body = html;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("hmchoangcuong236@gmail.com", "Kioliki24"); // Enter seders User name and password       
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                Session["giohang"] = null;
                return RedirectToAction("ThanhToanPartial", "GioHang");
            }
            catch (Exception)
            {
                ViewBag.loi = "Vui lòng điền đầy đủ thông tin";
                return RedirectToAction("ThanhToan", "GioHang");
            }
        }
        public ActionResult ThanhToanPartial()
        {
            return View();
        }
        public ActionResult GHPartial()
        {
            if (Session["giohang"] == null)
            {
                return RedirectToAction("Index", "TrangChu");
            }
            List<GioHangModel> lst = laygiohang();

            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return PartialView(lst);
        }
        public ActionResult MailTemplate()
        {
            return View();
        }
        private string ConvertViewToString(string viewName)
        {

            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult vResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext vContext = new ViewContext(this.ControllerContext, vResult.View, ViewData, new TempDataDictionary(), writer);
                vResult.View.Render(vContext, writer);
                return writer.ToString();
            }
        }
    }


}