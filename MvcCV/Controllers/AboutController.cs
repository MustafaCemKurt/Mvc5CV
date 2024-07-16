using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.
namespace MvcCV.Controllers
{
    public class AboutController : Controller
    {
        GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();

        [HttpGet]
        public ActionResult Index()
        {
            var inter = repo.List();
            return View(inter);
        }
        [HttpPost]
        public ActionResult Index(TblAbout p)
        {
            var t = repo.Find(x => x.id == 1);
            t.name = p.name;
            t.surname = p.surname;
            t.adress = p.adress;
            t.phone = p.phone;
            t.mail = p.mail;
            t.photo = p.photo;
            
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}