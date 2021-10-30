using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MicroWebApp.Models;
using MicroWebApp.Models.ControllersModels;
using MicroWebApp.Repositories.Entity;

namespace MicroWebApp.Controllers
{
    public class TestedController : Controller
    {
        public IActionResult Index()
        {
           
            microwebappDbContext db= new microwebappDbContext();
            var data1=db.Blogs;
            var data2=db.BlogsPhotos;
//LINQ join
            var join=(from blog in data1 
            join photo in data2 on blog.Id equals photo.BlogId
            select new BlogsModelsWithPhoto(){

                Title=blog.Title,
                Text=blog.Text,
                PhotoPath=photo.PhotoPath

            }).ToList();
            
            return View(join);
        }
    }
}