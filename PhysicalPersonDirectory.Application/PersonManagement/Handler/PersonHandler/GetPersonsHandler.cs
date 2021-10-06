using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class GetPersonsHandler : IRequestHandler<GetPersonsQuery, IEnumerable<Person>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPersonsHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Person>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Persons.GetAll();
        }
    }
}
