using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Query.ContactQuery;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.ContactHandler
{
    public class GetContactByIdHandler : IRequestHandler<GetContactByIdQuery, ContactInfo>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetContactByIdHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<ContactInfo> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Contacts.GetContactById(request.Id);
        }


        //public async Task<ContactInfo> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        //{
        //    return await unitOfWork.Contacts.GetContactById(request.Id);
        //}
    }
}
