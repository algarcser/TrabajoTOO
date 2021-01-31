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
    public partial class Recorrido_uno_a_uno : Form
    {
        List<Cliente> listClientes;

        /// <summary>
        /// Constructor del form
        /// </summary>
        public Recorrido_uno_a_uno()
        {
            InitializeComponent();

            // Se vincula una lista auxiliar creada a la lista de clientes de la BD

            BindingSource bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = LNCliente.SELECT_ALL();

            this.bindingNavigator1.BindingSource = bindingSource_Clientes;
            listClientes = LNCliente.SELECT_ALL();

        }

        /// <summary>
        /// Accion que ocurre al pulsar sobre el boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Accion que ocurre al darle al boton de siguiente item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            // Se crea un cliente cogiendo de la lista de clientes el que está en la posicion actual en el form, y se asignan sus componentes a las textBoxes
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = c.importeTotal;

        }

        /// <summary>
        /// Accion que ocurre al darle al boton de anterior item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            // Se crea un cliente cogiendo de la lista de clientes el que está en la posicion actual en el form, y se asignan sus componentes a las textBoxes
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = c.importeTotal;

        }

        /// <summary>
        /// Accion que ocurre al darle al boton de ultimo item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            // Se crea un cliente cogiendo de la lista de clientes el que está en la posicion actual en el form, y se asignan sus componentes a las textBoxes
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = c.importeTotal;

        }

        /// <summary>
        /// Accion que ocurre al darle al boton de primer item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            // Se crea un cliente cogiendo de la lista de clientes el que está en la posicion actual en el form, y se asignan sus componentes a las textBoxes
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = c.importeTotal;

        }

        /// <summary>
        /// Accion que ocurre al cargar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Recorrido_uno_a_uno_Load(object sender, EventArgs e)
        {
            List<Cliente> list = LNCliente.SELECT_ALL();

            // Se crea un cliente cogiendo de la lista de clientes el que está en la posicion actual en el form, y se asignan sus componentes a las textBoxes
            // Si la lista está vacia no se muestra nada
            if(list.Count()>0)
            {
                Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

                this.textBox1.Text = c.getDNI;
                this.textBox2.Text = c.getNombre;
                this.textBox3.Text = c.getApellidos;
                this.textBox4.Text = c.importeTotal;
            }
            
        }
    }
}
