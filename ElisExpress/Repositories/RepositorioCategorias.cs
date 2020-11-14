using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElisExpress.Models;

namespace ElisExpress.Repositories
{
    public class RepositorioCategorias
    {
        public IList<Categoria> Categorias = new List<Categoria>
        {
            new Categoria
            {
                Id = 1234,
                Descripcion = "Materiales para trabajar en su jardín",
                Nombre = "Jardineria",
                Productos = new List<Producto>
                {
                    new Producto
                    {
                        Nombre = "Pala",
                        Descripcion = "Pala",
                        Id = 5432,
                        Precio = 3000
                    }
                }
            },

            new Categoria
            {
                Id = 5678,
                Descripcion = "Moda infantil",
                Nombre = "Moda infantil",
                Productos = new List<Producto>
                {
                    new Producto
                    {
                        Nombre = "Vestido de niña",
                        Descripcion = "Vestido de niña talla 4t, 6t, 8t",
                        Id = 1254,
                        Precio = 17000
                    }
                }
            },

            new Categoria
            {
                Id = 7890,
                Descripcion = "Zapateria",
                Nombre = "Zapateria",
                Productos = new List<Producto>
                {
                    new Producto
                    {
                        Nombre = "Zapatos para hombre",
                        Descripcion = "Zapatos para hombre color negro, tallas 39, 40, 41, 42",
                        Id = 7895,
                        Precio = 25000
                    }
                }
            }
        };
    }
}
