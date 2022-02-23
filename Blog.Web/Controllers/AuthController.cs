using Blog.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;

        public AuthController(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            return View(model);
        }

        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}
