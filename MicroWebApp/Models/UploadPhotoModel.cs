using Microsoft.AspNetCore.Http;

namespace MicroWebApp.Models
{
    public class UploadPhotoModel
    {
         
        public int UserId { get; set; }
       
        public IFormFile PhotoPath { get; set; }
    }
}