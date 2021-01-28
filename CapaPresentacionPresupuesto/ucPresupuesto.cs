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
using LogicaNegocioVehiculo;
using CapaPresentacionCliente;
using CapaPresentacionVehiculo;


namespace CapaPresentacionPresupuesto
{
    public partial class ucPresupuesto : UserControl
    {
        private Cliente cliente;
        private List<vehiculo> listaVehiculosCrear = new List<vehiculo>();
        private Presupuesto presupuesto;

        public ucPresupuesto(Cliente c) //crear
        {
            this.cliente = c;
            
            InitializeComponent();

            this.lbFechaCreacion.Visible = false;

            this.tbDNI.ReadOnly = true;
            this.tbDNI.Text = this.cliente.getDNI;
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Text = this.cliente.getNombre;
            this.btMostrarCliente.Visible = true;

            this.gbEstado.Enabled = true;
            this.rbCreado.AutoCheck = true;
            this.rbAceptado.AutoCheck = true;
            this.rbPendiente.AutoCheck = true;
            this.rbDesestimado.AutoCheck = true;

            this.btIntroducirVehiculo.Visible = true;
            this.lboListaVehiculos.Enabled = true;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaVehiculosCrear;
            this.lboListaVehiculos.DataSource = bindingSource;
            this.lboListaVehiculos.DisplayMember = "NBastidor";
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = false;

            this.btAceptar.Visible = true;
            this.btCancelar.Visible = true;
        }

        public ucPresupuesto(Presupuesto p) //mostrar
        {
            this.presupuesto = p;
            
            InitializeComponent();

            this.lbFechaCreacion.Visible = true;
            this.lbFechaCreacion.Text = "Fecha de creación: " + presupuesto.FechaRealizacion.ToString();

            this.tbDNI.ReadOnly = true;
            this.tbDNI.Text = presupuesto.Cliente.getDNI;
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Text = presupuesto.Cliente.getNombre;
            this.btMostrarCliente.Visible = true;

            this.gbEstado.Enabled = false;
            LNPresupuesto.actualizarEstado(presupuesto);
            if ((int)presupuesto.EstadoPresupuesto == 0)
            {
                this.rbCreado.Checked = true;
            }
            else if ((int)presupuesto.EstadoPresupuesto == 1)
            {
                this.rbAceptado.Checked = true;
            }
            else if ((int)presupuesto.EstadoPresupuesto == 2)
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
            this.lboListaVehiculos.DisplayMember = "NBastidor";
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = true;
            this.lbImporte.Text = "Importe: " + LNPresupuesto.calcularPresupuesto(presupuesto).ToString() + " €";
            this.btAceptar.Visible = true;
            this.btCancelar.Visible = false;
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
                vehiculo v = this.lboListaVehiculos.SelectedItem as vehiculo;
                Form mostrarVehiculo = new formularioVehiculo(v.NBastidor, enumObjetivo.Ver);
                mostrarVehiculo.Show();
                //mostrar vehículo como en búsqueda vehículo
            }
        }

        private void btIntroducirVehiculo_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            FormIntroducirNBastidorPresupuesto introducirVehiculo = new FormIntroducirNBastidorPresupuesto("introducir");
            introducirVehiculo.ShowDialog();
            vehiculo v = introducirVehiculo.Vehiculo;
            if (v != null)
            {
                this.listaVehiculosCrear.Add(v);
                bindingSource.DataSource = this.listaVehiculosCrear;
                this.lboListaVehiculos.DataSource = bindingSource;
                this.lboListaVehiculos.DisplayMember = "NBastidor";
            }
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
                bool continuar = true;

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
                    estado = EstadoPresupuesto.desestimado; 
                }
                else if (this.rbPendiente.Checked == true)
                {
                    estado = EstadoPresupuesto.pendiente;
                }

                int i = 0;
                foreach (RadioButton r in this.gbEstado.Controls)
                {
                    if (r.Checked == false)
                    {
                        i++;
                    }
                }

                if (i == 4)
                {
                    DialogResult result2 = MessageBox.Show("Se seleccionará automáticamente el estado de creado para presupuesto.", "No ha seleccionado ningún estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result2 == DialogResult.Cancel)
                    {
                        continuar = false;
                    }else
                    {
                        this.rbCreado.Checked = true;
                    }
                }

                if ((this.lboListaVehiculos.Items.Count == 0) && (continuar == true))
                {
                    vehiculoCorrecto = false;
                    MessageBox.Show("Introduzca al menos un vehículo en el presupuesto.", "No ha introducido ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if ((vehiculoCorrecto == true) && (continuar ==true))
                {
                    // ERROR List<vehiculo> listaVehiculos = new List<vehiculo>((IEnumerable<vehiculo>)this.lboListaVehiculos.Items);
                    /*List<vehiculo> listaVehiculos = new List<vehiculo>();
                    foreach (Object o in this.lboListaVehiculos.Items)
                    {
                        vehiculo v = o as vehiculo;
                        listaVehiculos.Add(v);
                    }*/
                    Presupuesto nuevoPresupuesto = new Presupuesto(DateTime.Now, estado, this.cliente, this.listaVehiculosCrear);
                    if(LNPresupuesto.INSERT(nuevoPresupuesto) == true)
                    {
                        this.presupuesto = nuevoPresupuesto;
                        this.ParentForm.Close();
                        MessageBox.Show("Presupuesto para " + this.presupuesto.Cliente.getDNI + " creado.", "El presupuesto ha sido creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }            
                } 
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.EXIST(this.presupuesto) == false) //crear //COMPLETAR con si el presupuesto de ha creado no mostrar lo siguiente
                                                                //es decir, hacer existe por cliente en presupuesto (cambiar BD) para busqueda por cliente
                                                                //hacer existe por nbastidor en presupuesto (cambiar BD) para busqueda por vehiculo
                                                                //hacer existe por esatdo en presupuesto (cmabiar BD) para busqueda por estado
            {
                DialogResult result = MessageBox.Show("¿Quieres salir sin terminar el presupuesto?", "No se ha completado el presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.ParentForm.Close();
                }
            }
        }

        private void rbDesestimado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbDesestimado.Checked == true)
            {
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que el estado del presupuesto es desestimado?", "Esta creando un presupuesto desestimado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result1 == DialogResult.No)
                {
                    this.rbDesestimado.Checked = false;
                }
            }
        }

        private void btQuitarVehiculo_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            if (this.lboListaVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para quitarlo.", "No ha seleccionado ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Deseas quitarlo también de la base de datos?", "Dar de baja vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LNVehiculo.DELETE(this.lboListaVehiculos.SelectedItem as vehiculo);
                }
                
                this.listaVehiculosCrear.Remove(this.lboListaVehiculos.SelectedItem as vehiculo);
                bindingSource.DataSource = this.listaVehiculosCrear;
                this.lboListaVehiculos.DataSource = bindingSource;
                this.lboListaVehiculos.DisplayMember = "NBastidor";
            }
        }
    }
}
