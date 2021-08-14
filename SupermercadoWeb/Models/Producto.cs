using System;
using System.Collections.Generic;

#nullable disable

namespace SupermercadoWeb.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int CategoriaId { get; set; }
        public byte[] Imagen { get; set; }
    }
}
