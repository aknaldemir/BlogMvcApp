using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Dal.Abstract;

namespace Blog.Dal.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private NewsContext _context;
        private INewsRepository _newsRepository;
        private ICategoryRepository _categoryRepository;
        private IUserRepository _userRepository;
        public EfUnitOfWork(NewsContext context)
        {
            _context = context ?? throw new ArgumentNullException("dbcontext cannot null"); ;
        }

        public INewsRepository NewsRepository =>
            _newsRepository ?? (_newsRepository = new NewsRepository());
        public ICategoryRepository CategoryRepository =>
            _categoryRepository ?? (_categoryRepository = new CategoryRepository());

        public IUserRepository UserRepository =>
            _userRepository ?? (_userRepository = new UserRepository());


        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception exception)
            {
                throw new Exception("SaveChanges esnasında hata meydana geldi: "+exception.Message);
            }
        }

        public void Dispose()
        {
           _context.Dispose();
        }


    }
}
