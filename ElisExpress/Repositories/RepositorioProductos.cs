using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElisExpress.Models;

namespace ElisExpress.Repositories
{
    public class RepositorioProductos
    {
        public IList<Producto> Productos = new List<Producto>
        {
            new Producto
            {
                Id = 875,
                Descripcion = "Tablet para niños, con estuche anticaidas",
                Nombre = "Tablet para niños",
                Precio = 90000
            },

            new Producto
            {
                Id = 239,
                Descripcion = "Botella especial antifluidos, especial para llevar en el bolso",
                Nombre = "Botella antifluidos",
                Precio = 8500
            },

            new Producto
            {
                Id = 942,
                Descripcion = "Crema facial con protector solar",
                Nombre = "Crema rejuvenecedora",
                Precio = 25000
            }
        };
    }
}
