using System;
using System.Collections.Generic;

namespace SolarCRM.Models
{
    public partial class ContactUs
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool IsContacted { get; set; }
    }
}
