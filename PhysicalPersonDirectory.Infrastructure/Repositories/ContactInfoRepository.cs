using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Data;
using PhysicalPersonDirectory.Infrastructure.Repositories.Base;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Infrastructure.Repositories
{
    public class ContactInfoRepository : ContactRepository<ContactInfo>, IContactInfoRepository
    {

        public ContactInfoRepository(PersonAppDbContext context) : base(context)
        {

        }

        public async Task<ContactInfo> GetContactInfoById(int id)
        {
            return await dbset.FindAsync(id);
        }

        public Task<bool> RemoveContactInfo(ContactInfo contact)
        {
            dbset.Remove(contact);
            return Task.FromResult(true);
        }
    }
}
