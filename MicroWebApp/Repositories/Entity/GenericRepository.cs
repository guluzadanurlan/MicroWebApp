using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using static MicroWebApp.Repositories.Abstract.IGenericRepository;

namespace MicroWebApp.Repositories.Entity
{
     public class GenericRepository<entityT> : IGenericRepository<entityT> where entityT : class, new()
    {

       
       protected DbContext _context;
        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(entityT par)
        {
            _context.Set<entityT>().Add(par);
           
        }

        public List<entityT> GetList()
        {
            return _context.Set<entityT>().ToList();
        }

        public void Update(entityT par)
        {
            _context.Set<entityT>().Update(par);
           
        }

        public void Delete(entityT par)
        {
            _context.Set<entityT>().Remove(par);
            
        }

        public entityT GetFindId(object Id)
        {
            return _context.Set<entityT>().Find(Id);
        }

        //include join
        public List<entityT> GetJoinData(string par)
        {
            return _context.Set<entityT>().Include(par).ToList();
        }
    }
}