using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Model.Account;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid || loginVM == null)
            {
                return View(loginVM);
            }

            var result = await _accountService.Login(loginVM);
             
            if(result == null)
            {
                TempData["UserNotFoundMessage"] = "Kullanıcı adı veya şifre hatalı.";
                return View(loginVM);
            }

            return RedirectToAction("Index","User");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterVM());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid || registerVM == null)
            {
                return View(registerVM);
            }

            var result = await _accountService.Register(registerVM);

            if(result == null)
            {
                TempData["RegisterErrorMessage"] = "Kayıt olurken hata oluştu.";
                return View(registerVM);
            }

            if(result == "exists")
            {
                TempData["RegisterErrorMessage"] = "Kullanıcı adı mevcut.";
                return View(registerVM);
            }

            return RedirectToAction(nameof(Login));
        }
    }
}
