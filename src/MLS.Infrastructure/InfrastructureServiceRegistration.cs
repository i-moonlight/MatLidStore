using Microsoft.Extensions.DependencyInjection;
using MLS.Application.Contracts.Logging;
using MLS.Infrastructure.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}