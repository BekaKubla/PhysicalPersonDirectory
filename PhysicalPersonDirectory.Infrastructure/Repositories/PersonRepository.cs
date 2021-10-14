using Microsoft.EntityFrameworkCore;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Data;
using PhysicalPersonDirectory.Infrastructure.Repositories.Base;
using System.Collections.Generic;
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
            await dbset.Include(e => e.ContactInfos).ToListAsync();
            dbset.Remove(existPerson);
            return existPerson;

        }

        public async Task<Person> GetFullPersonById(int id)
        {
            var person = await dbset.FindAsync(id);
            await dbset.Include(e => e.ContactInfos).ToListAsync();
            return person;

        }

        public async Task<List<Person>> GetFullPersons()
        {
            return await dbset.Include(e => e.ContactInfos).ToListAsync();
        }
    }
}
