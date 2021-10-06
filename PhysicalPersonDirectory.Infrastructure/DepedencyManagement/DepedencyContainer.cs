using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PhysicalPersonDirectory.Application.PersonManagement.Query.PersonQuery;
using PhysicalPersonDirectory.Domain.IConfiguration;
using PhysicalPersonDirectory.Domain.Repositories;
using PhysicalPersonDirectory.Infrastructure.Data;
using PhysicalPersonDirectory.Infrastructure.Repositories;
using System.Reflection;

namespace PhysicalPersonDirectory.Infrastructure.DepedencyManagement
{
    public class DepedencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IPersonRepository, PersonRepository>();


            services.AddMediatR(typeof(GetPersonsQuery).Assembly);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
