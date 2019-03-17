using Microsoft.AspNetCore.Mvc;
using SolarCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarCRM.Services
{
    interface IContactUsService
    {
        IActionResult CreateContactUSRequest(ContactUs contactUs);        
    }

    public class ContactUsService : IContactUsService
    {
        private readonly SolarCRMContext solarCRMContext;
        public ContactUsService(SolarCRMContext solarCRMContext)
        {
            this.solarCRMContext = solarCRMContext;
        }
        public IActionResult CreateContactUSRequest(ContactUs contactUs)
        {
            throw new NotImplementedException();
        }
    }
}
