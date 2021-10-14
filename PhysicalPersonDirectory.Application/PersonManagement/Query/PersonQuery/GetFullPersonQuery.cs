using MediatR;
using PhysicalPersonDirectory.Domain.Entities;
using System.Collections.Generic;

namespace PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery
{
    public record GetFullPersonQuery() : IRequest<IEnumerable<Person>>
    {

    }
}
