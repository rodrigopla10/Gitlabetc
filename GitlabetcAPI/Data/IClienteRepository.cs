using GitlabetcAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitlabetcAPI.Data
{
    public interface IClienteRepository
    {
        List<Cliente> ListaClientes();

        void InsertarCliente(Cliente cliente);
    }
}
