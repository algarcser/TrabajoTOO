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
        /// <summary>
        /// Contructor del form
        /// </summary>
        /// <param name="c"></param>
        public Busqueda_cliente(Cliente c)
        {
            InitializeComponent();

            //Se ponen los controles a solo lectura y se introducen los datos de un cliente que se pasa por parametro

            this.control_alternativo_datos_cliente1.DNI_readOnly(true);
            this.control_alternativo_datos_cliente1.nombre_readOnly(true);
            this.control_alternativo_datos_cliente1.apellidos_readOnly(true);
            this.control_alternativo_datos_cliente1.tfno_readOnly(true);
            this.control_alternativo_datos_cliente1.rbA_Enabled(false);
            this.control_alternativo_datos_cliente1.rbB_Enabled(false);
            this.control_alternativo_datos_cliente1.rbC_Enabled(false);

            Cliente clBuscado = LNCliente.readCliente(c);

            this.control_alternativo_datos_cliente1.setDNI(clBuscado.getDNI);
            this.control_alternativo_datos_cliente1.setNombre(clBuscado.getNombre);
            this.control_alternativo_datos_cliente1.setApellidos(clBuscado.getApellidos);
            this.control_alternativo_datos_cliente1.setCategoria(clBuscado.getcategoria);
            this.control_alternativo_datos_cliente1.setTfno(clBuscado.getTlfno.ToString());


        }

        /// <summary>
        ///  Accion que ocurre al hacer click sobre el boton aceptar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
