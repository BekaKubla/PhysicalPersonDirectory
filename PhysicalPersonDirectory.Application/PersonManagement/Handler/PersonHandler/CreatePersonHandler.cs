using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreatePersonHandler(IUnitOfWork unitofwork)
        {
            this.unitOfWork = unitofwork;
        }

        public async Task<bool> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            await unitOfWork.Persons.Create(request.Person);
            await unitOfWork.ComplateAsync();
            return true;
        }
    }
}
