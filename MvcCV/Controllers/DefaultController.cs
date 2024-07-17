using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;

namespace MvcCV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblAbout.ToList();
            return View(degerler);
        }

        public PartialViewResult Social()
        {
            var social = db.TblSocial.ToList();
            return PartialView(social);
        }
        public PartialViewResult deneyim()
        {
            var deneyimler = db.TblExperience.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult educations()
        {
            var educationss = db.TblEducation.ToList();
            return PartialView(educationss);
        }
        public PartialViewResult Skills()
        {
            var skil = db.TblSkills.ToList();
            return PartialView(skil);
        }

        public PartialViewResult Interests()
        {
            var interest = db.TblInterests.ToList();
            return PartialView(interest);
        }

        public PartialViewResult Certificates()
        {
            var certi = db.TblCertificiates.ToList();
            return PartialView(certi);
        }

        [HttpGet]
        public PartialViewResult Contacts()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contacts(TblCommunication t)
        {
            t.tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCommunication.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}