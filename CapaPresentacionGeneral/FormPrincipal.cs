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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
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
    }
}
