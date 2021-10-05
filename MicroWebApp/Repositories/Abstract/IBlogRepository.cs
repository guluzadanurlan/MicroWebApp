using MicroWebApp.Models;
using static MicroWebApp.Repositories.Abstract.IGenericRepository;

namespace MicroWebApp.Repositories.Abstract
{
    public interface IBlogRepository:IGenericRepository<Blog>
    {
         
    }
}