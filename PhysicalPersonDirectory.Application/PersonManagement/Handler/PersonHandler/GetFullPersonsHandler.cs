using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class GetFullPersonsHandler : IRequestHandler<GetFullPersonQuery, IEnumerable<Person>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetFullPersonsHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Person>> Handle(GetFullPersonQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Persons.GetFullPersons();
        }
    }
}
