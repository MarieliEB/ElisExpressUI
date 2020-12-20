using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElisExpress.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
       // public string NombreProducto { get; set; }
    }
}
