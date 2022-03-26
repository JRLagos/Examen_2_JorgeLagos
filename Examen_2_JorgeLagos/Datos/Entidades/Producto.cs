using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Producto
    {
        public string IdProducto { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Existencia { get; set; }

        public Producto()
        {
        }

        public Producto(string idProducto, string nombre, decimal precio, int existencia)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
