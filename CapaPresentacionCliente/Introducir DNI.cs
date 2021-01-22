using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocioCliente;
using LogicaModeloCliente;
using CapaPersistenciaCliente;

namespace CapaPresentacionCliente
{
    public partial class Introducir_DNI : Form
    {
        String accion;

        public Introducir_DNI(string accion)
        {
            InitializeComponent();
            this.accion = accion;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00000000L";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);

            if (this.accion.Equals("alta"))
            {
                if (!LNCliente.existeCliente(maskedTextBox1.Text))
                {
                    Form altaCliente = new Alta_Cliente();
                    
                }
                else
                {
                    MessageBox.Show("Quieres introducir otro?", "Ya existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if()
                }
            }
            else if(this.accion.Equals("baja"))
            {

            }
            else if(this.accion.Equals("busqueda"))
            {
                if (LNCliente.existeCliente(maskedTextBox1.Text))
                {
                    Cliente c;
                    PersistenciaCliente.READ(maskedTextBox1.Text, out c);
                    Form datosCliente = new Busqueda_cliente(c);
                }
                else
                {

                }
            }
            
        }
       

        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", maskedTextBox1, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", maskedTextBox1, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", maskedTextBox1, 0, -20, 5000);
            }
        }

        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(maskedTextBox1);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
