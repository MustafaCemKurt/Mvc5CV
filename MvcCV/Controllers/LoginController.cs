using MvcCV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using System.Web.Security;

namespace MvcCV.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p )

        {
            DbCvEntities db = new DbCvEntities();
            var info = db.TblAdmin.FirstOrDefault(x=>x.kullaniciAdi==p.kullaniciAdi  && x.sifre==p.sifre );
            if (info!=null)
            {
                FormsAuthentication.SetAuthCookie(info.kullaniciAdi, false);
                Session["kullaniciAdi"]=info.kullaniciAdi.ToString();
                return RedirectToAction("Index" , "About");
            }
            else
            {
                return RedirectToAction("Index", " Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}