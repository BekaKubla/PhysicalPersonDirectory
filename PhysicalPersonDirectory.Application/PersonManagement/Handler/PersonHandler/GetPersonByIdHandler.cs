using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPersonByIdHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Persons.GetById(request.Id);
        }
    }
}
