using System;
using System.Collections.Generic;

#nullable disable

namespace SupermercadoWeb.Models
{
    public partial class Slider
    {
        public int Id { get; set; }
        public byte[] Imagen { get; set; }
        public string VideoUrl { get; set; }
    }
}
