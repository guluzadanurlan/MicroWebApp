using System.Collections.Generic;

namespace MicroWebApp.Repositories.Abstract
{
    public interface IGenericRepository
    {
          public interface IGenericRepository<entityT> where entityT : class, new()
    {
        public void Add(entityT par);


        public List<entityT> GetList();


        public void Update(entityT par);

        public void Delete(entityT par);


        public entityT GetFindId(object Id);

        public List<entityT> GetJoinData(string par);
    }
    }
}