using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("DatosVarios")]
    public class Datos_varios
    {
        [Key]
        public int id { get; set; }
        public string? nombrelaboratorio { get; set; }
        public bool estadodellaboratorio { get; set; }
        public bool estadodelproducto { get; set; }
        public string? nombregenérico { get; set; }
        public string? formaFarmacéutica { get; set; }
        public string? concentracióndelproducto { get; set; }
        public string? duracióndelproducto { get; set; }
        public string? clasificacióndelriesgo { get; set; }
        public string? presentacionproducto  { get; set; }
    }
}
