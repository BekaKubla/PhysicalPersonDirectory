using Microsoft.EntityFrameworkCore;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Data;
using PhysicalPersonDirectory.Infrastructure.Repositories.Base;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Infrastructure.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(PersonAppDbContext context) : base(context)
        {

        }
        public async Task<bool> CreatePerson(Person person)
        {

            if (person == null)
            {
                return false;
            }
            await dbset.AddAsync(person);
            return true;
        }
        public async Task<bool> RemovePerson(int id)
        {
            var existPerson = await dbset.Where(e => e.Id == id).FirstOrDefaultAsync();
            if (existPerson != null)
            {
                dbset.Remove(existPerson);
                return true;
            }
            return false;
        }
        public async Task<Person> GetPersonById(int id)
        {
            return await dbset.FindAsync(id); ;
        }

    }
}
