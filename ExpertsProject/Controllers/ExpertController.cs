using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpertsProject.Models;
using IdentitySample.Models;
using ExpertsProject.DAL;
using PagedList;

namespace ExpertsProject.Controllers
{
    public class ExpertController : Controller
    {
        private ExpertContext db = new ExpertContext();
        // GET: Expert
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var experts = from s in db.Users
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                experts = experts.Where(s => s.lastName.Contains(searchString) || s.firstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    experts = experts.OrderByDescending(s => s.lastName);
                    break;
                default:
                    experts = experts.OrderBy(s => s.lastName);
                    break;
                    //
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(experts.ToPagedList(pageNumber, pageSize));
        }
    }
}