using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Core.EFContext;
using ExpenseTracker.Core.Repositories.Interfaces;
using ExpenseTracker.Models.Dto;
using System.Data.SqlClient;

namespace ExpenseTracker.Core.Repositories.Base
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

        public IQueryable<T> GetAll<TParamater>(IList<Expression<Func<T, TParamater>>> includeProperties)
        {
            var query = dbSet.AsQueryable();
            foreach (var include in includeProperties)
            {
                query = query.Include(include);
            }

            return query.AsNoTracking();
        }

        public async Task<IEnumerable<T>> GetAllAsync<TParamater>(IList<Expression<Func<T, TParamater>>> includeProperties)
        {
            var query = dbSet.AsQueryable();
            foreach (var include in includeProperties)
            {
                query = query.Include(include);
            }

            return await query.AsNoTracking().ToListAsync();
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

        public async Task<List<TransactionByYear>> GetTransactionByYear(int year)
        {
            return await _context.Set<TransactionByYear>()
                      .FromSqlRaw("EXEC GetTransactionsByYear {0}", year)
                      .ToListAsync();
        }

        public async Task<List<TransactionByMonth>> GetTransactionByMonth(int year, int month, int subCategoryId)
        {
            return await _context.Set<TransactionByMonth>()
                      .FromSqlRaw("EXEC GetTransactionsByMonth {0}, {1}, {2}", year, month, subCategoryId)
                      .ToListAsync();
        }

        public async Task<List<BankByYear>> GetBankSummary(int year)
        {
            return await _context.Set<BankByYear>()
                      .FromSqlRaw("EXEC GetBanksSummaryForYear {0}", year)
                      .ToListAsync();
        }
    }
}
