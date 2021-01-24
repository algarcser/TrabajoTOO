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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if ((this.tbContraseña.Text == "admin") && (this.tbUsuario.Text == "admin"))
            {
                Form nuevo = new FormPrincipal(this.tbUsuario.Text);
                this.Hide();
                nuevo.Show();
                this.Close();
            }else
            {
                MessageBox.Show("Introduzca el usuario y contraseña de nuevo correctamente.", "Usuario y/o contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
