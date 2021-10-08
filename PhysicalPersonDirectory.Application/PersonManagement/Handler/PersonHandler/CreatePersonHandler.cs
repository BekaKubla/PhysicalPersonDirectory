using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Domain.Entities;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, Person>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreatePersonHandler(IUnitOfWork unitofwork)
        {
            this.unitOfWork = unitofwork;
        }

        public async Task<Person> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            await unitOfWork.Persons.Create(request.person);
            await unitOfWork.ComplateAsync();
            return request.person;
            
        }
    }
}
