namespace WebAPIAuth.GenericRepositories
{
    public interface IGenericUnitOfWork
    {
        public IGenericEmployee<T> GetInstance<T>() where T : class;
    }
}
