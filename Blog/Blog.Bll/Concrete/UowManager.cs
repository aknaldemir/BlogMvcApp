using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Bll.Abstract;

namespace Blog.Bll.Concrete
{
    public class UowManager:IUowManager
    {
        private ICategoryManager _categoryManager;
        private INewsManager _newsManager;

        public ICategoryManager CategoryManager => 
            _categoryManager ?? (_categoryManager = new CategoryManager());

        public INewsManager NewsManager => 
            _newsManager ?? (_newsManager = new NewsManager());
    }
}
