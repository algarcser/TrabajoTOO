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
    public partial class Recorrido_1_a_1 : Form
    {
        private List<vehiculo> vehiculos;


        /// <summary>
        /// constructor del fomulario
        /// </summary>
        public Recorrido_1_a_1()
        {
            InitializeComponent();
            this.vehiculos = LNVehiculo.SELECT_ALL();
            BindingSource binding_Vehiculos = new BindingSource();
            binding_Vehiculos.DataSource = this.vehiculos;
            this.bindingNavigator_Vehiculos.BindingSource = binding_Vehiculos;
            this.Mostrar_vehiculo(1);
        }

        /// <summary>
        /// muestra el formulario que se le de la posicion indica en la lista de vehiculos que se obtiene de la base de datos
        /// la lista empieza a contar desde el 1, hasta el numero maximpo de elmentos
        /// </summary>
        /// <param name="posicion"></param>
        private void Mostrar_vehiculo(int posicion)
        {
            if ((this.bindingNavigator_Vehiculos.BindingSource.Count >= posicion) && (posicion > 0))
            {
                vehiculo c = this.vehiculos[posicion - 1];
                if (c is vehiculoNuevo)
                {
                    vehiculoNuevo auxiliar_nuevo = c as vehiculoNuevo;
                    this.datos2Mano1.Visible = false;
                    this.listBox1.Visible = true;
                    this.listBox1.DataSource = auxiliar_nuevo.Extras;
                    this.radioButton_nuevo.Checked = true;
                    this.radioButton_2mano.Checked = false;
                }
                else if (c is vehiculo2Mano)
                {
                    vehiculo2Mano auxiliar_2Mano = c as vehiculo2Mano;
                    this.listBox1.Visible = false;
                    this.radioButton_nuevo.Checked = false;
                    this.radioButton_2mano.Checked = true;
                    this.datos2Mano1.Visible = true;
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

        /// <summary>
        /// funcion que muestra el anterior vehiculo en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(Convert.ToInt32(this.bindingNavigatorPositionItem.Text));
        }

        /// <summary>
        /// funcion que muestra el primer vehiculo de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(1);
        }

        /// <summary>
        /// funcino que muestra el siguiente vehiculo de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(Convert.ToInt32(this.bindingNavigatorPositionItem.Text));
        }

        /// <summary>
        /// funcion que muestra el ultimo vehiculo de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            this.Mostrar_vehiculo(this.bindingNavigator_Vehiculos.BindingSource.Count);
        }

        /// <summary>
        /// funcion que actualiza el vehiculo que se muestra en la lista, y guarda los cambio realizados en la base de datos
        /// </summary>
        private void Actualizar()
        {
            if (this.radioButton_nuevo.Checked)
            {
                vehiculoNuevo auxiliarNuevo = new vehiculoNuevo(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheNuevo);
                foreach (object item in this.listBox1.Items)
                {
                    extra auxiliar_extra = item as extra;
                    auxiliarNuevo.AddExtra(auxiliar_extra);
                }
                LNVehiculo.UPDATE(auxiliarNuevo);
            }
            else if (this.radioButton_2mano.Checked)
            {
                vehiculo2Mano auxiliar2Mano = new vehiculo2Mano(this.textBox_NBastidor.Text, this.textBox_Marca.Text, this.textBox_Modelo.Text, float.Parse(this.textBox_Potencia.Text), float.Parse(this.textBox_PrecioRecomendado.Text), iva.cocheSegundaMano, this.datos2Mano1.Matricula, DateTime.Parse(this.datos2Mano1.FechaMatriculacion));
                LNVehiculo.UPDATE(auxiliar2Mano);
            }
        }

        /// <summary>
        /// funcion que solo permite que se escriban numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Potencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// funcino que solo permite que se escriban numero reales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
