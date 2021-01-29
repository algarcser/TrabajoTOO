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
        /// <summary>
        /// Constructor del form
        /// </summary>
        public Busqueda_alternativa_cliente()
        {
            InitializeComponent();

            // Aqui se da la opcion de mostrar otros items del comboBox
            List<string> listaAux = LNCliente.SELECT_ALL().Select(x => x.getDNI).ToList();
            foreach(string elem in listaAux)
            {
                this.comboBox1.Items.Add(elem);
            }

        }

        /// <summary>
        /// Accion que ocurre al hacer click sobre el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que responde a un evento de si se cambia el item seleccionado del comboBox, para que aparezcan los datos del nuevo item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dni = this.comboBox1.SelectedItem.ToString();
            Cliente c = new Cliente(dni);

            Cliente clBuscado = LNCliente.readCliente(c);
            this.textBoxNombre.Text = clBuscado.getNombre;
            this.textBoxApellidos.Text = clBuscado.getApellidos;
            this.comboBox1.Text = clBuscado.getDNI;
        }
    }
}
