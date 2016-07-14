using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebDeveloper.Models;

namespace WebDeveloper.Service
{
    public static class AccountService
    {
        public static async Task<IdentityResult> CreateUser(RegisterViewModel model, ApplicationUserManager UserManager)
        {
            var user = new WebDeveloperUser { UserName = model.Email, Email = model.Email };
            var result = await UserManager.CreateAsync(user, model.Password);            
            return result;
        }
    }
}