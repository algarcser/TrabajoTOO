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
using LogicaNegocioVehiculo;

namespace CapaPresentacionVehiculo
{
    public partial class formularioVehiculo : Form
    {
        private ListBox lista_extras;
        private Datos2Mano datos_2mano;
        private enumObjetivo objetivo;


        public formularioVehiculo(string nBastidor, enumObjetivo objetivo)
        {
            InitializeComponent();
            this.textBox_NBastidor.Text = nBastidor;
            this.textBox_NBastidor.ReadOnly = true;
            this.objetivo = objetivo;

            if ( this.objetivo == enumObjetivo.Alta)
            {
                this.Text = "Dar de alta";
            }else if ( this.objetivo == enumObjetivo.Baja)
            {
                this.Text = "Dar de baja";
                this.cargar_Vehiculo();
                LNVehiculo.DELETE( new vehiculoNuevo(this.textBox_NBastidor.Text.ToString() ));
            }else if ( this.objetivo == enumObjetivo.Ver)
            {
                this.Text = "Consultar vehiculo";
                this.cargar_Vehiculo();
            }

            
        }

        private void radioButton_nuevo_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.radioButton_nuevo.Checked == true) && (this.objetivo == enumObjetivo.Alta))
            {
                BindingSource bindingSourceExtras = new BindingSource();

                this.lista_extras = new ListBox();
                lista_extras.Location = new Point(450, 184);
                bindingSourceExtras.DataSource = LNExtras.SELECT_ALL();
                lista_extras.DataSource = bindingSourceExtras;
                lista_extras.SelectionMode = SelectionMode.MultiSimple;

                lista_extras.DisplayMember = "Descripcion";      // esto es para indicarle que propiedad se muestra de la data source asociada. que es la pera

                this.Controls.Add(this.lista_extras);
            }
            else
            {
                if (this.lista_extras != null)
                {
                       this.lista_extras.Visible = false;
                }
                
            }
            

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (this.Lectura_Correcta())  // comprobamos que todos los campos han sido rellenados correctamente
            {
                if (this.radioButton_nuevo.Checked == true)
                {

                    vehiculoNuevo auxiliar_vehiculo_nuevo = new vehiculoNuevo(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheNuevo);
                    foreach (object object_extra in this.lista_extras.SelectedItems)
                    {
                        extra extra = object_extra as extra;
                        auxiliar_vehiculo_nuevo.AddExtra(extra);

                    }
                    if (LNVehiculo.INSERT(auxiliar_vehiculo_nuevo))
                    {
                        MessageBox.Show("operacion con exito");
                    }
                    this.Close();
                }
                else if (this.radioButton_2mano.Checked == true)
                {
                    vehiculo2Mano auxiliar_vehiculo_2mano = new vehiculo2Mano(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheSegundaMano, this.datos_2mano.Matricula, DateTime.Parse(this.datos_2mano.FechaMatriculacion));

                    if (LNVehiculo.INSERT(auxiliar_vehiculo_2mano))
                    {
                        MessageBox.Show("operacion con exito");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha de seleccionar un tipo de coche");
                }
            }
            else
            {
                MessageBox.Show("Faltan campos sin rellenar");
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_2mano_CheckedChanged(object sender, EventArgs e)
        {

            if ( this.radioButton_2mano.Checked == true)
            {
                this.datos_2mano = new Datos2Mano();
                this.datos_2mano.Location = new System.Drawing.Point(374, 181);
                this.Controls.Add(this.datos_2mano);
            }
            else
            {
                this.datos_2mano.Visible = false;
            }
            
        }

        private bool Lectura_Correcta()
        {
            return ( this.textBox_Modelo.Text != "") && (this.textBox_Marca.Text != "") && (this.textBox_Potencia.Text != "") && (this.textBox_PrecioRecomendado.Text != "") && (this.datos_2mano.Lectura_Correcta());
        }

        private void cargar_Vehiculo()
        {
            vehiculo auxiliar;
            LNVehiculo.READ(new vehiculoNuevo(this.textBox_NBastidor.Text), out auxiliar);

            if (auxiliar is vehiculoNuevo)
            {
                this.radioButton_nuevo.Checked = true;
                this.radioButton_nuevo.AutoCheck = false;
                this.radioButton_2mano.AutoCheck = false;

                vehiculoNuevo auxiliar_nuevo = auxiliar as vehiculoNuevo;

                this.textBox_Marca.Text = auxiliar_nuevo.Marca;
                this.textBox_Marca.ReadOnly = true;

                this.textBox_Modelo.Text = auxiliar_nuevo.Modelo;
                this.textBox_Modelo.ReadOnly = true;

                this.textBox_Potencia.Text = auxiliar_nuevo.Potencia.ToString();
                this.textBox_Potencia.ReadOnly = true;

                this.textBox_PrecioRecomendado.Text = auxiliar_nuevo.PrecioRecomendado.ToString();
                this.textBox_PrecioRecomendado.ReadOnly = true;


                BindingSource bindingSourceExtras = new BindingSource();

                this.lista_extras = new ListBox();
                lista_extras.Location = new Point(450, 184);
                bindingSourceExtras.DataSource = auxiliar_nuevo.Extras;
                lista_extras.DataSource = bindingSourceExtras;
                lista_extras.SelectionMode = SelectionMode.MultiSimple;

                lista_extras.DisplayMember = "Descripcion";      // esto es para indicarle que propiedad se muestra de la data source asociada. que es la pera
                lista_extras.SelectionMode = SelectionMode.None;

                this.Controls.Add(this.lista_extras);
     
            }
            else if(auxiliar is vehiculo2Mano)
            {

                this.radioButton_2mano.Checked = true;
                this.radioButton_nuevo.AutoCheck = false;
                this.radioButton_nuevo.AutoCheck = false;

                vehiculo2Mano auxiliar_2mano = auxiliar as vehiculo2Mano;
                this.textBox_Marca.Text = auxiliar_2mano.Marca;
                this.textBox_Marca.ReadOnly = true;

                this.textBox_Modelo.Text = auxiliar_2mano.Modelo;
                this.textBox_Modelo.ReadOnly = true;

                this.textBox_Potencia.Text = auxiliar_2mano.Potencia.ToString();
                this.textBox_Potencia.ReadOnly = true;

                this.textBox_PrecioRecomendado.Text = auxiliar_2mano.PrecioRecomendado.ToString();
                this.textBox_PrecioRecomendado.ReadOnly = true;

                this.datos_2mano.Matricula = auxiliar_2mano.Matricula;
                this.datos_2mano.FechaMatriculacion = auxiliar_2mano.FechaMatriculacion.Date.ToString();

                this.datos_2mano.cerrar_modificacion();
   
            }

            this.button_aceptar.Visible = false;
        }

        private void textBox_PrecioRecomendado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox_Potencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }

        }
    }
}
