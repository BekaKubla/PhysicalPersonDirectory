using MediatR;

namespace PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand
{
    public class RemovePersonCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
