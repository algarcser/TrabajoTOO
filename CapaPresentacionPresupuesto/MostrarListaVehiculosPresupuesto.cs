using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocioVehiculo;
using LogicaModeloVehiculo;
using CapaPresentacionVehiculo;

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMostrarListaVehiculosPresupuesto : Form
    {
        List<vehiculo> listaVehiculos;

        /// <summary>
        /// 
        /// </summary>
        public FormMostrarListaVehiculosPresupuesto(List<vehiculo> lv)
        {
            this.listaVehiculos = lv;
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaVehiculos;
            this.lboVehiculos.DataSource = bindingSource;
            this.lboVehiculos.DisplayMember = "NBastidor";
        }

        /// <summary>
        /// 
        /// </summary>
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void btMostrarVehiculo_Click(object sender, EventArgs e)
        {
            if (this.lboVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para mostrarlo.", "No ha seleccionado ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vehiculo v = (vehiculo)this.lboVehiculos.SelectedItem;
                if (LNVehiculo.EXISTS(v) == true)
                {
                    Form mostrarVehiculo = new formularioVehiculo(v.NBastidor, enumObjetivo.Ver);
                    mostrarVehiculo.Show();
                }
                else
                {
                    MessageBox.Show("El vehículo ha sido eliminado de la base de datos, por lo que no se puede mostrar.", "No se puede mostrar el vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
