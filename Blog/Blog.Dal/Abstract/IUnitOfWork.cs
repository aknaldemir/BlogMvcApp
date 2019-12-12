using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        INewsRepository NewsRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; }
        int SaveChanges();
    }
}
