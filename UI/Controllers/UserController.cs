using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly short _systemId = 1; 

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: UserController
        public IActionResult Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }

        // GET: UserController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public IActionResult Create()
        {
            return View(new UserVM());
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserVM userVM)
        {
            try
            {
                userVM.CreatedById = _systemId;
                _userService.Create(userVM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(userVM);
            }
        }

        // GET: UserController/Edit/5
        public IActionResult Edit(short id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(short id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public IActionResult Delete(short id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(short id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
