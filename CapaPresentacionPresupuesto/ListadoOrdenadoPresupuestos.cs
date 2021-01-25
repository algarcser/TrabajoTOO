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
    public partial class FormListadoOrdenadoPresupuestos : Form
    {
        List<Presupuesto> listaPresupuestos;

        public FormListadoOrdenadoPresupuestos(List<Presupuesto> lp)
        {
            this.listaPresupuestos = lp;
            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaPresupuestos;
            this.lboFechaCreacion.DataSource = bindingSource;
            this.lboFechaCreacion.DisplayMember = "FechaRealizacion";
            this.lboCliente.DataSource = bindingSource;
            this.lboCliente.DisplayMember = "Cliente.DNI";
            this.lboEstado.DataSource = bindingSource;
            this.lboEstado.DisplayMember = "EstadoPresupuesto";
            this.lboNVehiculos.DataSource = bindingSource;
            this.lboEstado.DisplayMember = "ListaVehiculos.Count";
            foreach (Presupuesto p in LNPresupuesto.SELECTALL())
            {
                this.lboImporte.Items.Add(LNPresupuesto.calcularPresupuesto(p));
            }
            
            InitializeComponent();
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
                Form mostrarCliente = new Busqueda_cliente((Cliente)this.lboCliente.SelectedItem);
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
                Form mostrarListaVehiculos = new FormMostrarListaVehiculosPresupuesto((List<vehiculo>)this.lboNVehiculos.SelectedItem);
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
        }
    }
}
