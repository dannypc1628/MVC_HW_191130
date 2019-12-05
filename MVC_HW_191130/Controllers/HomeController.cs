﻿using MVC_HW_191130.Models;
using MVC_HW_191130.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HW_191130.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Money()
        {
            int count = 100;
            List<MoneyViewModel> list = new List<MoneyViewModel>(count);
            MoneyViewModelRandom randomData = new MoneyViewModelRandom();
            for(int i = 0; i < count; i++)
            {
                list.Add(randomData.Get());
            }

            return View(list);
        }
    }
}