using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolarCRM.Models;
using SolarCRM.Services;

namespace SolarCRM.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsService contactUsService;
        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ContactUs contactUs = new ContactUs();
            return View(contactUs);
        }

        [HttpPost]
        public IActionResult CreateContactUsRequest(ContactUs contactUs)
        {
            this.contactUsService.CreateContactUSRequest(contactUs);

            return View(nameof(Index));
        }
    }
}