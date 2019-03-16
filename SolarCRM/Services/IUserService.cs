using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SolarCRM.Services
{
    //https://stackoverflow.com/questions/30701006/how-to-get-the-current-logged-in-user-id-in-asp-net-core
    //https://stackoverflow.com/questions/40057502/how-to-get-users-mail-address-with-identity-and-asp-net-core
    public interface IUserService
    {
        string UserId { get; set; }
        Task<string> GetUserIdAsync(ClaimsPrincipal claimsPrincipal);
        
        

    }

    public class UserService : IUserService
    {
        private readonly IAuthorizationService authorizationService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        

        public UserService(IAuthorizationService authorizationService, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager) //, IdentityUser identityUser
        {
            this.authorizationService = authorizationService;
            this.roleManager = roleManager;
            this.userManager = userManager;

            // this.identityUser = identityUser;

        }

        public string UserId { get ; set ; }

       
        public async Task<string> GetUserIdAsync(ClaimsPrincipal claimsPrincipal)
        {
            var listofRoles = this.roleManager.Roles;
            // this.userManager.
            var principal = claimsPrincipal.Identity;
            var identities = claimsPrincipal.Identities;


            var userId = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier).Value;// will give the user's userId
            var userName = claimsPrincipal.FindFirst(ClaimTypes.Name).Value; // will give the user's userName

            var IdentityUser = await userManager.FindByIdAsync(userId).ConfigureAwait(false);
            var roles = await this.userManager.GetRolesAsync(IdentityUser).ConfigureAwait(false);

            return userId;
        }


    }
}
