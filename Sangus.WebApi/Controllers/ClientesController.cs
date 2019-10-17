using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sangus.Data;
using Sangus.Model.Clientes;
using Sangus.Services;

namespace Sangus.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClientesService _clientesService;

        public ClientesController()
        {
            // ClientesService clientesService

            DbContextOptionsBuilder<SangusDbContext>   optionsBuilder = new DbContextOptionsBuilder<SangusDbContext>();
            optionsBuilder.UseInMemoryDatabase("connection string here");
 
            SangusDbContext sangusDbContext = new SangusDbContext( optionsBuilder.Options);

            Repository<Cliente> repository = new Repository<Cliente>(sangusDbContext);
            _clientesService = new ClientesService(repository);
        }

        [HttpGet]
        public Task<List<Cliente>> Get()
        {
            return  _clientesService.GetClientes();
        }

    }
}