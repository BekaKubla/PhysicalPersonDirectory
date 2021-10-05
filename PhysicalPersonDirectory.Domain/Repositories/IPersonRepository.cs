using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.Repositories.Base;

namespace PhysicalPersonDirectory.Domain.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
