using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using form.Models;

namespace form.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbConnector _dbConnector;

        public HomeController(DbConnector connect)
        {
            _dbConnector = connect;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = ""; //we have to put it here bc when we just load the page we dont have any errors and the html page is trying to loop through nothing and its giving you an error. thats why we give this viewbag
            return View("Index");
        }

        [HttpPost]
        [Route("/process")]
        public IActionResult Proccess(string fn, string ln, int age, string email, string password)
        {
            User newUser = new User
            {
                first_name = fn,
                last_name = ln,
                age = age,
                email = email,
                password = password
            };

            TryValidateModel(newUser);
            ViewBag.errors = ModelState.Values;
            if (ModelState.IsValid)
            {
                return View("About");
            }
            else
            {
                return View("Index");
            }
        }
    }
}





// class
// [required]

// public delegate release Date 