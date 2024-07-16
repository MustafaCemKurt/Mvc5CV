using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class InterestController : Controller
    {
        // GET: Interest

        GenericRepository<TblInterests> repo = new GenericRepository<TblInterests>();

        [HttpGet]    
        public ActionResult Index()
        {
            var inter = repo.List();
            return View(inter);
        }
        [HttpPost]
        public ActionResult Index(TblInterests p)
        {
          var t = repo.Find(x=>x.id ==1);
            t.comment1 = p.comment1;
            t.comment2 = p.comment2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}