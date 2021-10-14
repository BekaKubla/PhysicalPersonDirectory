using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Domain.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T> Create(T entity);
        Task<bool> Remove(T entity);
    }
}
