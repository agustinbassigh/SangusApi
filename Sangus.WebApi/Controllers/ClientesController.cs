using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public ClientesController(Repository<Cliente> repository)
        {
            // ClientesService clientesService
            _clientesService = new ClientesService(repository);
        }

        [HttpGet]
        public Task<List<Cliente>> Get()
        {
            return  _clientesService.GetClientes();
        }

    }
}