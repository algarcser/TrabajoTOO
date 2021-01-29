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
        public Listado_de_clientes()
        {
            InitializeComponent();

            BindingSource bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = LNCliente.SELECT_ALL();

            this.listBoxDNI.DataSource = bindingSource_Clientes;
            this.listBoxDNI.SelectionMode = SelectionMode.None;
            this.listBoxDNI.DisplayMember = "DNI";

            this.listBoxNombre.DataSource = bindingSource_Clientes;
            this.listBoxNombre.SelectionMode = SelectionMode.None;
            this.listBoxNombre.DisplayMember = "Nombre";

            this.listBoxImporte.DataSource = bindingSource_Clientes;
            this.listBoxImporte.SelectionMode = SelectionMode.None;
            this.listBoxImporte.DisplayMember = "Importe";

        }

        private void btDNI_Click(object sender, EventArgs e)
        {
            List<Cliente> listaOrdDNI = LNCliente.SELECT_ALL().OrderBy((x) => x.getDNI).ToList();
            listBoxDNI.Items.Clear();
            listBoxNombre.Items.Clear();
            listBoxImporte.Items.Clear();
            foreach (Cliente cl in listaOrdDNI)
            {
                listBoxDNI.Items.Add(cl.getDNI);
                listBoxNombre.Items.Add(cl.getNombre);
                float importeTotal = 0;
                foreach(float elem in cl.Importes)
                {
                    importeTotal += elem;
                }
                listBoxImporte.Items.Add(importeTotal);
            }

        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            List<Cliente> listaOrdNombre = LNCliente.SELECT_ALL().OrderBy((x) => x.getNombre).ToList();
            listBoxDNI.Items.Clear();
            listBoxNombre.Items.Clear();
            listBoxImporte.Items.Clear();
            foreach (Cliente cl in listaOrdNombre)
            {
                listBoxDNI.Items.Add(cl.getDNI);
                listBoxNombre.Items.Add(cl.getNombre);
                float importeTotal = 0;
                foreach (float elem in cl.Importes)
                {
                    importeTotal += elem;
                }
                listBoxImporte.Items.Add(importeTotal);
                
            }
        }

        private void btImporte_Click(object sender, EventArgs e)
        {
            


            List<Cliente> listaOrdImporte = LNCliente.SELECT_ALL().OrderBy((x) => LNCliente.sumaImportes(x)).ToList();
            listBoxDNI.Items.Clear();
            listBoxNombre.Items.Clear();
            listBoxImporte.Items.Clear();
            foreach (Cliente cl in listaOrdImporte)
            {
                listBoxDNI.Items.Add(cl.getDNI);
                listBoxNombre.Items.Add(cl.getNombre);
                float importeTotal = 0;
                foreach (float elem in cl.Importes)
                {
                    importeTotal += elem;
                }
                listBoxImporte.Items.Add(importeTotal);
            }
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
