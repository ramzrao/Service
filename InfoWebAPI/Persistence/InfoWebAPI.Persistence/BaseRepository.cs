using InfoWebAPI.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace InfoWebAPI.Persistence
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly InfoWebDbContext _dbContext;

        protected BaseRepository(InfoWebDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(predicate.Compile());
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().AsEnumerable();
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().AsQueryable().Where(predicate.Compile());
        }
    }
}