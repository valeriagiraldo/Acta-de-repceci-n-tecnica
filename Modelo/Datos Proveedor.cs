using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Datos_proveedor")]
    public class Datos_Proveedor
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public int nITproveedor { get; set; }
        public string? nombreProveedor { get; set; }
        public string? nombre { get; set; }
        public int celular { get; set; }
    }
}
