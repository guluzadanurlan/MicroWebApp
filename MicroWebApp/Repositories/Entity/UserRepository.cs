using MicroWebApp.Identity;
using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
       public UserRepository (MicroWebDataContext context):base(context)
        {
            
        }
       

       
    }
}