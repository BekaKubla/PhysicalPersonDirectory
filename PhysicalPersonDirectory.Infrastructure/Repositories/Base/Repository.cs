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


        public async Task<T> Create(T entity)
        {
            await dbset.AddAsync(entity);
            return entity;

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbset.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await dbset.FindAsync(id);
        }

        public Task<bool> Remove(T entity)
        {
            dbset.Remove(entity);
            return Task.FromResult(true);
        }
    }
}
