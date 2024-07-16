using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;
namespace MvcCV.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate

        GenericRepository<TblCertificiates> repo= new GenericRepository<TblCertificiates>();
        public ActionResult Index()
        {
            var certi = repo.List();
            return View(certi);
        }
        [HttpGet]
        public ActionResult GetCerti(int id)
        {
            var certi = repo.Find(x=>x.id == id);
            ViewBag.d = id;
            return View(certi);
        }
        [HttpPost]

        public ActionResult GetCerti(TblCertificiates t)
        {
            var certi = repo.Find(x => x.id == t.id);
            certi.organizator = t.organizator;
            certi.comment = t.comment;
            certi.date = t.date;
            repo.TUpdate(certi);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult NewCerti()
        {
            return View();

        }

        [HttpPost]

        public ActionResult NewCerti(TblCertificiates p)
        {
            repo.TAdd(p);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteCerti(int id)
        {
            var certi=repo.Find(x=>x.id == id);
            repo.TRemove(certi);
            return RedirectToAction("Index");   
        }
    }
}