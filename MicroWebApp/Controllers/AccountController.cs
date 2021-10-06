using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MicroWebApp.HelperClass;
using MicroWebApp.Identity;
using MicroWebApp.Models;
using MicroWebApp.Repositories.Entity;
using Newtonsoft.Json;

namespace MicroWebApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Sizin Hesabiniz yoxdur qeydiyyatdan kecin");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                 var msg = new AlertMessage()
                {            
                    Message = "Xos geldiniz "+model.UserName,
                    AlertType = "success"
                };

                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model, UploadPhotoModel par)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,

            };

            var result = await _userManager.CreateAsync(user, model.Password);
            UnitOfWork unitofwork = new UnitOfWork(new MicroWebDataContext());
            UsersPhoto dbUserPhoto = new UsersPhoto();
            dbUserPhoto.UserId = user.Id;
            dbUserPhoto.PhotoPath = UploadImage.Add(par);
            unitofwork.UserPhotoRepository.Add(dbUserPhoto);
            unitofwork.Complete();//UserPhooto data send database
            if (result.Succeeded)
            {
                // generate token
                // email

                //with Tempdata message
                   var msg = new AlertMessage()
                {            
                    Message = "Ugurla qeydiyyatdan kecdiniz",
                    AlertType = "success"
                };

                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("Login", "Account");
            }

            ModelState.AddModelError("", "Bilinmeyen hata oldu lütfen tekrar deneyiniz.");
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}