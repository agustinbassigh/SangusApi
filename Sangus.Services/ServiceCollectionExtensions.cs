using Sangus.Data;
using Sangus.Model.Clientes;
using Sangus.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static SangusServiceBuilder AddSangusServices(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Cliente>, Repository<Cliente>>();

            return new SangusServiceBuilder(services);
        }
    }
}
