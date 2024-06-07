using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc4api.Models;

namespace pc4api.Service
{
    public class Productos
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
        new Producto { ProductoId = 1, NombreProducto = "Llantas Michelin" },
        new Producto { ProductoId = 2, NombreProducto = "Llantas Bridgestone" },
        new Producto { ProductoId = 3, NombreProducto = "Llantas Goodyear" },
        new Producto { ProductoId = 4, NombreProducto = "Llantas Pirelli" },
        new Producto { ProductoId = 5, NombreProducto = "Llantas Continental" },
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
        new Producto { ProductoId = 1, NombreProducto = "Llantas Michelin" },
        new Producto { ProductoId = 2, NombreProducto = "Llantas Bridgestone" },
        new Producto { ProductoId = 3, NombreProducto = "Llantas Goodyear" },
        new Producto { ProductoId = 4, NombreProducto = "Llantas Pirelli" },
        new Producto { ProductoId = 5, NombreProducto = "Llantas Continental" },
        new Producto { ProductoId = 6, NombreProducto = "Llantas Dunlop" },
        new Producto { ProductoId = 7, NombreProducto = "Llantas Firestone" },
        new Producto { ProductoId = 8, NombreProducto = "Llantas Yokohama" },
        new Producto { ProductoId = 9, NombreProducto = "Llantas Hankook" },
        new Producto { ProductoId = 10, NombreProducto = "Llantas Toyo Tires" }
            };
            return result;
        }


    }
}