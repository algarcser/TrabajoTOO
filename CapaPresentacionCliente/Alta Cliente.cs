using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloCliente;
using LogicaNegocioCliente;

namespace CapaPresentacionCliente
{
    public partial class Alta_Cliente : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="c"></param>
        public Alta_Cliente(Cliente c)
        {
            InitializeComponent();
            //se pone el DNI en solo lectura
            this.control_final_cliente1.DNI_readOnly(true);
            this.control_final_cliente1.setDNI(c.getDNI);

        }

        /// <summary>
        /// Accion que ocurre al hacer click sobre el boton aceptar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Se comprobrueba si todos los campos estan completos, si lo estan se añade el cliente y sale un emnsaje de confirmacion

            if ((this.control_final_cliente1.getNombre() == "") || (this.control_final_cliente1.getApellidos() == "") || (!this.control_final_cliente1.getMaskedTextBox1().MaskFull) || ((!this.control_final_cliente1.getAchecked()) && (!this.control_final_cliente1.getBchecked()) && (!this.control_final_cliente1.getCchecked())))
            {
                MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cl = new Cliente(this.control_final_cliente1.getNombre(), this.control_final_cliente1.getApellidos(), this.control_final_cliente1.getDNI(), this.control_final_cliente1.getCategoria(), int.Parse(this.control_final_cliente1.getTelefono()));
                if (LNCliente.altaCliente(cl))
                {
                    MessageBox.Show("Alta de cliente confirmado");
                }

                this.Close();
            }
  
        }   
        
        /// <summary>
        /// Mensajes del tooltip por si no se cumplen las normas de la mascara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (this.control_final_cliente1.getMaskedTextBox1().MaskFull)
            {
                toolTip1.ToolTipTitle = "DNI rechazado - Demasiada información";
                toolTip1.Show("No puede introducir más información en el campo DNI. Elimine algunos caracteres para poder introducir más datos.", this.control_final_cliente1.getMaskedTextBox1(), 120, 10, 5000);
            }
            else if (e.Position == this.control_final_cliente1.getMaskedTextBox1().Mask.Length)
            {
                toolTip1.ToolTipTitle = "DNI rechazado - Tamaño alcanzado";
                toolTip1.Show("No puede añadir más caracteres al final del campo DNI", this.control_final_cliente1.getMaskedTextBox1(), 120, 10, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "DNI rechazado";
                toolTip1.Show("Solo pueden introducir ocho caracteres numéricos (0-9) seguidos de una letra [a-zA-Z] en el campo DNI.", this.control_final_cliente1.getMaskedTextBox1(), 120, 10, 5000);
            }
        }

        /// <summary>
        /// Evento que esconde el tooltip si se presiona una tecla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(this.control_final_cliente1.getMaskedTextBox1());
        }

        /// <summary>
        /// Accion que ocurre al hacer click sobre el boton cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Inicializa la mascara al cargar el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alta_Cliente_Load(object sender, EventArgs e)
        {
            this.control_final_cliente1.getMaskedTextBox1().Mask = ">000000000";
            this.control_final_cliente1.getMaskedTextBox1().MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            this.control_final_cliente1.getMaskedTextBox1().KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }
    }
}
