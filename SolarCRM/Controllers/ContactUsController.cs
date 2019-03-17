using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolarCRM.Models;

namespace SolarCRM.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ContactUs contactUs = new ContactUs();
            return View(contactUs);
        }

        [HttpPost]
        public IActionResult CreateContactUsRequest(ContactUs contactUs)
        {
            return View(nameof(Index));
        }
    }
}