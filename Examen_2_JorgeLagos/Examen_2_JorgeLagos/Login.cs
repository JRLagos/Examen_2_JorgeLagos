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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(CodigoTextBox.Text, ClaveTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
