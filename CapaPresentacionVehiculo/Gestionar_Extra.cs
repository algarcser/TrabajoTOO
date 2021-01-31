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

namespace CapaPresentacionVehiculo
{
    public partial class Gestionar_Extra : Form
    {
        private enumObjetivo objetivo;

        /// <summary>
        /// constructor de un form gestionar extra
        /// </summary>
        public Gestionar_Extra()
        {

            InitializeComponent();

        }

        /// <summary>
        /// funcion que ciera el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// funcion que define el comportamiento del boton aceptar cuando se clica
        /// comprueba que los datons han sido introducidos correctamente, y en caso de que sea asi introduce el extra en la base de datos, lo construye de manera correcta y le asigna una id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (this.Fields_correct())
            {
                LNExtras.INSERT(new extra(LNExtras.COUNT() + 1, this.textBox_descripcion.Text, float.Parse(this.TextBox_Precio.Text)));
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos no validos");
            }
            
        }


        /// <summary>
        /// funcion que comprueba que los datos introducidos en precio sean solo un numero real
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_precio_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// funcion que comprueba que los campos hayan sido rellenados de manera correcta, y que no hayan campos vacios
        /// </summary>
        /// <returns></returns>
        private bool Fields_correct()
        {
            return (  (this.textBox_descripcion.Text != "") && (this.TextBox_Precio.Text != "") );
        }
    }
}
