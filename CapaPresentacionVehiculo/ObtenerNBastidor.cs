using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionVehiculo
{
    public partial class ObtenerNBastidor : Form
    {
        private enumObjetivo objetivo;
        public ObtenerNBastidor(enumObjetivo objetivo)
        {
            InitializeComponent();
            this.objetivo = objetivo;
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            formularioVehiculo anadirVehiculo = new formularioVehiculo(this.textBox_NBastidor.Text, this.objetivo);
            anadirVehiculo.Show();
            this.Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
