using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();

        }
        [HttpPost]

        public ActionResult AddExperience(TblExperience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
           
        }

        public ActionResult DeleteExperience(int id)
        {
            TblExperience t = repo.Find(x => x.id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");

        }

        [HttpGet]

        public ActionResult GetExperience(int id )
        {
            TblExperience t = repo.Find(x => x.id == id);
            return View(t);
        }

        [HttpPost]

        public ActionResult GetExperience(TblExperience p )
        {
            TblExperience t = repo.Find(x => x.id == p.id);
            t.baslik=p.baslik;
            t.date=p.date;  
            t.comment=p.comment;    
            t.altbaslik=p.altbaslik;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}