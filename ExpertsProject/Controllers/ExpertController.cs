using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpertsProject.Models;
using ExpertsProject.DAL;

namespace ExpertsProject.Controllers
{
    public class ExpertController : Controller
    {
        private ExpertContext db = new ExpertContext();
        // GET: Expert
        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            var experts = from s in db.Experts
                          select s; 

            switch (sortOrder)
            {
                case "name_desc":
                    experts = experts.OrderByDescending(s => s.LName);
                    break;
                default:
                    experts = experts.OrderBy(s => s.LName);
                    break;
            }
            return View(experts.ToList());
        }

        public ViewResult Index()
        {
            return View(db.Experts.ToList());
        }
    }
}