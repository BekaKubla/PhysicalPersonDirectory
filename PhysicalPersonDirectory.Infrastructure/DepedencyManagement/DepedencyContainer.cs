using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PhysicalPersonDirectory.Application.PersonManagement.Command.PersonCommand;
using PhysicalPersonDirectory.Domain.IConfiguration;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Data;
using PhysicalPersonDirectory.Infrastructure.Repositories;

namespace PhysicalPersonDirectory.Infrastructure.DepedencyManagement
{
    public class DepedencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IPersonRepository, PersonRepository>();


            services.AddMediatR(typeof(GetPersonsCommand).Assembly);
        }
    }
}
