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
    public class NewsManager : INewsManager
    {
        private INewsRepository _newsRepository;
        public NewsManager()
        {
            _newsRepository = new NewsRepository();
        }

        public News GetById(int id)
        {
            return _newsRepository.GetById(id);
        }

        public List<News> GetAll()
        {
            return _newsRepository.GetAll().ToList();
        }

        public void Create(News entity)
        {
            throw new NotImplementedException();
        }

        public void Update(News entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(News entity)
        {
            throw new NotImplementedException();
        }

        public List<News> GetNewsWithCategory()
        {
            return _newsRepository.GetNewsWithCategory().ToList();
        }
    }
}
