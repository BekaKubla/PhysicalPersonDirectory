﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
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
        public async Task<IActionResult> Create(CreatePersonCommand createPersonCommand)
        {

            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var person = await mediator.Send(new CreatePersonCommand(createPersonCommand.person));
            var personReadModel = new PersonReadModel(person);
            return Ok(personReadModel);
        }


        //[HttpGet("Persons")]
        //public async Task<IActionResult> GetPersons()
        //{
        //    var person = await mediator.Send(new GetPersonsQuery());


        //}


        [HttpGet("person/{id}")]
        public async Task<IActionResult> GetPersonById(int id)
        {

            var person = await mediator.Send(new GetPersonByIdQuery() { Id = id });
            if (person != null)
            {
                var personReadModel = new PersonReadModel(person);
                return Ok(personReadModel);
            }
            return NotFound();
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> RemovePerson(int id)
        {
            var person = await mediator.Send(new GetPersonByIdQuery() { Id = id });
            if (person != null)
            {
                return Ok(await mediator.Send(new RemovePersonCommand(person)));
            }
            return NotFound();

        }
    }
}
