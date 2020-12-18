using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities
{
    public class Factura : BaseEntity
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("idCarrito")]
        public int IdCarrito { get; set; }
        [JsonPropertyName("nombreUsuario")]
        public string NombreUsuario { get; set; }
        [JsonPropertyName("correoUsuario")]
        public string CorreoUsuario { get; set; }
        [JsonPropertyName("telefonoUsuario")]
        public int TelefonoUsuario { get; set; }
        [JsonPropertyName("metodoPago")]
        public string MetodoPago { get; set; }
        [JsonPropertyName("totalPago")]
        public double TotalPago { get; set; }

        public Factura() { }
    }
}
