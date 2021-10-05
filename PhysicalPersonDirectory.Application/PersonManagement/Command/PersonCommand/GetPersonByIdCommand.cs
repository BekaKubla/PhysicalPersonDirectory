using MediatR;
using PhysicalPersonDirectory.Domain.Entities;

namespace PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand
{
    public class GetPersonByIdCommand : IRequest<Person>
    {
        public int Id { get; set; }
    }
}
