using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NoteBook.DataAccess.Repository
{
    public class BaseRepo<T> : IDisposable, IRepo<T> where T:class 
    {
        private readonly DbSet<T> _table;

        public BaseRepo()
        {
            Context = new ApplicationContext();
            _table = Context.Set<T>();
        }

        protected ApplicationContext Context { get; }

        public int AddAsync(T entity)
        {
            _table.AddAsync(entity);
            return SaveChangesAsync().Result;
        }
        public int AddRangeAsync(IList<T> entities)
        {
            _table.AddRangeAsync(entities);
            return SaveChangesAsync().Result;
        }
        public int Delete(int id)
        {
            var entity = GetOneAsync(id);
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync().Result;
        }

        public int Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync().Result;
        }

        public void Dispose()
        {
            Context?.Dispose();
        }

        public virtual async Task<List<T>> GetAllAsync() => await _table.ToListAsync();

        public async Task<T> GetOneAsync(int? id) => await _table.FindAsync(id);

        public int Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync().Result;
        }

        public async Task<int> SaveChangesAsync() => await Context.SaveChangesAsync();
    }
}

