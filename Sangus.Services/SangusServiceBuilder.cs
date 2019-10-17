using Microsoft.Extensions.DependencyInjection;
using Sangus.Data;
using Sangus.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sangus.Services
{
    public class SangusServiceBuilder
    {
        public IServiceCollection Services { get; }

        public SangusServiceBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public SangusServiceBuilder AddSangusServices()
        {
            // Falta agregar el dbcontext

            // Aca se agregan todos los servicios necesarios
            Services.AddSingleton<IRepository<Cliente>, Repository<Cliente>>();

            return this;

        }

    }
}