using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitlabetcClient.Models
{
    public class ClienteData
    {
        public int idCliente { get; set; }

        public string primerNombre { get; set; }

        public string primerApellido { get; set; }

        public int edad { get; set; }

        public DateTime fechaCreacion { get; set; }
    }
}
