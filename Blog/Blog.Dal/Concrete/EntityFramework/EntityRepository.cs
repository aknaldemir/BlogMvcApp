using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.Dal.Abstract;
using Blog.Entities.Abstract;

namespace Blog.Dal.Concrete.EntityFramework
{
    public class EntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity:class,IEntity,new()
    where TContext:DbContext,new()
    {
        private TContext _context;
        public EntityRepository()
        {
            _context=new TContext();
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }   
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
           return _context.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter==null)
            {
                return _context.Set<TEntity>().ToList();
            }
            else
            {
                return _context.Set<TEntity>().Where(filter).ToList();
            }

            //return filter==null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
