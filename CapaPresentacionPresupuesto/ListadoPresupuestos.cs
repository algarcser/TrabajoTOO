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
using LogicaModeloPresupuesto;
using LogicaModeloVehiculo;
using LogicaNegocioPresupuesto;
using LogicaNegocioCliente;
using CapaPresentacionCliente;

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Formulario que te muestra el listado de presupuestos que hayas pasado, ya sea el resultado de una búsqueda o todo los presupuestos.
    /// También te permite mostrar la lista de vehículos, el cliente, el presupuesto individualmente, el presupuesto en un recorrido,
    /// eliminar un presupuesto mostrado respecto la BD, actualziar los presupuestos de la lista respecto la BD...
    /// </summary>
    public partial class FormListadoPresupuestos : Form
    {
        List<Presupuesto> listaPresupuestos; //listado de presupuestos a mostrar.

        /// <summary>
        /// Constructor del formulario.
        /// PRE: Requeire List<Presupuesto> lp.
        /// POST:
        /// </summary>
        public FormListadoPresupuestos(List<Presupuesto> lp)
        {
            this.listaPresupuestos = lp;
            
            InitializeComponent();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaPresupuestos;
            this.lboFechaCreacion.DataSource = bindingSource;
            this.lboFechaCreacion.DisplayMember = "FechaRealizacion";
            this.lboCliente.DataSource = bindingSource;
            this.lboCliente.DisplayMember = "DNIClientePresupuesto";
            this.lboEstado.DataSource = bindingSource;
            this.lboEstado.DisplayMember = "EstadoPresupuesto";
            this.lboNVehiculos.DataSource = bindingSource;
            this.lboNVehiculos.DisplayMember = "NumeroVehiculosPresupuesto";
            foreach (Presupuesto p in this.listaPresupuestos)
            {
                this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p).ToString() + " €");
            }
            this.lboImporte.Enabled = false;
        }

        /// <summary>
        /// Evento que te permite mostrar la información completa del cliente asociado al presupuesto seleccionado, si lo has seleccionado.
        /// </summary>
        private void btMostrarCliente_Click(object sender, EventArgs e)
        {
            if (this.lboCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista para mostrarlo.", "No ha seleccionado ningún cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Presupuesto p = this.lboCliente.SelectedItem as Presupuesto;
                if (LNCliente.existeCliente(p.Cliente) == true)
                {
                    Form mostrarCliente = new Busqueda_cliente(p.Cliente);
                    mostrarCliente.Show();
                }
                else
                {
                    MessageBox.Show("El cliente ha sido eliminado de la base de datos, por lo que no se puede mostrar.", "No se puede mostrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }     
        }

        /// <summary>
        /// Evento que te permite mostrar la lista de vehiculos del presupuetso selecionado llamando al formulario MostrarListaVehiculosPresupuesto.
        /// </summary>
        private void btMostrarListaVehiculos_Click(object sender, EventArgs e)
        {
            if (this.lboNVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una lista de vehículos de la lista para mostrarla.", "No ha seleccionado ninguna lista de vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<vehiculo> listaVehiculos = new List<vehiculo>();
                Presupuesto p = this.lboNVehiculos.SelectedItem as Presupuesto;
                listaVehiculos = p.ListaVehiculos;
                Form mostrarListaVehiculos = new FormMostrarListaVehiculosPresupuesto(listaVehiculos);
                mostrarListaVehiculos.Show();
            }     
        }

        /// <summary>
        /// Evento que te permite cerrar el formulario cuando hayas terminado.
        /// </summary>
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento qeu te permite acceder a la modificación en tiempo real de los presupuestos de la lista, recorreindolos de 1 en 1.
        /// </summary>
        private void btRecorrerP1en1_Click(object sender, EventArgs e)
        {
            Form recorrerPresupuestos = new FormRecorrerPresupuestos1en1(this.listaPresupuestos);
            recorrerPresupuestos.Show();
            this.Close();
        }

        /// <summary>
        /// Evento que actualiza el listado de estado creado a desestimado si han pasado más de 15 días.
        /// </summary>
        private void btActualizarListado_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            int presupuestosActualizados = 0;
            foreach (Presupuesto p in this.listaPresupuestos)
            {
                if (LNPresupuesto.actualizarEstado(p) == true)
                {
                    if (LNPresupuesto.UPDATE(p) == true)
                    {
                        presupuestosActualizados++;
                    }
                }
            }
            this.lboImporte.Items.Clear();
            bindingSource.DataSource = this.listaPresupuestos;
            this.lboFechaCreacion.DataSource = bindingSource;
            this.lboFechaCreacion.DisplayMember = "FechaRealizacion";
            this.lboCliente.DataSource = bindingSource;
            this.lboCliente.DisplayMember = "DNIClientePresupuesto";
            this.lboEstado.DataSource = bindingSource;
            this.lboEstado.DisplayMember = "EstadoPresupuesto";
            this.lboNVehiculos.DataSource = bindingSource;
            this.lboNVehiculos.DisplayMember = "NumeroVehiculosPresupuesto";
            foreach (Presupuesto p in this.listaPresupuestos)
            {
                this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p).ToString() + " €");
            }

            MessageBox.Show("Se han actualizado " + presupuestosActualizados.ToString() + " presupuestos.", "Presupuestos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento que te permite mostrar el presupuesto seleccionado individualmente.
        /// </summary>
        private void btMostrarPresupuesto_Click(object sender, EventArgs e)
        {
            if(this.lboFechaCreacion.SelectedItem != null)
            {
                Form mostrarPresupuesto = new FormCrearMostrarPresupuesto(this.lboFechaCreacion.SelectedItem as Presupuesto);
                mostrarPresupuesto.Show();
            }      
        }

        /// <summary>
        /// Evento que te permite eliminar de la BD el presupuesto seleccionado avisandote de ello.
        /// </summary>
        private void btEliminarPresupuesto_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            DialogResult result = MessageBox.Show("¿Esta seguro de que quiere eliminar el presupuesto seleccionado?", "Va a eliminar un presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (LNPresupuesto.DELETE(this.lboFechaCreacion.SelectedItem as Presupuesto) == true)
                {
                    this.lboImporte.Items.Clear();
                    this.listaPresupuestos.Remove(this.lboFechaCreacion.SelectedItem as Presupuesto);
                    bindingSource.DataSource = this.listaPresupuestos;
                    this.lboFechaCreacion.DataSource = bindingSource;
                    this.lboFechaCreacion.DisplayMember = "FechaRealizacion";
                    this.lboCliente.DataSource = bindingSource;
                    this.lboCliente.DisplayMember = "DNIClientePresupuesto";
                    this.lboEstado.DataSource = bindingSource;
                    this.lboEstado.DisplayMember = "EstadoPresupuesto";
                    this.lboNVehiculos.DataSource = bindingSource;
                    this.lboNVehiculos.DisplayMember = "NumeroVehiculosPresupuesto";
                    foreach (Presupuesto p in this.listaPresupuestos)
                    {
                        this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p).ToString() + " €");
                    }
                    MessageBox.Show("El presupuesto seleccionado ha sido eliminado.", "Se ha eliminado un presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
