using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Application.ViewModels.PersonVm;
using PhysicalPersonDirectory.Domain.Entities;
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
        public async Task<IActionResult> Create(Person person)
        {

            if (ModelState.IsValid)
            {
                await mediator.Send(new CreatePersonCommand(person));
                return Ok();
            }

            return NotFound();
        }
        //[HttpGet("Persons")]
        //public async Task<IEnumerable<PersonReadModel>> GetPersons()
        //{

        //}
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
            return Ok(await mediator.Send(new RemovePersonCommand() { Id = id }));
        }
    }
}
