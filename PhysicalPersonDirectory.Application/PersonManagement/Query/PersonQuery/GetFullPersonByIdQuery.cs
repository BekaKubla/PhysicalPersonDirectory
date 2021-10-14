using MediatR;
using PhysicalPersonDirectory.Domain.Entities;

namespace PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery
{
    public class GetFullPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }
    }
}
