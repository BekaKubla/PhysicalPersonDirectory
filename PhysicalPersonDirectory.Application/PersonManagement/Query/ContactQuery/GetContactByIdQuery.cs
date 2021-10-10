using MediatR;
using PhysicalPersonDirectory.Domain.Entities;
using System.Collections.Generic;

namespace PhysicalPersonDirectory.Application.PersonManagement.Query.ContactQuery
{
    public class GetContactByIdQuery : IRequest<ContactInfo>
    {
        public int Id { get; set; }
    }
}
