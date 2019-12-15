using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Bll.Abstract;
using Blog.Dal.Abstract;
using Blog.Dal.Concrete.EntityFramework;
using Blog.Entities.Concrete;

namespace Blog.Bll.Concrete
{
    public class CategoryManager:ICategoryManager
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }
        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll().ToList();
        }

    }
}
