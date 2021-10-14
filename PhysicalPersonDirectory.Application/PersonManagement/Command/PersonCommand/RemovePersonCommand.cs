using MediatR;
using PhysicalPersonDirectory.Domain.Entities;

namespace PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand
{
    public record RemovePersonCommand(Person person) : IRequest<bool>
    {

    }
}
