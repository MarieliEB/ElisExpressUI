using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ElisExpress.Models;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElisExpress.Repositories
{
    public class RepositorioProductos
    {
        //public IList<Producto> Productos = new List<Producto>
        //{
        //    new Producto
        //    {
        //        Id = 875,
        //        Descripcion = "Tablet para niños, con estuche anticaidas",
        //        Nombre = "Tablet para niños",
        //        Precio = 90000
        //    },

        //    new Producto
        //    {
        //        Id = 239,
        //        Descripcion = "Botella especial antifluidos, especial para llevar en el bolso",
        //        Nombre = "Botella antifluidos",
        //        Precio = 8500
        //    },

        //    new Producto
        //    {
        //        Id = 942,
        //        Descripcion = "Crema facial con protector solar",
        //        Nombre = "Crema rejuvenecedora",
        //        Precio = 25000
        //    }
        //};

        public List<Producto> ObtenerProductos()
        {
            var productos = new List<Producto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/productos");
                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var productosJson = readTask.Result;
                    productos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Producto>>(productosJson);
                }
                return productos;
            }
        }
    }
}
