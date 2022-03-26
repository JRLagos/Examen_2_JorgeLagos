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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;

        ProductoDA productoDA = new ProductoDA();
        Producto user = new Producto();

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();

        }
        private void HabilitarControles()
        {
            IdProductoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
            ModificarButton.Enabled = false;

        }
        private void DesabilitarControles()
        {
            IdProductoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
            ModificarButton.Enabled = true;

        }
        private void LimpiarControles()
        {
            IdProductoTextBox.Clear();
            NombreTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                IdProductoTextBox.Text = ProductosDataGridView.CurrentRow.Cells["IdProducto"].Value.ToString();
                NombreTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                PrecioTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciaTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

                HabilitarControles();
                IdProductoTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            user.IdProducto = IdProductoTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Precio = Convert.ToDecimal(PrecioTextBox.Text);
            user.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);

            if (operacion == "Nuevo")
            {
                bool inserto = productoDA.InsertarProducto(user);

                if (inserto)
                {
                    MessageBox.Show("Producto Agregado");
                    ListarProductos();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Producto No Agregado");
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = productoDA.ModificarProducto(user);
                if (modifico)
                {
                    MessageBox.Show("Producto Modificacdo");
                    ListarProductos();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Producto no se pudo Modificar");
                }

            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ProductosDataGridView.DataSource = productoDA.ListarProductos();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(ProductosDataGridView.CurrentRow.Cells["IdProducto"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Producto Eliminado");
                    ListarProductos();
                }
                else
                {
                    MessageBox.Show("Producto no se pudo Eliminar");
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
