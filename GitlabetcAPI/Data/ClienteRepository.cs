using GitlabetcAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitlabetcAPI.Data
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Cliente> ListaClientes()
        {
            try
            {
                return _appDbContext.Cliente.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public void InsertarCliente(Cliente cliente)
        {
            try
            {
                cliente.fechaCreacion = DateTime.Now;

                _appDbContext.Cliente.Add(cliente);
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
