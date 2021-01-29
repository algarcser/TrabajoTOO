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

        public Listado_de_clientes()
        {
            InitializeComponent();

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

        private void btDNI_Click(object sender, EventArgs e)
        {
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

        private void btNombre_Click(object sender, EventArgs e)
        {
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

        private void btImporte_Click(object sender, EventArgs e)
        {

            listaOrd = LNCliente.SELECT_ALL().OrderBy((x) => LNCliente.sumaImportes(x)).ToList();
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

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
