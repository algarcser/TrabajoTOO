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
            if ( this.maskedTextBox_NBastidor.MaskCompleted)
            {
                if ((this.objetivo != enumObjetivo.Alta) && (LogicaNegocioVehiculo.LNVehiculo.EXISTS(new LogicaModeloVehiculo.vehiculoNuevo(this.maskedTextBox_NBastidor.Text))))
                {
                    formularioVehiculo formularioVehiculo = new formularioVehiculo(this.maskedTextBox_NBastidor.Text, this.objetivo);
                    formularioVehiculo.Show();
                    this.Close();
                }
                else if ((this.objetivo == enumObjetivo.Alta) && (!LogicaNegocioVehiculo.LNVehiculo.EXISTS(new LogicaModeloVehiculo.vehiculoNuevo(this.maskedTextBox_NBastidor.Text))))
                {
                    formularioVehiculo formularioVehiculo = new formularioVehiculo(this.maskedTextBox_NBastidor.Text, this.objetivo);
                    formularioVehiculo.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("El numero de bastidor no esta completo");
            }
            
            

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerNBastidor_Load(object sender, EventArgs e)
        {
            maskedTextBox_NBastidor.Mask = ">AAAAAAAAAAAAAAAAA";

        }

        private void maskedTextBox_NBastidor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox_NBastidor.MaskFull)
            {
                toolTip_NBastidor.ToolTipTitle = "Num Bastidor rechazado - Demasiada información";
                toolTip_NBastidor.Show("No puede introducir más información en el campo DNI. Elimine algunos caracteres para poder introducir más datos.", maskedTextBox_NBastidor, 120, 10, 5000);
            }
            else if (e.Position == maskedTextBox_NBastidor.Mask.Length)
            {
                toolTip_NBastidor.ToolTipTitle = "Num Bastidor rechazado - Tamaño alcanzado";
                toolTip_NBastidor.Show("No puede añadir más caracteres al final del campo DNI", maskedTextBox_NBastidor, 120, 10, 5000);
            }
            else
            {
                toolTip_NBastidor.ToolTipTitle = "Num Bastidor rechazado";
                toolTip_NBastidor.Show("Solo pueden introducir ocho caracteres numéricos (0-9) seguidos de una letra [a-zA-Z] en el campo DNI.", maskedTextBox_NBastidor, 120, 10, 5000);
            }
        }

        private void maskedTextBox_NBastidor_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip_NBastidor.Hide(maskedTextBox_NBastidor);
        }
    }
}
