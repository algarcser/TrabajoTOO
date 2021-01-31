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
    public partial class Listado_de_clientes : Form
    {

        BindingSource bindingSource_Clientes;
        List<Cliente> listaOrd;
        
        /// <summary>
        /// Contructor del form
        /// </summary>
        public Listado_de_clientes()
        {
            InitializeComponent();

            // Se vinculan las listBoxes del form a la lista de Clientes de la BD, cada listBox es uno de los campos de un cliente que se desea mostrar

            bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = LNCliente.SELECT_ALL();

            this.listBoxDNI.DataSource = bindingSource_Clientes;
            this.listBoxDNI.SelectionMode = SelectionMode.None;
            this.listBoxDNI.DisplayMember = "getDNI";

            this.listBoxNombre.DataSource = bindingSource_Clientes;
            this.listBoxNombre.SelectionMode = SelectionMode.None;
            this.listBoxNombre.DisplayMember = "getNombre";

            this.listBoxImporte.DataSource = bindingSource_Clientes;
            this.listBoxImporte.SelectionMode = SelectionMode.None;
            this.listBoxImporte.DisplayMember = "importeTotal";

        }

        /// <summary>
        /// Accion que ordena el listado por el DNI al pulsar sobre el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDNI_Click(object sender, EventArgs e)
        {
            // La vinculacion pasa a hacerse sobre una lista ordenada por el DNI

            listaOrd = LNCliente.SELECT_ALL().OrderBy((x) => x.getDNI).ToList();
            bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = listaOrd;

            this.listBoxDNI.DataSource = bindingSource_Clientes;
            this.listBoxDNI.SelectionMode = SelectionMode.None;
            this.listBoxDNI.DisplayMember = "getDNI";

            this.listBoxNombre.DataSource = bindingSource_Clientes;
            this.listBoxNombre.SelectionMode = SelectionMode.None;
            this.listBoxNombre.DisplayMember = "getNombre";

            this.listBoxImporte.DataSource = bindingSource_Clientes;
            this.listBoxImporte.SelectionMode = SelectionMode.None;
            this.listBoxImporte.DisplayMember = "importeTotal";

        }

        /// <summary>
        /// Accion que ordena el listado por el nombre al pulsar sobre el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNombre_Click(object sender, EventArgs e)
        {
            // La vinculacion pasa a hacerse sobre una lista ordenada por el nombre

            listaOrd = LNCliente.SELECT_ALL().OrderBy((x) => x.getNombre).ToList();
            bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = listaOrd;

            this.listBoxDNI.DataSource = bindingSource_Clientes;
            this.listBoxDNI.SelectionMode = SelectionMode.None;
            this.listBoxDNI.DisplayMember = "getDNI";

            this.listBoxNombre.DataSource = bindingSource_Clientes;
            this.listBoxNombre.SelectionMode = SelectionMode.None;
            this.listBoxNombre.DisplayMember = "getNombre";

            this.listBoxImporte.DataSource = bindingSource_Clientes;
            this.listBoxImporte.SelectionMode = SelectionMode.None;
            this.listBoxImporte.DisplayMember = "importeTotal";

        }

        /// <summary>
        /// Accion que ordena el listado por el importe al pulsar sobre el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImporte_Click(object sender, EventArgs e)
        {
            // La vinculacion pasa a hacerse sobre una lista ordenada por el importe total

            listaOrd = LNCliente.SELECT_ALL().OrderBy((x) => x.importeTotal).ToList();
            bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = listaOrd;

            this.listBoxDNI.DataSource = bindingSource_Clientes;
            this.listBoxDNI.SelectionMode = SelectionMode.None;
            this.listBoxDNI.DisplayMember = "getDNI";

            this.listBoxNombre.DataSource = bindingSource_Clientes;
            this.listBoxNombre.SelectionMode = SelectionMode.None;
            this.listBoxNombre.DisplayMember = "getNombre";

            this.listBoxImporte.DataSource = bindingSource_Clientes;
            this.listBoxImporte.SelectionMode = SelectionMode.None;
            this.listBoxImporte.DisplayMember = "importeTotal";

        }

        /// <summary>
        /// Accion que ocurre al pulsar sobre el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
