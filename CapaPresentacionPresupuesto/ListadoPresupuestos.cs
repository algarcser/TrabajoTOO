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
            this.lboCliente.DisplayMember = "Cliente.getDNI";
            this.lboEstado.DataSource = bindingSource;
            this.lboEstado.DisplayMember = "EstadoPresupuesto";
            this.lboNVehiculos.DataSource = bindingSource;
            this.lboNVehiculos.DisplayMember = "ListaVehiculos";
            foreach (Presupuesto p in this.listaPresupuestos)
            {
                this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p));
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
                Form mostrarCliente = new Busqueda_cliente(this.lboCliente.SelectedItem as Cliente);
                mostrarCliente.Show();
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
                Form mostrarListaVehiculos = new FormMostrarListaVehiculosPresupuesto(this.lboNVehiculos.SelectedItem as List<vehiculo>);
                mostrarListaVehiculos.Show();
            }     
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRecorrerP1en1_Click(object sender, EventArgs e)
        {
            Form recorrerPresupuestos = new FormRecorrerPresupuestos1en1();
            recorrerPresupuestos.Show();
            this.Close();
        }

        private void btActualizarListado_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource(); //COMPLETAR mostrar cuantos lo han hecho (actualizar su estado)
                                                               //hacer UPDATE de todos en la base de datos
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
            bindingSource.DataSource = this.listaPresupuestos;
            this.lboFechaCreacion.DataSource = bindingSource;
            this.lboFechaCreacion.DisplayMember = "FechaRealizacion";
            this.lboCliente.DataSource = bindingSource;
            this.lboCliente.DisplayMember = "Cliente.getDNI";
            this.lboEstado.DataSource = bindingSource;
            this.lboEstado.DisplayMember = "EstadoPresupuesto";
            this.lboNVehiculos.DataSource = bindingSource;
            this.lboNVehiculos.DisplayMember = "ListaVehiculos";
            foreach (Presupuesto p in this.listaPresupuestos)
            {
                this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p));
            }

            MessageBox.Show("Se han actualizado " + presupuestosActualizados.ToString() + " presupuestos.", "Presupuestos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btMostrarPresupuesto_Click(object sender, EventArgs e)
        {
            Form mostrarPresupuesto = new FormCrearMostrarPresupuesto(this.lboCliente.SelectedItem as Presupuesto, false);
            mostrarPresupuesto.Show();
        }

        private void btEliminarPresupuesto_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            DialogResult result = MessageBox.Show("¿Esta seguro de que quiere eliminar el presupuesto seleccionado?", "Va a eliminar un presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (LNPresupuesto.DELETE(this.lboCliente.SelectedItem as Presupuesto) == true)
                {
                    this.listaPresupuestos.Remove(this.lboCliente.SelectedItem as Presupuesto);
                    bindingSource.DataSource = this.listaPresupuestos;
                    this.lboFechaCreacion.DataSource = bindingSource;
                    this.lboFechaCreacion.DisplayMember = "FechaRealizacion";
                    this.lboCliente.DataSource = bindingSource;
                    this.lboCliente.DisplayMember = "Cliente.getDNI";
                    this.lboEstado.DataSource = bindingSource;
                    this.lboEstado.DisplayMember = "EstadoPresupuesto";
                    this.lboNVehiculos.DataSource = bindingSource;
                    this.lboNVehiculos.DisplayMember = "ListaVehiculos";
                    foreach (Presupuesto p in this.listaPresupuestos)
                    {
                        this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p));
                    }
                    MessageBox.Show("El presupuesto seleccionado ha sido eliminado.", "Se ha eliminado un presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
