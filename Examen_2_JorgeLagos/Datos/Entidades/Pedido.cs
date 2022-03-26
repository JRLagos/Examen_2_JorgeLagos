using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public string IdProducto { get; set; }

        public string NombreCliente { get; set; }

        public int Cantidad { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Isv { get; set; }

        public decimal TotalPagar { get; set; }

        public Pedido()
        {
        }

        public Pedido(int idPedido, string idProducto, string nombreCliente, int cantidad, decimal subTotal, decimal isv, decimal totalPagar)
        {
            IdPedido = idPedido;
            IdProducto = idProducto;
            NombreCliente = nombreCliente;
            Cantidad = cantidad;
            SubTotal = subTotal;
            Isv = isv;
            TotalPagar = totalPagar;
        }
    }
}
