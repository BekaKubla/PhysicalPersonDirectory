using MediatR;
using PhysicalPersonDirectory.Domain.Entities;

namespace PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand
{
    public record CreatePersonCommand(Person person) : IRequest<Person>
    {

    }
}
