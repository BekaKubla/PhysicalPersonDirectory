using MediatR;
using PhysicalPersonDirectory.Domain.Entities;
using System.Collections.Generic;

namespace PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand
{
    public class GetPersonsCommand : IRequest<IEnumerable<Person>>
    {
    }
}
