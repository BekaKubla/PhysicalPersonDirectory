using MediatR;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Domain.IConfiguration;
using System.Threading;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Application.PersonManagement.Handler.PersonHandler
{
    public class RemovePersonHandler : IRequestHandler<RemovePersonCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public RemovePersonHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(RemovePersonCommand request, CancellationToken cancellationToken)
        {
            await unitOfWork.Persons.Remove(request.Id);
            await unitOfWork.ComplateAsync();
            return true;
        }
    }
}
