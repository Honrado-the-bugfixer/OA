using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetOne(int id);
        ICollection<TEntity> GetAll();
        ICollection<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void InsertMany(IEnumerable<TEntity> entities);
        void DeleteMany(IEnumerable<TEntity> entities);
    }
}
