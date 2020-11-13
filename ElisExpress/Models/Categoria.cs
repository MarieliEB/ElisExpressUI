﻿using System.Collections.Generic;

namespace ElisExpress.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Producto> Productos { get; set; }
    }
}