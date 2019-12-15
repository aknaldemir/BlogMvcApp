using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Dal.Abstract
{
    public interface INewsRepository:IEntityRepository<News>
    {
        IQueryable<News> GetNewsWithCategory();
    }
}
