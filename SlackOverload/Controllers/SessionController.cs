using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SlackOverload.Models;

namespace SlackOverload.Controllers
{
    public class SessionsController : Controller
    {
        private DAL dal;

        public SessionsController(IConfiguration config)
        {
            dal = new DAL(config.GetConnectionString("default"));
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            IEnumerable<Question> results = dal.GetQuestionsMostRecent();

            ViewData["Questions"] = results;

            if (username == "TBarron" && password == "pass123")
            {
                HttpContext.Session.SetString("Username", "TBarron");
                HttpContext.Session.SetInt32("UID", 12345);
                return View("../QandA/Index");
            }
            else if (username == "MDubose" && password == "321pass")
            {
                HttpContext.Session.SetString("Username", "MDubose");
                HttpContext.Session.SetInt32("UID", 12346);
                return View("../QandA/Index");
            }
            else if (username == "OOmishope" && password == "231pass")
            {
                HttpContext.Session.SetString("Username", "OOmishope");
                HttpContext.Session.SetInt32("UID", 12347);
                return View("../QandA/Index");
            }
            else
            {
                TempData["ErrorMsg"] = "User/password error!";
                return RedirectToAction("Home/Index");
            }


        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return View();
        }

        public IActionResult ShowSessionInfo()
        {
            string username = HttpContext.Session.GetString("Username");
            int? userid = HttpContext.Session.GetInt32("UID");

            ViewData["Username"] = username;
            ViewData["UID"] = userid;

            return View();
        }
    }
}