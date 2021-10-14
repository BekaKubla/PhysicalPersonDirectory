using PhysicalPersonDirectory.Domain.Repositories;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Domain.IConfiguration
{
    public interface IUnitOfWork
    {
        IPersonRepository Persons { get; }
        Task ComplateAsync();
    }
}
