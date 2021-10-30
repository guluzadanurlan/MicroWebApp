namespace MicroWebApp.Repositories.Abstract
{
    public interface IUnitOfWork
    {
        public IAspNetUserRepository AspNetUserRepository { get; }

        public IUsersPhotoRepository UserPhotoRepository { get; }
        public IBlogRepository BlogRepository { get; }
        public IBlogsPhotoRepository BlogPhotoRepository { get; }
        public ICategoryRepository CategoryRepository { get; }

        public void Complete();
    }
}