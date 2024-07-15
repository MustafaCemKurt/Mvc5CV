using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;
namespace MvcCV.Controllers{
    public class SkillController : Controller
    {
        // GET: Skill

        GenericRepository<TblSkills> repo = new GenericRepository<TblSkills>();
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }
        [HttpGet]
        public ActionResult newSkill()
        {

            return View();
        }
        [HttpPost]
        public ActionResult newSkill(TblSkills p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
    }