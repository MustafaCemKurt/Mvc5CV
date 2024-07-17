using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    [Authorize]
    public class EducationController : Controller
    {
        // GET: Education
        GenericRepository<TblEducation> repo = new GenericRepository<TblEducation>();

        
        public ActionResult Index()
        {
            var edu = repo.List();
            return View(edu);
        }
        [HttpGet]
        public ActionResult AddEdu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEdu(TblEducation p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEdu(int id)
        {
            var edu = repo.Find(x=>x.id == id); 
            repo.TRemove(edu);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEdu(int id)
        {
            var edu=repo.Find(x=>x.id == id);
            return View(edu);

        }
        [HttpPost]
        public ActionResult EditEdu(TblEducation p)
        {
            var edu = repo.Find(x => x.id == p.id);
            edu.baslik=p.baslik;
            edu.altbaslik=p.altbaslik;
            edu.altbaslik2 = p.altbaslik2;
            edu.GNO=p.GNO;
            edu.date=p.date;
            repo.TUpdate(edu);
            return RedirectToAction("Index");   

        }
    }
}