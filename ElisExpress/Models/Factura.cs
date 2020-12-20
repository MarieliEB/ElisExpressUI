using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElisExpress.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int IdCarrito { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public string MetodoPago { get; set; }
        public double TotalPagp { get; set; }
    }
}
