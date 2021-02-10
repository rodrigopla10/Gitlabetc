using GitlabetcAPI.Data;
using GitlabetcAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitlabetcAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;


        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public List<Cliente> GetListaClientes()
        {
            return _clienteRepository.ListaClientes();
        }

        [HttpPost]
        public IActionResult CrearCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("No es un modelo valido");

                _clienteRepository.InsertarCliente(cliente);
            }
            catch (Exception)
            {
                return BadRequest("Fallo al momento de insertar al cliente");
            }

            return Ok();
        }

    }
}
