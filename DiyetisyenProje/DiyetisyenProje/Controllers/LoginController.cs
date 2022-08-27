using DiyetisyenProje.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DiyetisyenProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager; 

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager; 
        }
       
        //[HttpGet]
        //[Authorize]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}
       
        //[HttpPost]
        //public async Task<IActionResult> SignUp(UserRegisterWM userRegisterWM)
        //{
        //    AppUser appuser = new AppUser()
        //    {
        //        Name = userRegisterWM.name,
        //        Surname = userRegisterWM.surname,
        //        Email= userRegisterWM.mail,
        //        UserName=userRegisterWM.username,
        //        PhoneNumber=userRegisterWM.phone
                

        //    };
        //    if(userRegisterWM.password==userRegisterWM.confirmpassword)
        //    {
        //        var result=await _userManager.CreateAsync(appuser,userRegisterWM.password);
        //        if(result.Succeeded)
        //        {
        //            return RedirectToAction("SignIn");
        //        }
        //        else
        //        {
        //            foreach (var item in result.Errors)
        //            {
        //                ModelState.AddModelError("", item.Description);
        //            }
        //        }
        //    }
        //    return View(userRegisterWM);
        //}
       
        [HttpGet]      
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginWM p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AdminAbout", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");

                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Main");
        }
    }
}
