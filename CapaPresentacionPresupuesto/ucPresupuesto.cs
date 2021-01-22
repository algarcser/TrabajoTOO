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


namespace CapaPresentacionPresupuesto
{
    public partial class ucPresupuesto : UserControl
    {
        private Cliente cliente;
        private Presupuesto presupuesto;

        public ucPresupuesto(Cliente c) //crear
        {
            this.cliente = c;
            
            this.lbFechaCreacion.Visible = false;
            
            this.tbDNI.Enabled = false;
            this.tbNombre.Enabled = false;
            this.btMostrarCliente.Visible = true;

            this.gbEstado.Enabled = true;

            this.btIntroducirVehiculo.Visible = true;
            this.lboListaVehiculos.Enabled = true;
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = false;

            this.btAceptar.Visible = true;
            this.btCancelar.Visible = true;
            InitializeComponent();
        }

        public ucPresupuesto(Presupuesto p) //mostrar
        {
            this.presupuesto = p;
            
            this.lbFechaCreacion.Visible = true;
            this.lbFechaCreacion.Text = "Fecha de creación: " + presupuesto.FechaRealizacion.ToString();  
            
            this.tbDNI.Enabled = false;
            this.tbDNI.Text = presupuesto.Cliente.getDNI();
            this.tbNombre.Enabled = false;
            this.tbNombre.Text = presupuesto.Cliente.getNombre();
            this.btMostrarCliente.Visible = true;

            this.gbEstado.Enabled = false;
            LNPresupuesto.actualizarEstado(presupuesto);
            if ((int)presupuesto.EstadoPresupuesto == 0)
            {
                this.rbCreado.Checked = true;
            }else if ((int)presupuesto.EstadoPresupuesto == 1)
            {
                this.rbAceptado.Checked = true;
            }else if ((int)presupuesto.EstadoPresupuesto == 2)
            {
                this.rbDesestimado.Checked = true;
            }
            else
            {
                this.rbPendiente.Checked = true;
            }

            this.btIntroducirVehiculo.Visible = false;
            this.lboListaVehiculos.Enabled = true;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = presupuesto.ListaVehiculos;
            this.lboListaVehiculos.DataSource = bindingSource;
            this.lboListaVehiculos.SelectionMode = SelectionMode.One;
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = true;
            this.lbImporte.Text = "Importe: " + LNPresupuesto.calcularPresupuesto(presupuesto).ToString();
            this.btAceptar.Visible = true;
            this.btCancelar.Visible = false;
            InitializeComponent();
        } 
        
        private void btMostrarCliente_Click(object sender, EventArgs e)
        {
            if (this.cliente == null)
            {
                //mostrar cliente como en búsqueda cliente con this.presupuesto.Cliente
            }
            else
            {
                //mostrar cliente como en búsqueda cliente con this.cliente
            }
        }
    }
}
