using MicroWebApp.Models;
using MicroWebApp.Repositories.Abstract;

namespace MicroWebApp.Repositories.Entity
{
    public class UnitOfWork : IUnitOfWork
    {
        private microwebappDbContext _dbContext;
       
        public UnitOfWork(microwebappDbContext dbContext)
        {
            _dbContext = dbContext;
            AspNetUserRepository = new AspNetUserRepository(_dbContext);
            UserPhotoRepository = new UsersPhotoRepository(_dbContext);
            BlogRepository = new BlogRepository(_dbContext);
            BlogPhotoRepository = new BlogsPhotoRepository(_dbContext);
            CategoryRepository = new CategoryRepository(_dbContext);
        }

        public IAspNetUserRepository AspNetUserRepository { get; private set; }

        public IUsersPhotoRepository UserPhotoRepository { get; private set; }
        public IBlogRepository BlogRepository { get; private set; }
        public IBlogsPhotoRepository BlogPhotoRepository { get; private set; }

        public ICategoryRepository CategoryRepository { get; private set; }

        public void Complete()
        {
            _dbContext.SaveChanges();
        }
    }
}