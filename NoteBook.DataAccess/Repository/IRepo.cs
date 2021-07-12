using System.Collections.Generic;

namespace NoteBook.DataAccess.Repository
{
    public interface IRepo<T>
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
        int Delete(T entity);
        T GetOne(int? id);
        List<T> GetAll();

    }
}
