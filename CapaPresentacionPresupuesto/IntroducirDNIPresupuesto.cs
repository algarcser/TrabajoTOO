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
using CapaPresentacionCliente;

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
            if (mtbDNI.MaskFull)
            {
                if (this.accion.Equals("crear"))
                {
                    if (LNCliente.existeCliente(mtbDNI.Text) == true)
                    {
                        Form crearPresupuesto = new CrearMostrarPresupuesto(LNCliente.readCliente(mtbDNI.Text));
                        crearPresupuesto.Show();
                        this.Close();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Quieres darlo de alta?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Form crearCliente = new Alta_Cliente();
                            crearCliente.ShowDialog();
                            if (LNCliente.existeCliente(mtbDNI.Text) == true)
                            {
                                Form crearPresupuesto = new CrearMostrarPresupuesto(LNCliente.readCliente(mtbDNI.Text));
                                crearPresupuesto.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                else if (this.accion.Equals("busqueda"))
                {
                    if (LNCliente.existeCliente(mtbDNI.Text) == true)
                    {
                        LNCliente.readCliente(mtbDNI.Text);

                        //COMPLETAR con listado ordenado de presupuestos

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("    ¿Quieres introducir otro?    ", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.mtbDNI.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Introduce un DNI válido.", "No se ha introducido un DNI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                ttDNI.Show("No puede introducir más información en el campo DNI. Elimine algunos caracteres para poder introducir más datos.", mtbDNI, 120, 10, 5000);
            }
            else if (e.Position == mtbDNI.Mask.Length)
            {
                ttDNI.ToolTipTitle = "DNI rechazado - Tamaño alcanzado";
                ttDNI.Show("No puede añadir más caracteres al final del campo DNI", mtbDNI, 120, 10, 5000);
            }
            else
            {
                ttDNI.ToolTipTitle = "DNI rechazado";
                ttDNI.Show("Solo pueden introducir ocho caracteres numéricos (0-9) seguidos de una letra [a-zA-Z] en el campo DNI.", mtbDNI, 120, 10, 5000);
            }
        }

        private void mtbDNI_KeyDown(object sender, KeyEventArgs e)
        {
            ttDNI.Hide(mtbDNI);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
