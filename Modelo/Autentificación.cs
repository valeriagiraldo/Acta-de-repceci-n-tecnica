using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Autentificaci�n")]
    public class Autentificaci�n
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string? usuario { get; set; }
        public int? contrase�a { get; set; }
        public int? funcion { get; set; }

        public int nivel { get; set; }
    }
}
