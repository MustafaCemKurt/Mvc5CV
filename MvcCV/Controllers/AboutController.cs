using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class AboutController : Controller
    {
        GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();

        [HttpGet]
        public ActionResult Index()
        {
            var inte = repo.List();
            return View(inte);
        }
        [HttpPost]
        public ActionResult Index(TblAbout p)
        {
            var t = repo.Find(x => x.ıd == 1);
            t.name = p.name;
            t.surname = p.surname;
            t.adress = p.adress;
            t.phone = p.phone;
            t.mail = p.mail;
            t.photo = p.photo;
            t.comment = p.comment;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}