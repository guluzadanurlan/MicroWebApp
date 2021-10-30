using System;

namespace MicroWebApp.Models.ControllersModels
{
    public class BlogsModelsWithPhoto
    {
        public string FirstName{get;set;}
        public string Title { get; set; }
        public string Text { get; set; }
        public string PhotoPath { get; set; }
        public string Author{get;set;}
        public DateTime CreateDate{get;set;}
    }
}
