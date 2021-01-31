using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacionGeneral
{
    /// <summary>
    /// Formualrio que te permite acceder a la aplicación por medio de un Login, en este caso:
    /// Usuario:    admin 
    /// Contraseña: admin
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que permite mostrar la contraseña que has escrito.
        /// </summary>
        private void cbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbMostrarContraseña.Checked == true)
            {
                this.tbContraseña.UseSystemPasswordChar = false;
            } else
            {
                this.tbContraseña.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Evento que permite acceder a la aplicación si has usado un usuario y contraseña adecuados, si no te avisa de ello.
        /// </summary>
        private void btEntrar_Click(object sender, EventArgs e)
        {
            if ((this.tbContraseña.Text == "admin") && (this.tbUsuario.Text == "admin"))
            {
                Form nuevo = new FormPrincipal(this.tbUsuario.Text);
                this.Owner = nuevo;
                this.Hide();
                nuevo.Show();
            }else
            {
                MessageBox.Show("Introduzca el usuario y contraseña de nuevo correctamente.", "Usuario y/o contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
