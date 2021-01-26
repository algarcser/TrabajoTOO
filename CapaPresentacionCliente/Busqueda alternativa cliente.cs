using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloCliente;
using LogicaNegocioCliente;

namespace CapaPresentacionCliente
{
    public partial class Busqueda_alternativa_cliente : Form
    {
        public Busqueda_alternativa_cliente(Cliente c)
        {
            InitializeComponent();

            Cliente clBuscado = LNCliente.readCliente(c);

            this.textBoxNombre.Text = clBuscado.getNombre;
            //this.textBoxApellidos.Text = clBuscado.getApellidos;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
