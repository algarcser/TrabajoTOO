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
    public partial class FormListadoPresupuestos : Form
    {
        List<Presupuesto> listaPresupuestos;

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

            //this.lboFechaCreacion.DataBindings.Add(new Binding("Text", bindingSource, "Date"));
            //this.lboCliente.DataBindings.Add(new Binding("Text", bindingSource, ""));
        }

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

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRecorrerP1en1_Click(object sender, EventArgs e)
        {
            Form recorrerPresupuestos = new FormRecorrerPresupuestos1en1(this.listaPresupuestos);
            recorrerPresupuestos.Show();
            this.Close();
        }

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

        private void btMostrarPresupuesto_Click(object sender, EventArgs e)
        {
            if(this.lboFechaCreacion.SelectedItem != null)
            {
                Form mostrarPresupuesto = new FormCrearMostrarPresupuesto(this.lboFechaCreacion.SelectedItem as Presupuesto, false);
                mostrarPresupuesto.Show();
            }      
        }

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
