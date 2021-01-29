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

        public Recorrido_uno_a_uno()
        {
            InitializeComponent();

            BindingSource bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = LNCliente.SELECT_ALL();

            this.bindingNavigator1.BindingSource = bindingSource_Clientes;
            listClientes = LNCliente.SELECT_ALL();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = Convert.ToString(LNCliente.sumaImportes(c));

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = Convert.ToString(LNCliente.sumaImportes(c));

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = Convert.ToString(LNCliente.sumaImportes(c));

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = Convert.ToString(LNCliente.sumaImportes(c));

        }

        private void Recorrido_uno_a_uno_Load(object sender, EventArgs e)
        {
            Cliente c = listClientes[Convert.ToInt32(this.bindingNavigator1.PositionItem.Text) - 1];

            this.textBox1.Text = c.getDNI;
            this.textBox2.Text = c.getNombre;
            this.textBox3.Text = c.getApellidos;
            this.textBox4.Text = Convert.ToString(LNCliente.sumaImportes(c));
        }
    }
}
