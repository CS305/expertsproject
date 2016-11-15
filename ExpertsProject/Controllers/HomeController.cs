using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using IdentitySample.Models;
using ExpertsProject.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Entity;
using System;
using System.Linq;

namespace IdentitySample.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public async Task<ActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var experts = from s in db.Users
                          select s;
            if(!String.IsNullOrEmpty(searchString))
            {
                experts = experts.Where(s => s.lastName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    experts = experts.OrderByDescending(s => s.lastName);
                    break;
                default:
                    experts = experts.OrderBy(s => s.lastName);
                    break;
            }
            return View(await UserManager.Users.ToListAsync());
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;


        private ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        public HomeController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        public string getFirstName(string userId)
        {
            string firstName = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from AspNetUsers Where UserName=@fname";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", userId);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        firstName = oReader["firstName"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return firstName;
        }
    }
}