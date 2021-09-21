using System;
using WebAPIAuth.Model;

namespace WebAPIAuth.GenericRepositories
{
    public class GenericUnitOfWork : IGenericUnitOfWork, IDisposable
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IGenericEmployee<T> GetInstance<T>() where T : class
        {
            return new GenericEmployee<T>(context); // return an instance of the implementation 

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
