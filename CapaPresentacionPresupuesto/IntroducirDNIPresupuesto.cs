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

namespace CapaPresentacionPresupuesto
{
    public partial class FormIntroducirDNIPresupuesto : Form
    {
        private string accion; //acciones busqueda(mostrar) por cliente y crear presupuesto

        public FormIntroducirDNIPresupuesto(string ac)
        {
            this.accion = ac;
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (this.accion.Equals("crear"))
            {
                if (LNCliente.existeCliente(mtbDNI.Text) == true)
                {
                    //Cliente auxiliar = new Cliente(mtbDNI.Text);
                    //LNCliente.readCliente(auxiliar);
                    //Form crearPresupuesto = new CrearMostrarPresupuesto(auxiliar);

                }
                else
                {
                    MessageBox.Show("Quieres introducir otro?", "Ya existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if()
                }
            }
            /*
            else if (this.accion.Equals("busqueda"))
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
            */
        }

        private void FormIntroducirDNIPresupuesto_Load(object sender, EventArgs e)
        {
            mtbDNI.Mask = "00000000L";

            mtbDNI.MaskInputRejected += new MaskInputRejectedEventHandler(mtbDNI_MaskInputRejected);
            mtbDNI.KeyDown += new KeyEventHandler(mtbDNI_KeyDown);
        }

        private void mtbDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbDNI.MaskFull)
            {
                ttDNI.ToolTipTitle = "DNI rechazado - Demasiada información";
                ttDNI.Show("No puede introducir más información en el campo DNI. Elimine algunos caracteres para poder introducir más datos.", mtbDNI, 0, -20, 5000);
            }
            else if (e.Position == mtbDNI.Mask.Length)
            {
                ttDNI.ToolTipTitle = "DNI rechazado - Tamaño alcanzado";
                ttDNI.Show("No puede añadir más caracteres al final del campo DNI", mtbDNI, 0, -20, 5000);
            }
            else
            {
                ttDNI.ToolTipTitle = "DNI rechazado";
                ttDNI.Show("Solo puede introducir ocho caracteres numéricos (0-9) seguidos de una letra [a-zA-Z] en el campo DNI.", mtbDNI, 0, -20, 5000);
            }
        }

        private void mtbDNI_KeyDown(object sender, KeyEventArgs e)
        {
            ttDNI.Hide(mtbDNI);
        }
    }
}
