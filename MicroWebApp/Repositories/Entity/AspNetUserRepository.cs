using MicroWebApp.Identity;
using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
    public class AspNetUserRepository:GenericRepository<AspNetUser>, IAspNetUserRepository
    {
       public AspNetUserRepository (microwebappDbContext context):base(context)
        {
            
        }
       

       
    }
}