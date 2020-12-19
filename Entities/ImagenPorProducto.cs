using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities
{
    public class ImagenPorProducto : BaseEntity
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("valor")]
        public string Valor { get; set; }
        [JsonPropertyName("idProducto")]
        public int IdProducto { get; set; }

        public ImagenPorProducto() { }
    }
}
