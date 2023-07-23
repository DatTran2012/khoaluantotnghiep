using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ThucAnNhanh.Models;


namespace ThucAnNhanh.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult LienHe()
        {
            return View();
        }
        //public ActionResult SendEmail()
        //{
        //    return View();
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost]
        public ViewResult Index(MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(_objModelMail.To);
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                string Body = _objModelMail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("hmchoangcuong236@gmail.com", "Kioliki24"); // Enter seders User name and password       
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index", _objModelMail);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult LienHeSubmit(FormCollection f)
        {
           if(ModelState.IsValid)
            {
                string email = f["email"].ToString();
                MailModel mailSubmit = new MailModel();
                string html = ConvertViewToString("MailTemplate");
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
              
            }
            return RedirectToAction("Index", "TrangChu");
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
        public ActionResult MailTemplate()
        {
            return View();
        }
    }
}