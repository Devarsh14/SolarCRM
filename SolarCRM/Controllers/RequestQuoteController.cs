﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SolarCRM.Controllers
{
    public class RequestQuoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}