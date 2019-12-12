using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bll.Abstract
{
    public interface IUowManager
    {
        ICategoryManager CategoryManager { get;}
        INewsManager NewsManager { get; }

    }
}
