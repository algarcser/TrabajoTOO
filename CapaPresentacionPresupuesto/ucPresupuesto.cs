using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloPresupuesto;

namespace CapaPresentacionPresupuesto
{
    public partial class ucPresupuesto : UserControl
    {
        private bool crear;
        public ucPresupuesto() //crear
        {
            this.lbFechaCreacion.Visible = false;
            this.gbEstado.Enabled = true;
            this.btMostrarCliente.Visible = false;
            this.tbDNI.Enabled = false;
            this.tbNombre.Enabled = false;
            this.btSeleccionarVehiculo.Visible = true;
            this.btIntroducirVehiculo.Visible = true;
            this.lboListaVehiculos.Enabled = false;
            this.btMostrarVehiculo.Visible = false;
            this.lbImporte.Visible = false;
            InitializeComponent();
        }

        public ucPresupuesto(Presupuesto presupuesto) //mostrar
        {
            this.lbFechaCreacion.Visible = true;
            this.lbFechaCreacion.Text = "Fecha de creación: " + presupuesto.FechaRealizacion.ToString();
            this.gbEstado.Enabled = false;
            this.btMostrarCliente.Visible = true;
            this.tbDNI.Enabled = false;
            this.tbNombre.Enabled = false;
            this.btSeleccionarVehiculo.Visible = false;
            this.btIntroducirVehiculo.Visible = false;
            this.lboListaVehiculos.Enabled = true;
            this.btMostrarVehiculo.Visible = true;
            this.lbImporte.Visible = true;
            this.btCancelar.Visible = false;
            InitializeComponent();
        }
    }
}
