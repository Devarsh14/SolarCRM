using Microsoft.AspNetCore.Mvc;
using SolarCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarCRM.Services
{
    public interface IContactUsService
    {
        void CreateContactUSRequest(ContactUs contactUs);        
    }

    public class ContactUsService : IContactUsService
    {
        private readonly SolarCRMContext solarCRMContext;
        public ContactUsService(SolarCRMContext solarCRMContext)
        {
            this.solarCRMContext = solarCRMContext;
        }
        public  void CreateContactUSRequest(ContactUs contactUs)
        {
            IActionResult actionResult = default;
            contactUs.Id = Guid.NewGuid();


            this.solarCRMContext.Add(contactUs);
            try
            {
                
                this.solarCRMContext.SaveChanges();
            }
            catch (Exception ex)
            {
              
            }
            //Bug : 

            // if succesfull send email to customer and owner 
            // Send sms to owner 
            


        }
    }
}
