using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
   public class BlogRepository:GenericRepository<Blog>, IBlogRepository
    {
         public BlogRepository (microwebappDbContext context):base(context)
        {
            
        }
       
    }
}