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
    public partial class Recorrido1a1_vehiculos : Form
    {

        private List<vehiculo> vehiculos;

        public Recorrido1a1_vehiculos()
        {
            InitializeComponent();
            this.vehiculos = LNVehiculo.SELECT_ALL();
            BindingSource binding_Vehiculos = new BindingSource();
            binding_Vehiculos.DataSource = this.vehiculos;
            this.bindingNavigator_Vehiculos.BindingSource = binding_Vehiculos;
            this.Mostrar_vehiculo(1);
        }

        private void Mostrar_vehiculo(int posicion)
        {
            if( (this.bindingNavigator_Vehiculos.BindingSource.Count >= posicion)   &&  (posicion > 0))
            {
                vehiculo c = this.vehiculos[posicion - 1];
                if (c is vehiculoNuevo)
                {
                    vehiculoNuevo auxiliar_nuevo = c as vehiculoNuevo;
                    this.datos2Mano1.Visible = false;
                    this.listBox1.DataSource = auxiliar_nuevo.Extras;
                    this.radioButton_nuevo.Checked = true;
                    this.radioButton_2mano.Checked = false;
                }
                else if(c is vehiculo2Mano)
                {
                    vehiculo2Mano auxiliar_2Mano = c as vehiculo2Mano;
                    this.listBox1.Visible = false;
                    this.radioButton_nuevo.Checked = false;
                    this.radioButton_2mano.Checked = true;
                    this.datos2Mano1.Matricula = auxiliar_2Mano.Matricula;
                    this.datos2Mano1.FechaMatriculacion = auxiliar_2Mano.FechaMatriculacion.ToString();
                }

                this.textBox_NBastidor.Text = c.NBastidor;
                this.textBox_Marca.Text = c.Marca;
                this.textBox_Modelo.Text = c.Modelo;
                this.textBox_Potencia.Text = c.Potencia.ToString();
                this.textBox_PrecioRecomendado.Text = c.PrecioRecomendado.ToString();
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(Convert.ToInt32(this.bindingNavigatorPositionItem.Text) );
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(1);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(Convert.ToInt32(this.bindingNavigatorPositionItem.Text) );
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(this.bindingNavigator_Vehiculos.BindingSource.Count);
        }

        private void Actualizar()
        {
            if ( this.radioButton_nuevo.Checked)
            {
                vehiculoNuevo auxiliarNuevo = new vehiculoNuevo(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheNuevo);
                foreach(object item in this.listBox1.Items)
                {
                    extra auxiliar_extra = item as extra;
                    auxiliarNuevo.AddExtra(auxiliar_extra);
                }
                LNVehiculo.UPDATE(auxiliarNuevo);
            }
            else if( this.radioButton_2mano.Checked)
            {
                vehiculo2Mano auxiliar2Mano = new vehiculo2Mano(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheSegundaMano, this.datos2Mano1.Matricula, DateTime.Parse(this.datos2Mano1.FechaMatriculacion));
                LNVehiculo.UPDATE(auxiliar2Mano);
            }
        }

        private void textBox_Potencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
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
    }
}
