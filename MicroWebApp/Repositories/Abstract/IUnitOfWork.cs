namespace MicroWebApp.Repositories.Abstract
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }

        public IUsersPhotoRepository UserPhotoRepository { get; }
        public IBlogRepository BlogRepository { get; }
        public IBlogsPhotoRepository BlogPhotoRepository { get; }
        public ICategoryRepository CategoryRepository { get; }

        public void Complete();
    }
}