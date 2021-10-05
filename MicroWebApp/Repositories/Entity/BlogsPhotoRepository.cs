using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
   public class BlogsPhotoRepository:GenericRepository<BlogsPhoto>, IBlogsPhotoRepository
    {
         public BlogsPhotoRepository (MicroWebDataContext context):base(context)
        {
            
        }
       
    }
}