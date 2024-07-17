using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class SocialController : Controller
    {
        // GET: Social

        GenericRepository<TblSocial> repo = new GenericRepository<TblSocial>();
        public ActionResult Index()
        {
            var veri = repo.List();
            return View(veri);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Add(TblSocial p )
        {
            repo.TAdd(p);
            return  RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetPage(int id)

        {
            var acc = repo.Find(x=>x.ID == id);
            return View(acc);

        }
        [HttpPost]
        public ActionResult GetPage(TblSocial p)

        {

            var acc = repo.Find(x => x.ID == p.ID);
            acc.name1 = p.name1;
            acc.link=p.link;
            acc.icon=p.icon;
            repo.TUpdate(acc);
            return RedirectToAction("Index");
        }
    }
}