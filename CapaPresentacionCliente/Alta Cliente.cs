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
    public partial class Alta_Cliente : Form
    {
        public Alta_Cliente(Cliente c)
        {
            InitializeComponent();
            this.control_datos_cliente1.DNI_readOnly(true);
            this.control_datos_cliente1.setDNI(c.getDNI());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.control_datos_cliente1.getNombre() == "") || (this.control_datos_cliente1.getTelefono() == "") || ((!this.control_datos_cliente1.getAchecked()) && (!this.control_datos_cliente1.getBchecked()) && (!this.control_datos_cliente1.getCchecked())))
            {
                MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente c = new Cliente(this.control_datos_cliente1.getDNI(), this.control_datos_cliente1.getNombre(), this.control_datos_cliente1.getCategoria(), int.Parse(this.control_datos_cliente1.getTelefono()));
                LNCliente.altaCliente(c);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
