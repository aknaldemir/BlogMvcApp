﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Bll.Abstract
{
    public interface INewsManager:IEntityManager<News>
    {
        List<News> GetNewsWithCategory();
    }
}
