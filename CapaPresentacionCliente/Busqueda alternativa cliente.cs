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
            // Lo que hago aqui es mostrar el cliente que busca en el formulario de introducir DNI
            Cliente clBuscado = LNCliente.readCliente(c);
            this.textBoxNombre.Text = clBuscado.getNombre;
            //this.textBoxApellidos.Text = clBuscado.getApellidos;

            // Y aqui dar la opcion de mostrar otros del comboBox
            List<string> listaAux = LNCliente.SELECT_ALL().Select(x => x.getDNI).ToList();
            foreach(string elem in listaAux)
            {
                this.comboBox1.Items.Add(elem);
            }

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
