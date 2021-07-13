using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteBook.DataAccess.Repository
{
    public interface IRepo<T>
    {
        int AddAsync(T entity);
        int AddRangeAsync(IList<T> entities);
        int Update(T entity);
        int Delete(int id);
        int Delete(T entity);
        Task<T> GetOneAsync(int? id);
        Task<List<T>> GetAllAsync();

    }
}
