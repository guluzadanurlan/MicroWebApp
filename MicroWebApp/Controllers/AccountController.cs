using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MicroWebApp.EMailService;
using MicroWebApp.HelperClass;
using MicroWebApp.Identity;
using MicroWebApp.Models;
using MicroWebApp.Models.ControllersModels;
using MicroWebApp.Repositories.Entity;
using Newtonsoft.Json;

namespace MicroWebApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }


        ///******************Login*******************//
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

            HttpContext.Session.SetString("UserName", model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Sizin Hesabiniz yoxdur qeydiyyatdan kecin");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Hesabinizi mail-iz ile tesdiq edin");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                HttpContext.Session.SetString("Id",user.Id);
                TempData.Put("message", new AlertMessage()
                {
                    Title="Xos geldiniz",
                    Message="Xos geldiniz "+model.UserName,
                    AlertType="success"
                });
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //************Register************************//
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
                Email=model.Email,

            };
     
            var result = await _userManager.CreateAsync(user, model.Password);
            UnitOfWork unitofwork = new UnitOfWork(new microwebappDbContext());
            UsersPhoto dbUserPhoto = new UsersPhoto();
            dbUserPhoto.UserId = user.Id;
            dbUserPhoto.PhotoPath = UploadImage.Add(par);
            unitofwork.UserPhotoRepository.Add(dbUserPhoto);
            unitofwork.Complete();//UserPhooto data send database
            if (result.Succeeded)
            {
                // generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });

                // email
                await _emailSender.SendEmailAsync(model.Email, "Hesabinizi tesdiqlemek ucun", $"https://localhost:5001{url}'> linke</a> daxil olun");
                //with Tempdata message
               TempData.Put("message", new AlertMessage()
                {
                    Title="Ugurla qeydiyyatdan kecdiniz",
                    Message="Mail-iz ile hesabinizi tesdiq edin",
                    AlertType="success"
                });
                return RedirectToAction("Login", "Account");
            }

            ModelState.AddModelError("", "Namelum xeta bas verdi");
            return View(model);
        }
    
        //**************My profile********************//
        public async Task<IActionResult> Profile()
        {
            MicroWebDataContext db = new MicroWebDataContext();
            string _userName = HttpContext.Session.GetString("UserName");
            var data = await _userManager.FindByNameAsync(_userName);
            UnitOfWork unit = new UnitOfWork(new microwebappDbContext());
            var photo = db.UsersPhotos.FirstOrDefault(x => x.UserId == data.Id);
            if (photo != null)
            {
                ViewBag.Path = photo.PhotoPath;
            }
            else
            {
                ViewBag.Path = "1.jpeg";
            }
            return View(data);
        }

         //************ConfirmEmail ******************//
          public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if(userId==null || token ==null)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title="Xetali token.",
                    Message="Xetali Token",
                    AlertType="danger"
                });
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if(user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user,token);
                if(result.Succeeded)
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title="Hesabiniz tesdiqlendi",
                        Message="Hesabiniz tesdiqlendi",
                        AlertType="success"
                    });
                    return View();
                }
            }
            TempData.Put("message", new AlertMessage()
            {
                Title="Hesab??n??z tesdiqlenmedi.",
                Message="Hesab??n??z?? tesdiqlenmedi.",
                AlertType="warning"
            });
            return View();
        }
   
        //************Log out************************//
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new AlertMessage(){
                Title="Hesabdan cixis etdiniz",
                Message="Hesabinizdan tehlukesiz sekilde cixis etdiniz",
                AlertType="success"
            });
            return RedirectToAction("Index", "Home");
        }

        //************Forgot password************************//


        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if(string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if(user==null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var url = Url.Action("ResetPassword","Account",new {
                userId = user.Id,
                token = code
            });

            // email
            await _emailSender.SendEmailAsync(Email,"Reset Password",$"Parolunuzu yenilemek ucun <a href='https://localhost:5001{url}'>daxil olun.</a>");

            return View();
        }

        //************Reset Password************************//


        public IActionResult ResetPassword(string userId,string token)
        {
            if(userId==null || token==null)
            {
                return RedirectToAction("Home","Index");
            }

            var model = new ResetPasswordModel {Token=token};

            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
       {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user==null)
            {
                return RedirectToAction("Home","Index");
            }

            var result = await _userManager.ResetPasswordAsync(user,model.Token,model.Password);

            if(result.Succeeded)
            {
                return RedirectToAction("Login","Account");
            }

            return View(model);
        }

    }
}