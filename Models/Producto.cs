using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pc4api.Models
{
    public class Producto
    {
         public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public bool liked;
    }
}