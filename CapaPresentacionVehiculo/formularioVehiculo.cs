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
            if (this.radioButton_nuevo.Checked == true)
            {
                BindingSource bindingSourceExtras = new BindingSource();

                this.lista_extras = new ListBox();
                lista_extras.Location = new Point(450, 184);
                bindingSourceExtras.DataSource = listaExtras.Extras;
                lista_extras.DataSource = bindingSourceExtras;
                lista_extras.SelectionMode = SelectionMode.MultiSimple;

                lista_extras.DisplayMember = "Descripcion";      // esto es para indicarle que propiedad se muestra de la data source asociada. que es la pera

                this.Controls.Add(this.lista_extras);
            }
            else
            {
                this.lista_extras.Visible = false;
            }
            

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if ( this.radioButton_nuevo.Checked == true)
            {

                vehiculoNuevo auxiliar_vehiculo_nuevo = new vehiculoNuevo(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheNuevo);
                foreach(object object_extra in this.lista_extras.SelectedItems)
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
            else if ( this.radioButton_2mano.Checked == true)
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

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_2mano_CheckedChanged(object sender, EventArgs e)
        {

            if ( this.radioButton_2mano.Checked == true)
            {
                this.datos_2mano = new Datos2Mano();
                this.datos_2mano.Location = new Point(450, 184);
                this.Controls.Add(this.datos_2mano);
            }
            else
            {
                this.datos_2mano.Visible = false;
            }
            
        }


        private void cargar_Vehiculo()
        {
            vehiculo auxiliar;
            LNVehiculo.READ(new vehiculoNuevo(this.textBox_NBastidor.Text), out auxiliar);

            if (auxiliar is vehiculoNuevo)
            {
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
                vehiculo2Mano auxiliar_2mano = auxiliar as vehiculo2Mano;
                this.textBox_Marca.Text = auxiliar_2mano.Marca;
                this.textBox_Marca.ReadOnly = true;

                this.textBox_Modelo.Text = auxiliar_2mano.Modelo;
                this.textBox_Modelo.ReadOnly = true;

                this.textBox_Potencia.Text = auxiliar_2mano.Potencia.ToString();
                this.textBox_Potencia.ReadOnly = true;

                this.textBox_PrecioRecomendado.Text = auxiliar_2mano.PrecioRecomendado.ToString();
                this.textBox_PrecioRecomendado.ReadOnly = true;

                this.datos_2mano = new Datos2Mano();
                this.datos_2mano.Location = new Point(450, 184);
                this.Controls.Add(this.datos_2mano);

                this.datos_2mano.Matricula = auxiliar_2mano.Matricula;
                this.datos_2mano.FechaMatriculacion = auxiliar_2mano.FechaMatriculacion.Date.ToString();

                this.datos_2mano.cerrar_modificacion();
   
            }

            this.button_aceptar.Visible = false;
        }
    }
}
