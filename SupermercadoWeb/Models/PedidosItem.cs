using System;
using System.Collections.Generic;

#nullable disable

namespace SupermercadoWeb.Models
{
    public partial class PedidosItem
    {
        public int IdPedido { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string PrecioUnidad { get; set; }
    }
}
