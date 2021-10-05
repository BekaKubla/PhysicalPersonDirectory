using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Domain.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Create(T entity);
        Task<bool> Remove(int id);
    }
}
