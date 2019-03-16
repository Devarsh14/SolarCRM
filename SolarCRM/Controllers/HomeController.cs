using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SolarCRM.Models;
using SolarCRM.Services;

namespace SolarCRM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthorizationService authorizationService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IUserService userService;
        




        public HomeController(IAuthorizationService authorizationService,  RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager,IUserService userService) //, IdentityUser identityUser
        {
            this.authorizationService = authorizationService;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.userService = userService;
            

           // this.identityUser = identityUser;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Administrator")]
        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
