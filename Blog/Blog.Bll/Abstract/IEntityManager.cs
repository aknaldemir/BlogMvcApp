using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Dal.Abstract;
using Blog.Dal.Concrete.EntityFramework;
using Blog.Entities.Abstract;

namespace Blog.Bll.Abstract
{
    public interface IEntityManager<TEntity> where TEntity :class,IEntity,new()
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
