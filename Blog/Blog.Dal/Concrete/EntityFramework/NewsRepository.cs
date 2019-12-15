using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Dal.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Dal.Concrete.EntityFramework
{
    public class NewsRepository:EntityRepository<News,NewsContext>,INewsRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsRepository()
        {
            _unitOfWork = new EfUnitOfWork(new NewsContext());
        }

        public IQueryable<News> GetNewsWithCategory()
        {
            var list = _unitOfWork.NewsRepository
                .GetAll()
                .Include(i => i.Category);
            
            return list;
        }
    }
}
