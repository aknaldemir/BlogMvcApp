using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Bll.Abstract;
using Blog.Dal.Concrete.EntityFramework;
using Blog.Entities.Abstract;

namespace Blog.Bll.Concrete
{
    public class EntityManager<TEntity> : IEntityManager<TEntity> where TEntity:class,IEntity,new()
    {
       
        public EntityManager()
        {
           
        }
        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            return null;
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
