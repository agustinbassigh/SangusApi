using Sangus.Data;
using Sangus.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sangus.Services
{
    public class ClientesService
    {
        private readonly IRepository<Cliente> clientesRepository;

        public ClientesService(IRepository<Cliente> _clientesRepository)
        {
            clientesRepository = _clientesRepository;
        }

        public Task<List<Cliente>> GetClientes()
        {
            return   clientesRepository.GetAll();

        }

        public Cliente GetCliente(int id)
        {
            return clientesRepository.GetById(id);
        }

    }
}
