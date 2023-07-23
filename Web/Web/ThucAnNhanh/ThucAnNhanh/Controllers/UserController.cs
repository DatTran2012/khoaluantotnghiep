using reCAPTCHA.MVC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ThucAnNhanh.Models;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;

namespace ThucAnNhanh.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        ThucAnNhanhEntities1 db = new ThucAnNhanhEntities1();
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        [CaptchaValidator(ErrorMessage = "Vui lòng xác thực")]
        public ActionResult DangNhap(FormCollection f, bool captchaValid)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                string email = f["txtEmail"].ToString();
                string matkhau = GetMD5(f["txtMatKhau"].ToString());

                //if (db.KhachHangs.Count(s => s.MatKhau == matkhau && s.Email == email) > 0)
                //{
                KhachHang kh = db.KhachHangs.SingleOrDefault(s => s.Email == email && s.MatKhau == matkhau);
                if (kh == null)//Khoong thanh cong
                {
                    ViewBag.thongbao = "Vui lòng kiểm tra lại email hoặc mật khẩu";
                    return View();
                }
                Session["taikhoan"] = kh;
                if (Session["giohang"] == null)
                {
                    return RedirectToAction("Index", "TrangChu");
                }
                return RedirectToAction("ThanhToan", "GioHang");
            }
            return View();
            //}
            //else
            //{
            //ViewBag.thongbao = "Tài khoản không hợp lệ!";
            //}
            //return RedirectToAction("DangNhap", "User");
            //}
            //catch (Exception)
            //{
            //    return RedirectToAction("Index", "TrangChu");
            //}
        }
        [HttpPost]
        [CaptchaValidator(ErrorMessage = "Vui lòng xác thực")]
        public ActionResult DangKi(KhachHang kh, bool captchaValid)
        {
            if (ModelState.IsValid)
            {
                //KhachHang kh = new KhachHang();
                var countKH = db.KhachHangs.Count(s => s.Email == kh.Email);
                var countSDT = db.KhachHangs.Count(s => s.SDT == kh.SDT);
                var matkhau = GetMD5(kh.MatKhau);
                if (countKH != 0 || countSDT != 0 )
                {
                    ViewBag.thongbao1 = "Email và số điện thoại đã được đăng kí";
                    return View();
                }
                else
                {
                    //kh.Email = f["txtEmail"].ToString();
                    //kh.MatKhau = f["txtMatKhau"].ToString();
                    ////kh.GioiTinh = f["txtGioiTinh"].ToString();
                    //kh.TenKH = f["txtTenKH"].ToString();
                    //kh.DiaChi = f["txtDiaChi"].ToString();
                    //kh.SDT = f["txtSDT"].ToString();
                    //kh.NgaySinh = DateTime.Parse(f["txtNgaySinh"].ToString());
                    //kh.DiemTichLuy = 20;
                    kh.MatKhau = matkhau;
                    kh.DiemTichLuy = 20;
                   
                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                    ViewBag.thongbao1 = "Đăng ký thành công";
                    return RedirectToAction("DangNhap", "User");
                }
            }
            else
            {
                return View();
            }

        }

        public ActionResult DangKi()
        {
            return View();
        }
        public ActionResult DangXuat()
        {
            Session["taikhoan"] = null;
            return RedirectToAction("Index", "TrangChu");
        }
        public ActionResult DangXuatPartial()
        {
            return PartialView();
        }

        public ActionResult DangKiPartial()
        {
            return PartialView();
        }
        public ActionResult DangNhapPartial()
        {
            return PartialView();
        }
        public ActionResult ThongTinKhachHang()
        {
            return View();
        }
        public ActionResult ForgetPassWord()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassWord(FormCollection f)
        {
            var email = f["txtemail"];
            var user = db.KhachHangs.Where(s => s.Email == email).FirstOrDefault();
            if (user == null)
            {
                ViewBag.loi = "Email chưa đăng kí";
                return View();
            }
            else
            {
                Random rd = new Random();
                TimeSpan interval = new TimeSpan(rd.Next(0,100));
                var Token = GetMD5(user.ID.ToString()) + "0000" + interval;
                ViewBag.Token = Token;
                user.Token = Token;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
              

                //Send mail
                MailModel mailSubmit = new MailModel();
                string html = ConvertViewToString("MailXacNhan", user);
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress(email);
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
                ViewBag.loi = "Đã gửi mail";
            }
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
        private string ConvertViewToString(string viewName,KhachHang model)
        {
            ViewBag.model = model;
            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult vResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext vContext = new ViewContext(this.ControllerContext, vResult.View, ViewData, new TempDataDictionary(), writer);
                vResult.View.Render(vContext, writer);
                return writer.ToString();
            }
        }
        public ActionResult MailXacNhan()
        {    
            return PartialView();
        }
        public static string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }
        public ActionResult SubmitPass(string Token)
        {
            var user = db.KhachHangs.Where(s => s.Token == Token).FirstOrDefault();

            return View(user);
        }
        [HttpPost]
        public ActionResult SubmitPass(FormCollection f)
        {
            var Token = f["txttoken"];
            var user = db.KhachHangs.Where(s => s.Token == Token).FirstOrDefault();
            user.MatKhau = GetMD5(f["txtmatkhau"]);
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("DangNhap","User") ;
        }
    }
}