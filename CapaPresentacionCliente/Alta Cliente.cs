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

namespace CapaPresentacionCliente
{
    public partial class Alta_Cliente : Form
    {
        public Alta_Cliente()
        {
            InitializeComponent();
            this.control_datos_cliente1.DNI_readOnly(true);
            //if(this.control_datos_cliente1.)
            Cliente c = new Cliente(this.control_datos_cliente1.getDNI(), this.control_datos_cliente1.getNombre(), this.control_datos_cliente1.getCategoria(),  int.Parse(this.control_datos_cliente1.getTelefono()));
        }
    }
}
