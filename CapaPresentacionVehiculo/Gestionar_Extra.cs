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
            LNExtras.INSERT(new extra( LNExtras.COUNT() + 1, this.textBox_descripcion.Text, float.Parse(this.textBox_precio.Text)));
            this.Close();
        }
    }
}
