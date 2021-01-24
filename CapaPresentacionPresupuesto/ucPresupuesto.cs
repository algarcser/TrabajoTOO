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
using CapaPresentacionVehiculo;


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
            
            this.tbDNI.ReadOnly = true;
            this.tbNombre.ReadOnly = true;
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
            
            this.tbDNI.ReadOnly = true;
            this.tbDNI.Text = presupuesto.Cliente.getDNI();
            this.tbNombre.ReadOnly = true;
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
            // (?) this.lboListaVehiculos.DataBindings.Add(new Binding("DisplayMember", bindingSource, ""))
            this.lboListaVehiculos.SelectionMode = SelectionMode.One;
            this.lboListaVehiculos.DisplayMember = "nBastidor";
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = true;
            this.lbImporte.Text = "Importe: " + LNPresupuesto.calcularPresupuesto(presupuesto).ToString() + " €";
            this.btAceptar.Visible = true;
            this.btCancelar.Visible = false;
            InitializeComponent();
        } 
        
        private void btMostrarCliente_Click(object sender, EventArgs e)
        {
            if (this.cliente == null)
            {
                Form mostrarCliente = new Busqueda_cliente(this.presupuesto.Cliente);
                mostrarCliente.Show();
            }
            else
            {
                Form mostrarCliente = new Busqueda_cliente(this.cliente);
                mostrarCliente.Show();
            }
        }

        private void btMostrarVehiculo_Click(object sender, EventArgs e)
        {
            if (this.lboListaVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para mostrarlo.", "No ha seleccionado ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vehiculo v = (vehiculo)this.lboListaVehiculos.SelectedItem;
                //mostrar vehículo como en búsqueda vehículo
            }
        }

        private void btIntroducirVehiculo_Click(object sender, EventArgs e)
        {
            // Form introducirVehiculo = new ObtenerNBastidor();
            // introducirVehiculo.ShowDialog();
            //mostrar ObtenerNBastidor.cs, si existe se añade a la lista, si no se abre dar de alta vehículo
            //JUNTO TODO SU PROCESO,tras darlo de alta se introduce en la lista
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (this.cliente == null) //mostrar
            {
                this.ParentForm.Close();
            }
            else //crear
            {
                EstadoPresupuesto estado = EstadoPresupuesto.creado;
                bool vehiculoCorrecto = true;

                int i = 0;
                foreach (RadioButton r in this.gbEstado.Controls)
                {
                    if (r.Checked == false)
                    {
                        i++;
                    }
                    
                }

                if (this.rbCreado.Checked == true)
                {
                    estado = EstadoPresupuesto.creado;
                }
                else if (this.rbAceptado.Checked == true)
                {     
                    estado = EstadoPresupuesto.aceptado;
                }
                else if (this.rbDesestimado.Checked == true)
                {
                    DialogResult result1 = MessageBox.Show("¿Esta seguro de que el estado del presupuesto es desestimado?", "Esta creando un presupuesto desestimado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result1 == DialogResult.Yes)
                    {
                        estado = EstadoPresupuesto.desestimado;
                    }else
                    {
                        CancelEventArgs seguir = (CancelEventArgs)e;
                        seguir.Cancel = true; //No sé si funcionará correctamente.
                    }
                }
                else if (this.rbPendiente.Checked == true)
                {
                    estado = EstadoPresupuesto.pendiente;
                }
                    
                if (this.lboListaVehiculos.Items.Count == 0)
                {
                    vehiculoCorrecto = false;
                    MessageBox.Show("Introduzca al menos un vehículo en el presupuesto.", "No ha introducido ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CancelEventArgs seguir = (CancelEventArgs)e;
                    seguir.Cancel = true; //No sé si funcionará correctamente.

                }

                if (i == 4)
                {
                    DialogResult result2 = MessageBox.Show("Se seleccionará automáticamente el estado de creado para presupuesto.", "No ha seleccionado ningún estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result2 == DialogResult.Cancel)
                    {
                        CancelEventArgs seguir = (CancelEventArgs)e;
                        seguir.Cancel = true; //No sé si funcionará correctamente.
                    }
                }

                if (vehiculoCorrecto == true)
                {
                    List<vehiculo> listaVehiculos = new List<vehiculo>((IEnumerable<vehiculo>)this.lboListaVehiculos.Items);
                    //si no funciona hacer un foreach
                    //List<vehiculo> listaVehiculos = new List<vehiculo>();
                    //foreach (Object o in this.lboListaVehiculos.Items)
                    //{
                    //    vehiculo v = (vehiculo)o;
                    //    listaVehiculos.Add(v);
                    //}
                    Presupuesto nuevoPresupuesto = new Presupuesto(DateTime.Now, estado, this.cliente, listaVehiculos);
                    LNPresupuesto.INSERT(nuevoPresupuesto);
                } 
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
