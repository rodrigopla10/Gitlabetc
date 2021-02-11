using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitlabetcClient.Models
{
    public class ClienteData
    {
        [Display(Name = "ID cliente")]
        public int idCliente { get; set; }

        [Required(ErrorMessage = "Favor introduzca un nombre")]
        [Display(Name = "Primer Nombre")]
        public string primerNombre { get; set; }

        [Required(ErrorMessage = "Favor introduzca un apellido")]
        [Display(Name = "Apellido")]
        public string primerApellido { get; set; }

        [Required(ErrorMessage = "Introduzca una edad")]
        [Display(Name = "Edad")]
        public int edad { get; set; }

        [Display(Name = "Fecha creacion")]
        public DateTime fechaCreacion { get; set; }
    }
}
