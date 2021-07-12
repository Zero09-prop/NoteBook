using System;
using System.Collections.Generic;
using System.Linq;
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

        public int Add(T entity)
        {
            _table.Add(entity);
            return SaveChanges();
        }

        public int Delete(int id)
        {
            var entity = GetOne(id);
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public int Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }

        public virtual List<T> GetAll() => _table.ToList();

        public T GetOne(int? id) => _table.Find(id);

        public int Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        internal int SaveChanges() => Context.SaveChanges();
    }
}

