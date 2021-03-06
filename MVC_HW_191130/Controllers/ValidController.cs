﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HW_191130.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        [Obsolete("改用Range就可以做到金錢範圍驗證")]
        public ActionResult Amount(int 金錢)
        {            
            bool isValidate = 金錢 > 0 ;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Date(DateTime 時間)
        {            
            bool isValidate = 時間 <= DateTime.Now;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}