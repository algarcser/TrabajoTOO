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
        public Gestionar_Extra()
        {

            InitializeComponent();

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private bool Fields_correct()
        {
            return (  (this.textBox_descripcion.Text != "") && (this.TextBox_Precio.Text != "") );
        }
    }
}
