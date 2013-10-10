using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockOutDemos.Models;

namespace KnockOutDemos.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloWorld()
        {
            return View();
        }

        public ActionResult ViewUser()
        {
            return View();
        }

        public ActionResult RandomUsers()
        {
/*
            var initialState = new[] {
                    new RandomUser { Title = "Mr", FirstName = "Gabriella", LastName = "Cook", Street = "1303 w dallas st", City = "Waxahachie", State  = "North carolina", Gender = "F", 
                        Zip = "63145", ImageUrl = "http://api.randomuser.me/0.2/portraits/women/34.jpg"}, 
                        new RandomUser { Title = "Mr", FirstName = "Gabriella", LastName = "Cook", Street = "1303 w dallas st", City = "Waxahachie", State  = "North carolina", Gender = "F", 
                        Zip = "63145", ImageUrl = "http://api.randomuser.me/0.2/portraits/women/34.jpg"},
                };
*/
            return View();

        }


    }
}
