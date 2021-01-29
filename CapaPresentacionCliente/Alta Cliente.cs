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
        public Alta_Cliente(Cliente c)
        {
            InitializeComponent();
            this.control_final_cliente1.DNI_readOnly(true);
            this.control_final_cliente1.setDNI(c.getDNI);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.control_final_cliente1.getMaskedTextBox1().MaskFull)
            {
                if ((this.control_final_cliente1.getNombre() == "") || (this.control_final_cliente1.getApellidos() == "") || (this.control_final_cliente1.getTelefono() == "") || ((!this.control_final_cliente1.getAchecked()) && (!this.control_final_cliente1.getBchecked()) && (!this.control_final_cliente1.getCchecked())))
                {
                    MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente cl = new Cliente(this.control_final_cliente1.getNombre(), this.control_final_cliente1.getApellidos(), this.control_final_cliente1.getDNI(), this.control_final_cliente1.getCategoria(), int.Parse(this.control_final_cliente1.getTelefono()));
                    Console.WriteLine("El AltaCliente justo despues de crear el cliente tiene el dni " + this.control_final_cliente1.getDNI());
                    Console.WriteLine("El cl tiene dni " + cl.getDNI);
                    if (LNCliente.altaCliente(cl))
                    {
                        MessageBox.Show("Alta de cliente confirmado  " + this.control_final_cliente1.getDNI());
                    }

                    this.Close();
                }
            }
            
        }
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

        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(this.control_final_cliente1.getMaskedTextBox1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alta_Cliente_Load(object sender, EventArgs e)
        {
            this.control_final_cliente1.getMaskedTextBox1().Mask = ">000000000";
            this.control_final_cliente1.getMaskedTextBox1().MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            this.control_final_cliente1.getMaskedTextBox1().KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }
    }
}
