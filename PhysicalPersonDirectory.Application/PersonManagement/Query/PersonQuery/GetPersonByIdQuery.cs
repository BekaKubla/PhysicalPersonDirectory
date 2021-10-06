using MediatR;
using PhysicalPersonDirectory.Domain.Entities;

namespace PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery
{
    public class GetPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }
    }
}
