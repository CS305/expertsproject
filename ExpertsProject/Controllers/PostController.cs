using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpertsProject.Models;
using IdentitySample.Models;
using PagedList;
using System;

namespace ExpertsProject.Controllers
{
    public class PostController : Controller
    {
        private ApplicationDbContext _dbContext;
        public PostController()
        {
            _dbContext = new ApplicationDbContext();
        }
        publicActionResult Index()
        {
            var posts = _dbContext.Post.Tolist();
            return View(posts);
        }

        public ActionResult Add(Post post)
        {
            _dbContext.Post.Add(post);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var post = _dbContext.Post.SingleOrDefault(v => v.ID == id);

            if (post == null)
            {
                return HttpnotFound();
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult
    
    }
}