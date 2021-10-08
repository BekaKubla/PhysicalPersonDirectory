using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Data;
using PhysicalPersonDirectory.Infrastructure.Repositories.Base;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Infrastructure.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(PersonAppDbContext context) : base(context)
        {

        }
        public async Task<Person> CreatePerson(Person person)
        {

            await dbset.AddAsync(person);
            return person;

        }
        public async Task<Person> RemovePerson(int id)
        {
            var existPerson = await dbset.FindAsync(id);
            dbset.Remove(existPerson);
            return existPerson;

        }
        public async Task<Person> GetPersonById(int id)
        {
            return await dbset.FindAsync(id); ;
        }

    }
}
