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

        /// <summary>
        /// construcor del formulario obeneter bastidor
        /// </summary>
        /// <param name="objetivo"></param>
        public ObtenerNBastidor(enumObjetivo objetivo)
        {
            InitializeComponent();
            this.objetivo = objetivo;
            
        }

        /// <summary>
        /// funcion que controla el comportancion de clicar en aceptar
        /// comprueba se haya introducido el num de bastidor de forma correcta, y si la operacion que se quiere hacer se puede realizar
        /// si se quiere mostrar o dar de baja, mira si esta en la base de datos
        /// y si se quiere dar de alta comrprueba que no este en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// funcion que si se clica se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// carga el mask que se quiere para obtener el numero de bastidor y que se corresponda con uno real
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObtenerNBastidor_Load(object sender, EventArgs e)
        {
            maskedTextBox_NBastidor.Mask = ">AAAAAAAAAAAAAAAAA";

        }

        /// <summary>
        /// define el comportamiento en caso de que se introduzcan datos erroneos para el numero de bastidor
        /// y muestra el mensaje de error se muestra segun el tipo de error que se haya cometido en la entrada de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ayuda a definir el comportamiento del masked textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox_NBastidor_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip_NBastidor.Hide(maskedTextBox_NBastidor);
        }
    }
}
