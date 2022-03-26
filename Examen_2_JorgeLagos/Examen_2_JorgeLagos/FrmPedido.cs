using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2_JorgeLagos
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }
        PedidoDA pedidoDA = new PedidoDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Pedido pedido = new Pedido();
        Producto producto;

       
        decimal subtotal = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal totalpagar = decimal.Zero;

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            ListaPedido();   
        }

        private void ListaPedido()
        {
            PedidosDataGridView.DataSource = pedidoDA.ListarPedido();
        }

        private void NombreProductoTextBox_TextChanged(object sender, EventArgs e)
        {
           // if (IdProductoTextBox == ProductoDA.IdProducto)
            //{

            //}
        }
    }
}
