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
using CapaPresentacionCliente;

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
            Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("baja");
            intrDNI.Show();
        }

        private void tsmiBusquedaCliente_Click(object sender, EventArgs e)
        {
            //Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("busqueda");
            //intrDNI.Show();

            Form busquedaCliente = new CapaPresentacionCliente.Busqueda_alternativa_cliente();
            busquedaCliente.Show();
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
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form busquedaPresupuestosCliente = new FormIntroducirDNIPresupuesto("busqueda");
                busquedaPresupuestosCliente.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Búsqueda\\Por cliente\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiMostrarTodos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form mostrarTodosPresupuestos = new FormListadoPresupuestos(LNPresupuesto.SELECTALL());
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

        private void tsmiBPPorVehiculo_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form busquedaPresupuestosVehiculo = new FormIntroducirNBastidorPresupuesto("busqueda");
                busquedaPresupuestosVehiculo.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Búsqueda\\Por vehículo\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiBPPorEstado_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form busquedaPresupuestosEstado = new FormIntroducirEstadoPresupuesto();
                busquedaPresupuestosEstado.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Búsqueda\\Por estado\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiModificarPresupuestos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form modificarPresupuestos = new FormRecorrerPresupuestos1en1(LNPresupuesto.SELECTALL());
                modificarPresupuestos.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Configuración\\Modificar presupuestos\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiActualizarPresupuestos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                int presupuestosActualizados = 0;
                foreach (Presupuesto p in LNPresupuesto.SELECTALL())
                {
                    if (LNPresupuesto.actualizarEstado(p) == true)
                    {
                        if (LNPresupuesto.UPDATE(p) == true)
                        {
                            presupuestosActualizados++;
                        }
                    }
                }
                MessageBox.Show("Se han actualizado " + presupuestosActualizados.ToString() + " presupuestos.", "Presupuestos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Configuración\\Actualizar presupuestos\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = new CapaPresentacionCliente.Listado_de_clientes();
            listado.Show();
        }

        private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form recorrido = new CapaPresentacionCliente.Recorrido_uno_a_uno();
            recorrido.Show();
        }
    }
}
