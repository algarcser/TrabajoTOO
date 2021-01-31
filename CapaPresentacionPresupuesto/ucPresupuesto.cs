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
using LogicaNegocioCliente;
using CapaPresentacionCliente;
using CapaPresentacionVehiculo;


namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Control de usuario con multifuncionalidad, permite mostrar, modificar y crear un Presupuesto a traves de los distintos Form.
    /// Cambiando la visibilidad o el comportamiento de sus controles. Es el núcleo que hace funcionar presupuesto.
    /// En modificar Presupuesto cada cambio que hagas en directo, se aplicara automaticament al presupuesto en la BD, dándote advertencias
    /// de ello, claro esta.
    /// </summary>
    public partial class ucPresupuesto : UserControl
    {
        private Cliente cliente; //Cliente asociado al presupuesto que no sea null indica que estamos creando un Presupuesto.
        private List<vehiculo> listaVehiculosCrear = new List<vehiculo>(); //Lista de vehículos que se asocia al presupuesto a la hora de crearlo.
        private List<vehiculo> listaVehiculosModificar = new List<vehiculo>(); //Lista de vehículos con la que se modifica el presupuesto.
        private string comercial; //Comercial asociado al presupuetso y usuario de la aplicación.
        private Presupuesto presupuesto; //Presupuesto que no es null indica que estamos mostrando o mostrando y modificando un presupuesto.
        private bool modificar; //bool que indica si se modifica se modifica el presupuesto cuando se muestra o no (true o false).

        /// <summary>
        /// Constructor de ucPresupuesto, para crear un presupuesto.
        /// PRE: Requiere Cliente c y string comercial.
        /// POST:
        /// </summary>
        public ucPresupuesto(Cliente c, string comercial) //crear
        {
            this.cliente = c;
            this.comercial = comercial;
            
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
            this.btQuitarVehiculo.Visible = true;
            this.lboListaVehiculos.Enabled = true;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaVehiculosCrear;
            this.lboListaVehiculos.DataSource = bindingSource;
            this.lboListaVehiculos.DisplayMember = "NBastidor";
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = false;
            this.tbImporte.Visible = false;

            this.btAceptar.Visible = true;
            this.btCancelar.Visible = true;
        }

        /// <summary>
        /// Constructor de ucPresupuesto, para mostrar o mostrar y modificar un presupuesto.
        /// PRE: Requiere Presupuesto p y bool mod.
        /// POST:
        /// </summary>
        public ucPresupuesto(Presupuesto p, bool mod) //mostrar
        {
            this.presupuesto = p;
            this.modificar = mod;
            
            InitializeComponent();

            this.lbFechaCreacion.Visible = true;
            this.lbFechaCreacion.Text = "Fecha de creación: " + this.presupuesto.FechaRealizacion.ToString();

            this.tbDNI.ReadOnly = true;
            this.tbDNI.Text = this.presupuesto.Cliente.getDNI;
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Text = this.presupuesto.Cliente.getNombre;
            this.btMostrarCliente.Visible = true;
            //cambio en los controles dependiendo de que se modifique o no el presupuesto
            if (this.modificar == true) //para el recorrido 1 a 1 donde se modifica
            {
                this.listaVehiculosModificar = this.presupuesto.ListaVehiculos;
                this.gbEstado.Enabled = true;
                this.rbCreado.AutoCheck = true;
                this.rbAceptado.AutoCheck = true;
                this.rbPendiente.AutoCheck = true;
                this.rbDesestimado.AutoCheck = true;
                this.btIntroducirVehiculo.Visible = true;
                this.btQuitarVehiculo.Visible = true;
            }
            else //para el mostrar presupuesto
            {
                this.gbEstado.Enabled = true;
                this.rbCreado.AutoCheck = false;
                this.rbAceptado.AutoCheck = false;
                this.rbPendiente.AutoCheck = false;
                this.rbDesestimado.AutoCheck = false;
                this.btIntroducirVehiculo.Visible = false;
                this.btQuitarVehiculo.Visible = false;
            }
            
            LNPresupuesto.actualizarEstado(this.presupuesto);
            if ((int)this.presupuesto.EstadoPresupuesto == 0)
            {
                this.rbCreado.Checked = true;
            }
            else if ((int)this.presupuesto.EstadoPresupuesto == 1)
            {
                this.rbAceptado.Checked = true;
            }
            else if ((int)this.presupuesto.EstadoPresupuesto == 2)
            {
                this.rbDesestimado.Checked = true;
            }
            else if ((int)this.presupuesto.EstadoPresupuesto == 3)
            {
                this.rbPendiente.Checked = true;
            }
            
            this.lboListaVehiculos.Enabled = true;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.presupuesto.ListaVehiculos;
            this.lboListaVehiculos.DataSource = bindingSource;
            this.lboListaVehiculos.SelectionMode = SelectionMode.One;
            this.lboListaVehiculos.DisplayMember = "NBastidor";
            this.btMostrarVehiculo.Visible = true;

            this.lbImporte.Visible = true;
            this.tbImporte.Visible = true;
            this.tbImporte.Text = LNPresupuesto.calcularPresupuesto(this.presupuesto).ToString() + " €";
            this.btAceptar.Visible = true;
            this.btCancelar.Visible = false;
        }

        /// <summary>
        /// Método que en el recorrido de 1 a 1 permite cambiar el presupuesto qeu se muestra y se modifica junto con el BindingNavigator.
        /// PRE: Requiere Presupuesto p no null.
        /// POST:
        /// </summary>
        public void cambiarPresupuesto (Presupuesto p) //solo para modificar
        {
            if ((this.modificar == true) && (p != null))
            {
                this.presupuesto = p;

                this.lbFechaCreacion.Text = "Fecha de creación: " + this.presupuesto.FechaRealizacion.ToString();
                this.tbDNI.Text = this.presupuesto.Cliente.getDNI;
                this.tbNombre.Text = this.presupuesto.Cliente.getNombre;
                this.listaVehiculosModificar = this.presupuesto.ListaVehiculos;

                LNPresupuesto.actualizarEstado(this.presupuesto);
                if ((int)this.presupuesto.EstadoPresupuesto == 0)
                {
                    this.rbCreado.Checked = true;
                }
                else if ((int)this.presupuesto.EstadoPresupuesto == 1)
                {
                    this.rbAceptado.Checked = true;
                }
                else if ((int)this.presupuesto.EstadoPresupuesto == 2)
                {
                    this.rbDesestimado.Checked = true;
                }
                else if ((int)this.presupuesto.EstadoPresupuesto == 3)
                {
                    this.rbPendiente.Checked = true;
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = this.presupuesto.ListaVehiculos;
                this.lboListaVehiculos.DataSource = bindingSource;
                this.lboListaVehiculos.SelectionMode = SelectionMode.One;
                this.lboListaVehiculos.DisplayMember = "NBastidor";

                this.tbImporte.Text = LNPresupuesto.calcularPresupuesto(this.presupuesto).ToString() + " €";
            }          
        }

        /// <summary>
        /// Evento que te permite mostrar la información completa de un cliente mostrando o creando un Presupuesto.
        /// </summary>
        private void btMostrarCliente_Click(object sender, EventArgs e)
        {
            if (this.cliente == null) //mostrar
            {
                if (LNCliente.existeCliente(this.presupuesto.Cliente) == true)
                {
                    Form mostrarCliente = new Busqueda_cliente(this.presupuesto.Cliente);
                    mostrarCliente.Show();
                }
                else
                {
                    MessageBox.Show("El cliente ha sido eliminado de la base de datos, por lo que no se puede mostrar.", "No se puede mostrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            else //crear
            {
                if (LNCliente.existeCliente(this.cliente) == true)
                {
                    Form mostrarCliente = new Busqueda_cliente(this.cliente);
                    mostrarCliente.Show();
                }
                else
                {
                    MessageBox.Show("El cliente ha sido eliminado de la base de datos, por lo que no se puede mostrar.", "No se puede mostrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Evento que te permite mostrar el vehículo seleccionado de la ListBox, si lo ahs seleccionado, tanto mostrando como creando un Presupuesto.
        /// </summary>
        private void btMostrarVehiculo_Click(object sender, EventArgs e)
        {
            if (this.lboListaVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para mostrarlo.", "No ha seleccionado ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vehiculo v = this.lboListaVehiculos.SelectedItem as vehiculo;
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

        /// <summary>
        /// Evento que te permite introducir un vehículo por medio de IntroducirNBastidorPresupuesto cuando creas o modificas un presupuesto si
        /// existe en la BD, y si no te da la opción de darlo de alta antes de introducirlo en la ListBox.
        /// </summary>
        private void btIntroducirVehiculo_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            if (this.modificar == true) //modificando
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de que quiere introducir un vehículo nuevo en el presupuesto?", "Va a modificar la lista de vehículos del presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FormIntroducirNBastidorPresupuesto introducirVehiculo = new FormIntroducirNBastidorPresupuesto("introducir");
                    introducirVehiculo.ShowDialog();
                    vehiculo v = introducirVehiculo.Vehiculo;
                    if (v != null)
                    {
                        this.listaVehiculosModificar.Add(v);
                        bindingSource.DataSource = this.listaVehiculosModificar;
                        this.lboListaVehiculos.DataSource = bindingSource;
                        this.lboListaVehiculos.DisplayMember = "NBastidor";
                        
                        if (LNPresupuesto.cambiarListaVehiculos(this.presupuesto, this.listaVehiculosModificar) == true)
                        {
                            this.tbImporte.Text = LNPresupuesto.calcularPresupuesto(this.presupuesto).ToString() + " €";
                            MessageBox.Show("Se ha cambiado la lista de vehículos del presupuesto.", "Presupuesto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else //creando
            {
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
            }
        }

        /// <summary>
        /// Evento que te permite cerra el formulario si ya has dejado de modificar o mostrar el presupuesto o crear el presupuesto. Para
        /// crear un presupuetso va revisando ciertos requerimientos, indicandote si falla alguno en cualqueir caso.
        /// </summary>
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
                        estado = EstadoPresupuesto.creado;
                    }
                }

                if ((this.lboListaVehiculos.Items.Count == 0) && (continuar == true))
                {
                    vehiculoCorrecto = false;
                    MessageBox.Show("Introduzca al menos un vehículo en el presupuesto.", "No ha introducido ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if ((vehiculoCorrecto == true) && (continuar ==true))
                {
                    Presupuesto nuevoPresupuesto = new Presupuesto(DateTime.Now, estado, this.cliente, this.listaVehiculosCrear);
                    nuevoPresupuesto.Comercial = this.comercial;

                    List<float> listaImportes = nuevoPresupuesto.Cliente.Importes;
                    listaImportes.Add(LNPresupuesto.calcularPresupuesto(nuevoPresupuesto));
                    nuevoPresupuesto.Cliente.Importes = listaImportes;
                    LNCliente.updateCliente(nuevoPresupuesto.Cliente);
                    
                    if (LNPresupuesto.INSERT(nuevoPresupuesto) == true)
                    {
                        this.presupuesto = nuevoPresupuesto;
                        this.ParentForm.Close();
                        MessageBox.Show("Presupuesto para " + this.presupuesto.Cliente.getDNI + " creado.", "El presupuesto ha sido creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }            
                } 
            }
        }

        /// <summary>
        /// Evento que te permite cancelar la creación de un presupuesto cerranod el formulario y te avisa anets de proceder.
        /// </summary>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.EXIST(this.presupuesto) == false)
            {
                DialogResult result = MessageBox.Show("¿Quieres salir sin terminar el presupuesto?", "No se ha completado el presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.ParentForm.Close();
                }
            }
        }

        /// <summary>
        /// Evento que sirve para indicarte qeu estas creando un formulario directamente desestimado y para avisarte de que vas a cambiar 
        /// a ese estado cuando estas modificando un presupuesto.
        /// </summary>
        private void rbDesestimado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.presupuesto == null) //crear
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
            else if ((this.presupuesto.EstadoPresupuesto != EstadoPresupuesto.desestimado) && (this.modificar == true) && (this.rbDesestimado.Checked == true))
            {
                EstadoPresupuesto estado = EstadoPresupuesto.desestimado;
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que quiere cambiar el estado del presupuesto de " + this.presupuesto.EstadoPresupuesto.ToString() + " a " + estado.ToString() + "?", "Esta cambiando el estado del presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes)
                {
                    if (LNPresupuesto.cambiarEstado(this.presupuesto, estado) == true)
                    {
                        MessageBox.Show("Se ha cambiado el estado del presupuesto a " + estado.ToString() + ".", "Presupuesto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result1 == DialogResult.No)
                {
                    this.rbDesestimado.Checked = false;
                    if ((int)this.presupuesto.EstadoPresupuesto == 0)
                    {
                        this.rbCreado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 1)
                    {
                        this.rbAceptado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 2)
                    {
                        this.rbDesestimado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 3)
                    {
                        this.rbPendiente.Checked = true;
                    }
                }
            }          
        }

        /// <summary>
        /// Evento qeu te permite quitar un vehiculo de la Lista de vehículos del presupuesto cuando lo estas creanod, o cuando lo estas
        /// modificando si es que queda al menos más de un vehículo en las Lista.
        /// </summary>
        private void btQuitarVehiculo_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            if (this.lboListaVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para quitarlo.", "No ha seleccionado ningún vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (modificar == true) //modificar
                {
                    if (this.presupuesto.ListaVehiculos.Count == 1)
                    {
                        MessageBox.Show("No puede dejar un presupuesto sin vehículos, añada otro y para después eliminar el seleccionado.", "Solo hay un vehículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //crear
                    {
                        DialogResult result = MessageBox.Show("¿Esta seguro de que quiere eliminar un vehículo del presupuesto?", "Va a modificar la lista de vehículos del presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            this.listaVehiculosModificar.Remove(this.lboListaVehiculos.SelectedItem as vehiculo);
                            bindingSource.DataSource = this.listaVehiculosModificar;
                            this.lboListaVehiculos.DataSource = bindingSource;
                            this.lboListaVehiculos.DisplayMember = "NBastidor";

                            if (LNPresupuesto.cambiarListaVehiculos(this.presupuesto, this.listaVehiculosModificar) == true)
                            {
                                this.tbImporte.Text = LNPresupuesto.calcularPresupuesto(this.presupuesto).ToString() + " €";
                                MessageBox.Show("Se ha cambiado la lista de vehículos del presupuesto.", "Presupuesto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }  
                }
                else
                {
                    this.listaVehiculosCrear.Remove(this.lboListaVehiculos.SelectedItem as vehiculo);
                    bindingSource.DataSource = this.listaVehiculosCrear;
                    this.lboListaVehiculos.DataSource = bindingSource;
                    this.lboListaVehiculos.DisplayMember = "NBastidor";
                }             
            }
        }

        /// <summary>
        /// Evento que sirve para avisarte de que vas a cambiar a ese estado cuando estas modificando un presupuesto, y te advierte de ello.
        /// </summary>
        private void rbCreado_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.cliente == null) && (this.presupuesto.EstadoPresupuesto != EstadoPresupuesto.creado) && (this.modificar == true) && (this.rbCreado.Checked == true))
            {
                EstadoPresupuesto estado = EstadoPresupuesto.creado;
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que quiere cambiar el estado del presupuesto de " + this.presupuesto.EstadoPresupuesto.ToString() + " a " + estado.ToString() + "?", "Esta cambiando el estado del presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes)
                {
                    if (LNPresupuesto.cambiarEstado(this.presupuesto, estado) == true)
                    {
                        MessageBox.Show("Se ha cambiado el estado del presupuesto a " + estado.ToString() + ".", "Presupuesto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result1 == DialogResult.No)
                {
                    this.rbCreado.Checked = false;
                    if ((int)this.presupuesto.EstadoPresupuesto == 0)
                    {
                        this.rbCreado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 1)
                    {
                        this.rbAceptado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 2)
                    {
                        this.rbDesestimado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 3)
                    {
                        this.rbPendiente.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// Evento que sirve para avisarte de que vas a cambiar a ese estado cuando estas modificando un presupuesto, y te advierte de ello.
        /// </summary>
        private void rbPendiente_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.cliente == null) && (this.presupuesto.EstadoPresupuesto != EstadoPresupuesto.pendiente) && (this.modificar == true) && (this.rbPendiente.Checked == true))
            {
                EstadoPresupuesto estado = EstadoPresupuesto.pendiente;
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que quiere cambiar el estado del presupuesto de " + this.presupuesto.EstadoPresupuesto.ToString() + " a " + estado.ToString() + "?", "Esta cambiando el estado del presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes)
                {
                    if (LNPresupuesto.cambiarEstado(this.presupuesto, estado) == true)
                    {
                        MessageBox.Show("Se ha cambiado el estado del presupuesto a " + estado.ToString() + ".", "Presupuesto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result1 == DialogResult.No)
                {
                    this.rbPendiente.Checked = false;
                    if ((int)this.presupuesto.EstadoPresupuesto == 0)
                    {
                        this.rbCreado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 1)
                    {
                        this.rbAceptado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 2)
                    {
                        this.rbDesestimado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 3)
                    {
                        this.rbPendiente.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// Evento que sirve para avisarte de que vas a cambiar a ese estado cuando estas modificando un presupuesto, y te advierte de ello.
        /// </summary>
        private void rbAceptado_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.cliente == null) && (this.presupuesto.EstadoPresupuesto != EstadoPresupuesto.aceptado) && (this.modificar == true) && (this.rbAceptado.Checked == true))
            {
                EstadoPresupuesto estado = EstadoPresupuesto.aceptado;
                DialogResult result1 = MessageBox.Show("¿Esta seguro de que quiere cambiar el estado del presupuesto de " + this.presupuesto.EstadoPresupuesto.ToString() + " a " + estado.ToString() + "?", "Esta cambiando el estado del presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes)
                {
                    if (LNPresupuesto.cambiarEstado(this.presupuesto, estado) == true)
                    {
                        MessageBox.Show("Se ha cambiado el estado del presupuesto a " + estado.ToString() + ".", "Presupuesto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result1 == DialogResult.No)
                {
                    this.rbAceptado.Checked = false;
                    if ((int)this.presupuesto.EstadoPresupuesto == 0)
                    {
                        this.rbCreado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 1)
                    {
                        this.rbAceptado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 2)
                    {
                        this.rbDesestimado.Checked = true;
                    }
                    else if ((int)this.presupuesto.EstadoPresupuesto == 3)
                    {
                        this.rbPendiente.Checked = true;
                    }
                }
            }
        }
    }
}
