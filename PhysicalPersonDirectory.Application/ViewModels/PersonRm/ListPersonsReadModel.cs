using PhysicalPersonDirectory.Domain.Entities;
using System.Collections.Generic;

namespace PhysicalPersonDirectory.Application.ViewModels.PersonRm
{
    public class ListPersonsReadModel
    {
        public IEnumerable<Person> persons { get; set; }
    }
}
