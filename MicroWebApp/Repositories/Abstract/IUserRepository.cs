using MicroWebApp.Identity;
using static MicroWebApp.Repositories.Abstract.IGenericRepository;

namespace MicroWebApp.Repositories.Abstract
{
    public interface IUserRepository:IGenericRepository<User>
    {
         
    }
}