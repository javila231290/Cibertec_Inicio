using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Models.Account;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public UserManager<WebDeveloperUser> UserManager { get; private set; }

        public AccountController() 
            : this(new UserManager<WebDeveloperUser>
                  (new UserStore<WebDeveloperUser>
                (new WebUserDbContext())))
        {

        }

        public AccountController(UserManager<WebDeveloperUser> userManager)
        {
            UserManager = userManager;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new WebDeveloperUser { UserName = model.UserName };
                //UserManager.Create(user, model.Password);
                var result = await UserManager.CreateAsync(user, model.Password); // mas rapido y devuelve un valor
                if(result.Succeeded)
                {
                    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                    var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = false
                    }, identity);
                }
                return RedirectToAction("Index", "Home");
            }            
            return View(model);
        }
        [HttpPost]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}