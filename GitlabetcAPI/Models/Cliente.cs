using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitlabetcAPI.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        public string primerNombre { get; set; }

        public string primerApellido { get; set; }

        public int edad { get; set; }

        public DateTime fechaCreacion { get; set; }

    }
}
