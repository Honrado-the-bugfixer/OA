using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _db;

        public Repository(DbContext db)
        {
            _db = db;
        }
        public void Delete(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
        }

        public void DeleteMany(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().RemoveRange(entities);
        }

        public ICollection<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public ICollection<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate)
        {
           return _db.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity GetOne(int id)
        {
           return _db.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void InsertMany(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().AddRange(entities);
        }
    }
}
