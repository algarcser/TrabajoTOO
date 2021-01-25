using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacionVehiculo;
using CapaPresentacionPresupuesto;
using LogicaNegocioPresupuesto;
using LogicaModeloPresupuesto;

namespace CapaPresentacionGeneral
{
    public partial class FormPrincipal : Form
    {
        private string usuario;
        public FormPrincipal(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            
        }

        private void tsmiAltaCliente_Click(object sender, EventArgs e)
        {
            Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("alta");
            intrDNI.Show();
        }

        private void tsmiBajaCliente_Click(object sender, EventArgs e)
        {

        }

        private void tsmiBusquedaCliente_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAltaVehiculo_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Alta );
            obtenerNBastidor.Show();
        }

        private void tsmiBusquedaVehiculo_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Ver );
            obtenerNBastidor.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Baja );
            obtenerNBastidor.Show();
        }

        private void tsmiCrearPresupuesto_Click(object sender, EventArgs e)
        {
            Form crearPresupuesto = new FormIntroducirDNIPresupuesto("crear");
            crearPresupuesto.Show();
        }

        private void tsmiBPPorCliente_Click(object sender, EventArgs e)
        {
            Form busquedaPresupuestosCliente = new FormIntroducirDNIPresupuesto("busqueda");
            busquedaPresupuestosCliente.Show();
        }

        private void tsmiMostrarTodos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form mostrarTodosPresupuestos = new FormListadoOrdenadoPresupuestos(LNPresupuesto.SELECTALL());
                mostrarTodosPresupuestos.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Mostrar presupuestos\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void anadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestionar_Extra alta_extra = new Gestionar_Extra();
            alta_extra.Show();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motrar_Todos_Vehiculos mostrar_todos_vehiculos = new Motrar_Todos_Vehiculos();
            mostrar_todos_vehiculos.Show();
        }
    }
}
