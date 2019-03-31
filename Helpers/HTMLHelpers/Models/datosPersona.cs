using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class datosPersona
    {
        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Range(15,99)]
        public int Edad { get; set; }

        public string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Correo  { get; set; }

        [Display(Name ="Genero")]
        public Genero genero { get; set; }

        [Display(Name ="Estado Civil")]
        public string EstadoCivil { get; set; }

        public string[] Hobbys { get; set; }

    }

    public enum Genero
    {
        Masculino,
        Femenino
    }

}