﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Areas.Cms.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}