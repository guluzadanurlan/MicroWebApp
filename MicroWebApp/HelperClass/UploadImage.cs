using System;
using System.IO;
using MicroWebApp.Models;

namespace MicroWebApp.HelperClass
{
    public class UploadImage
    {
         static public string Add(UploadPhotoModel par)
        {
            UsersPhoto db = new UsersPhoto();
            if (par.PhotoPath != null)
            {
                var extension = Path.GetExtension(par.PhotoPath.FileName);
                var newImageName = Guid.NewGuid() + extension;
                //var newImageName = par.PhotoPath.FileName;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Photos/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                par.PhotoPath.CopyTo(stream);

                return "~/Photos/"+newImageName;
            }
            return " ";
        }

    }
}