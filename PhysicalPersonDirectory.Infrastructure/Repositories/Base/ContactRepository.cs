using Microsoft.EntityFrameworkCore;
using PhysicalPersonDirectory.Domain.Repositories.Base;
using PhysicalPersonDirectory.Infrastructure.Data;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Infrastructure.Repositories.Base
{
    public class ContactRepository<T> : IContactRepository<T> where T : class
    {
        protected PersonAppDbContext context;
        protected DbSet<T> dbset;

        public ContactRepository(PersonAppDbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();

        }



        public async Task<T> GetContactById(int id)
        {
            return await dbset.FindAsync(id);

        }

        public Task<bool> RemoveContact(T entity)
        {
            dbset.Remove(entity);
            return Task.FromResult(true);
        }
    }
}
