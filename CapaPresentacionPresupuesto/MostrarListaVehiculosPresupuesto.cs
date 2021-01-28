using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloVehiculo;
using CapaPresentacionVehiculo;

namespace CapaPresentacionPresupuesto
{
    public partial class FormMostrarListaVehiculosPresupuesto : Form
    {
        List<vehiculo> listaVehiculos;

        public FormMostrarListaVehiculosPresupuesto(List<vehiculo> lv)
        {
            this.listaVehiculos = lv;
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaVehiculos;
            this.lboVehiculos.DataSource = bindingSource;
            this.lboVehiculos.DisplayMember = "NBastidor";
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMostrarVehiculo_Click(object sender, EventArgs e)
        {
            if (this.lboVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para mostrarlo.", "No ha seleccionado ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vehiculo v = (vehiculo)this.lboVehiculos.SelectedItem;
                Form mostrarVehiculo = new formularioVehiculo(v.NBastidor, enumObjetivo.Ver);
                mostrarVehiculo.Show();
            }
        }
    }
}
