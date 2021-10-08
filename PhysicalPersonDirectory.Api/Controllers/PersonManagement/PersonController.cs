using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Application.ViewModels.PersonRm;
using PhysicalPersonDirectory.Application.ViewModels.PersonVm;
using System.Threading.Tasks;

namespace PhysicalPersonDirectory.Api.Controllers.PersonManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreatePersonCommand person)
        {

            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var result = await mediator.Send(new CreatePersonCommand(person.person));
            var personRm = new PersonReadModel(result);
            return Ok(personRm);
        }


        [HttpGet("Persons")]
        public async Task<IActionResult> GetPersons()
        {
            var person = await mediator.Send(new GetPersonsQuery());

            var personRm = new ListPersonsReadModel() { persons = person };

            return Ok(personRm.persons);

        }


        [HttpGet("person/{id}")]
        public async Task<IActionResult> GetPersonById(int id)
        {

            var result = await mediator.Send(new GetPersonByIdQuery() { Id = id });
            if (result != null)
            {
                var personRm = new PersonReadModel(result);
                return Ok(personRm);
            }
            return NotFound();
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> RemovePerson(int id)
        {
            var findPerson = await mediator.Send(new GetPersonByIdQuery() { Id = id });
            if (findPerson != null)
            {
                return Ok(await mediator.Send(new RemovePersonCommand(findPerson)));
            }
            return NotFound();

        }
    }
}
