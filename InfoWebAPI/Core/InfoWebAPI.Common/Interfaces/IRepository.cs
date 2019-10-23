using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);
    }
}