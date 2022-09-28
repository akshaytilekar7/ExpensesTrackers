using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatternForCore.Core.EFContext;
using PatternForCore.Core.Repositories.Interfaces;

namespace PatternForCore.Core.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T>
         where T : class
    {
        private readonly IDatabaseContext _context;
        private readonly DbSet<T> dbSet;

        public GenericRepository(IDatabaseContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public virtual EntityState Add(T entity)
        {
            return dbSet.Add(entity).State;
        }

        public T Get<TKey>(TKey id)
        {
            var entity = dbSet.Find(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public async Task<T> GetAsync<TKey>(TKey id)
        {
            var entity = await dbSet.FindAsync(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public T Get(params object[] keyValues)
        {
            var entity = dbSet.Find(keyValues);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, string include)
        {
            return FindBy(predicate).Include(include);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet.AsNoTracking();
        }

        public IQueryable<T> GetAll(int page, int pageCount)
        {
            var pageSize = (page - 1) * pageCount;

            return dbSet.Skip(pageSize).Take(pageCount);
        }

        public IQueryable<T> GetAll(string include)
        {
            return dbSet.AsNoTracking().Include(include);
        }

        public async Task<IEnumerable<T>> GetAllAsync(string include)
        {
            return await _context.Set<T>().Include(include).ToListAsync();
        }

        public IQueryable<T> RawSql(string query, params object[] parameters)
        {
            return dbSet.FromSqlRaw(query, parameters);
        }

        public IQueryable<T> GetAll(string include, string include2)
        {
            return dbSet.AsNoTracking().Include(include).Include(include2);
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Any(predicate);
        }

        public virtual EntityState SoftDelete(T entity)
        {
            entity.GetType().GetProperty("IsActive")?.SetValue(entity, false);
            return dbSet.Update(entity).State;
        }

        public virtual EntityState HardDelete(T entity)
        {
            return dbSet.Remove(entity).State;
        }
        public virtual EntityState Update(T entity)
        {
            return dbSet.Update(entity).State;
        }
    }
}
