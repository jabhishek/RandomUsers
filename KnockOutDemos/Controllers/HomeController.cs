﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockOutDemos.Infrastructure;
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
            return View();
        }
    }
}
