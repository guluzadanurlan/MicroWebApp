using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
    public class UsersPhotoRepository:GenericRepository<UsersPhoto>, IUsersPhotoRepository
    {
         public UsersPhotoRepository (microwebappDbContext context):base(context)
        {
            
        }
       
    }
}