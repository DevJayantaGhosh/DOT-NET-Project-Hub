using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MySecuredApp.MyUserDB;
using MySecuredApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MySecuredApp.Controllers
{
    public class MyAccountController : Controller
    {
        //Usename- c --I-- P
        //CookieAuthentication
        public async Task AsyncSignInByCookie(string userName)
        {
            List<Claim> ClaimsList = new List<Claim>();
            Claim c1 = new Claim(ClaimTypes.NameIdentifier, userName);
            Claim c2 = new Claim("name", userName);
            ClaimsList.Add(c1);
            ClaimsList.Add(c2);


            ClaimsIdentity claimsIdentity = new ClaimsIdentity(ClaimsList, CookieAuthenticationDefaults.AuthenticationScheme, "name", null);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(claimsPrincipal);
        }
        private IMyUserService AccountService;

        public MyAccountController(IMyUserService accountService)
        {
            AccountService = accountService;
        }


        public IActionResult RegisterUser()
        {
            return View("Register",new MyUser());

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(MyUser user)
        {
            if (ModelState.IsValid)
            {
               var res= this.AccountService.AsyncAddUser(user);
                if (res.IsCompleted)
                {
                   return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View("Register", new MyUser());
                }
            }
            else
            {

                return View("Register", new MyUser());
            }
  

        }

        public IActionResult Login()
        {
            return View(new MyUser());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(MyUser user,string returnUrl=null)
        {
            
            if (await AccountService.ValidateUser(user.UserName, user.HashPassword))
            {
                await AsyncSignInByCookie(user.UserName);
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }
           
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "MyAccount");

        }
    }



    
}
