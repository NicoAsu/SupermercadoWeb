using System;
using System.Collections.Generic;

#nullable disable

namespace SupermercadoWeb.Models
{
    public partial class Carrito
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductoId { get; set; }
    }
}
