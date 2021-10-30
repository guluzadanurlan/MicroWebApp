using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MicroWebApp.HelperClass;
using MicroWebApp.Models;
using MicroWebApp.Repositories.Entity;
using System.Data.SqlClient;

namespace MicroWebApp.Controllers
{
      [Authorize(Roles = "User")]
    public class BlogPostController : Controller
    {
        [HttpGet]
        public IActionResult BlogPost()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult BlogPost(Blog blogModel, UploadPhotoModel imgModel)
        {
            string Id=HttpContext.Session.GetString("Id");

            UnitOfWork unitofwork=new UnitOfWork(new microwebappDbContext());
            BlogsPhoto blogPhoto=new BlogsPhoto();

           
            blogPhoto.PhotoPath= UploadImage.Add(imgModel);
            
            blogModel.CreateDate=System.DateTime.Now;
            blogModel.AuthorId=Id;

            
            unitofwork.BlogRepository.Add(blogModel);
            unitofwork.Complete();
            
            unitofwork.BlogPhotoRepository.Add(blogPhoto);
            unitofwork.Complete();

           
            return View();
        }
    }
}