
using System;

namespace Entidades
{
    public class IngresodelActa
    {
        public string? empresaAbastece { get; set; }
        public string? consecutivoFactura { get; set; }
        public string? producto { get; set; }
        public string? registroSanitario { get; set; }
        public DateTime lote { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string? laboratorio { get; }
        public string? marca { get; set; }
        public int unidades { get; set; }
        public bool rótuloSecundario { get; set; }
        public bool defectos { get; set; }
        public bool estado { get; set; }
        public bool rótuloPrimario { get; set; }
        public bool actadelQuímicofarmacéutico { get; set; }
       
    }
}
