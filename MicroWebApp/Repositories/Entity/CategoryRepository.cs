using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
    public class CategoryRepository:GenericRepository<Category>, ICategoryRepository
    {
         public CategoryRepository (microwebappDbContext context):base(context)
        {
            
        }
       
    }
}