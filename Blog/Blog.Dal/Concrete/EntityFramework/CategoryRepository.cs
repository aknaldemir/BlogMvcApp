using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Dal.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Dal.Concrete.EntityFramework
{
    public class CategoryRepository:EntityRepository<Category,NewsContext>,ICategoryRepository
    {
        public void CustomFunctionForCategory()
        {
            throw new NotImplementedException();
        }
    }
}
