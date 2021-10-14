using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Domain.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetFullPersonById(int id);
        Task<List<Person>> GetFullPersons();
    }
}
