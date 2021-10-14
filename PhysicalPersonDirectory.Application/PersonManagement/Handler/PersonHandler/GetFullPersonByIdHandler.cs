using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class GetFullPersonByIdHandler : IRequestHandler<GetFullPersonByIdQuery, Person>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetFullPersonByIdHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Person> Handle(GetFullPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Persons.GetFullPersonById(request.Id);
        }
    }
}
