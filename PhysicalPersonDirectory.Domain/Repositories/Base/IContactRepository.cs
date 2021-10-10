using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Domain.Repositories.Base
{
    public interface IContactRepository<T> where T : class
    {
        Task<T> GetContactById(int id);
        Task<bool> RemoveContact(T entity);
    }
}
