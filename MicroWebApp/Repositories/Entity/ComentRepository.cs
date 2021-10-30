using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
    
        public class ComentRepository:GenericRepository<Coment>, IComentRepository
    {
         public ComentRepository (microwebappDbContext context):base(context)
        {
            
        }
       
    }
    }
