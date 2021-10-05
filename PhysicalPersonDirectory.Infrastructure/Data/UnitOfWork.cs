using PhysicalPersonDirectory.Domain.IConfiguration;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public readonly PersonAppDbContext context;


        public IPersonRepository Persons { get; private set; }


        public UnitOfWork(PersonAppDbContext context)
        {
            this.context = context;
            Persons = new PersonRepository(context);
        }


        public async Task ComplateAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
