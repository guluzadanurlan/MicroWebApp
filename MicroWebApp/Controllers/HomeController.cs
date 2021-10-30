using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MicroWebApp.Models;
using MicroWebApp.Models.ControllersModels;
using MicroWebApp.Repositories.Entity;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace MicroWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page=1)
        {
            UnitOfWork unit = new UnitOfWork(new microwebappDbContext());
            var BlogAndAuthor= unit.BlogRepository.GetJoinData("Author");//blog an author
            microwebappDbContext db=new microwebappDbContext();

            var BlogInfo=(from blog in BlogAndAuthor
            join photo in db.BlogsPhotos on blog.Id equals photo.BlogId
            select new BlogsModelsWithPhoto(){
                Author=blog.Author.FirstName,
                Title=blog.Title,
                Text=blog.Text,
                PhotoPath=photo.PhotoPath,
                CreateDate=Convert.ToDateTime(blog.CreateDate),
                FirstName= blog.Author.FirstName
            }).ToList().ToPagedList(page,2);
            //

            return View(BlogInfo);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
