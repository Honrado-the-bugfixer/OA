using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
           //var entityToDelete = 
        }

        public long DeleteMany(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public long Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public long InsertMany(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
