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
        public Recorrido_uno_a_uno()
        {
            InitializeComponent();

            BindingSource bindingSource_Clientes = new BindingSource();
            bindingSource_Clientes.DataSource = LNCliente.SELECT_ALL();

            this.bindingNavigator1.BindingSource = bindingSource_Clientes;

            Object o = this.bindingNavigator1.BindingSource.Current;

            if(o is Cliente)
            {
                this.textBox1.Text = ((Cliente) o).getDNI;
                this.textBox2.Text = ((Cliente) o).getNombre;
                this.textBox3.Text = ((Cliente) o).getApellidos;
                this.textBox4.Text = Convert.ToString(LNCliente.sumaImportes((Cliente) o)) ;
            }


        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
