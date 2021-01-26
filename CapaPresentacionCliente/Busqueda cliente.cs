using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocioCliente;
using LogicaModeloCliente;

namespace CapaPresentacionCliente
{
    public partial class Busqueda_cliente : Form
    {
        public Busqueda_cliente(Cliente c)
        {
            InitializeComponent();
            this.control_datos_cliente1.DNI_readOnly(true);
            this.control_datos_cliente1.nombre_readOnly(true);
            this.control_datos_cliente1.tfno_readOnly(true);
            this.control_datos_cliente1.rbA_Enabled(false);
            this.control_datos_cliente1.rbB_Enabled(false);
            this.control_datos_cliente1.rbC_Enabled(false);

            Cliente clBuscado = LNCliente.readCliente(c);

            this.control_datos_cliente1.setDNI(clBuscado.getDNI);
            this.control_datos_cliente1.setNombre(clBuscado.getNombre);
            this.control_datos_cliente1.setCategoria(clBuscado.getcategoria);
            this.control_datos_cliente1.setTfno(clBuscado.getTlfno.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
