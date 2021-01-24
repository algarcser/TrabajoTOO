using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacionVehiculo;

namespace CapaPresentacionGeneral
{
    public partial class FormPrincipal : Form
    {
        private string usuario;
        public FormPrincipal(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            
        }

        private void tsmiAltaCliente_Click(object sender, EventArgs e)
        {
            Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("alta");
        }

        private void tsmiBajaCliente_Click(object sender, EventArgs e)
        {

        }

        private void tsmiBusquedaCliente_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAltaVehiculo_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Alta );
            obtenerNBastidor.Show();
        }

        private void tsmiBusquedaVehiculo_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Ver );
            obtenerNBastidor.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Baja );
            obtenerNBastidor.Show();
        }
    }
}
