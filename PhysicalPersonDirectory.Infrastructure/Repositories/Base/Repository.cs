using Microsoft.EntityFrameworkCore;
using PhysicalPersonDirectory.Domain.Repositories.Base;
using PhysicalPersonDirectory.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected PersonAppDbContext context;
        protected DbSet<T> dbset;

        public Repository(PersonAppDbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();

        }


        public async Task<bool> Create(T entity)
        {
            await dbset.AddAsync(entity);
            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbset.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var existPerson = await dbset.FindAsync(id);
            if (existPerson == null)
            {
                return null;
            }
            return existPerson;
        }

        public async Task<bool> Remove(int id)
        {
            var existPerson = await dbset.FindAsync(id);
            if (existPerson != null)
            {
                dbset.Remove(existPerson);
                return true;
            }
            return false;
        }
    }
}
