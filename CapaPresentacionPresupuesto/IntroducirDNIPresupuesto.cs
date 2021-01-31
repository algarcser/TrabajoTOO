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
using LogicaModeloPresupuesto;
using LogicaNegocioCliente;
using CapaPresentacionCliente;
using LogicaNegocioPresupuesto;

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Formulario con doble funcionaldiad, permite usarlo para crear un presupuesto o para realizar una búsqueda por DNI de presupuestos.
    /// Este incluye una máscara que te obliga a poner el DNI de forma correcta y compeltamente, si no te avisa con MessageBox o una ToolTip
    /// en forma de Ballon.
    /// </summary>
    public partial class FormIntroducirDNIPresupuesto : Form
    {
        private string accion; //acciones: busqueda(mostrar) por cliente y crear presupuesto,
        private string comercial; //comercial qeu usa la aplicación.

        /// <summary>
        /// Constructor del ofrmulario.
        /// PRE: Requiere string ac y string comercial.
        /// POST:
        /// </summary>
        public FormIntroducirDNIPresupuesto(string ac, string comercial)
        {
            this.accion = ac;
            this.comercial = comercial;
            InitializeComponent();
        }

        /// <summary>
        /// Evento que te perimite buscar presupuestos por el DNI de un Cliente mostrandote despues una lista completa, o crear un presupuesto
        /// a partir del DNI de un Cliente.
        /// </summary>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (mtbDNI.MaskFull)
            {
                if (this.accion.Equals("crear"))
                {
                    Cliente c1 = new Cliente(mtbDNI.Text);
                    if (LNCliente.existeCliente(c1) == true)
                    {
                        Form crearPresupuesto = new FormCrearMostrarPresupuesto(LNCliente.readCliente(c1), this.comercial);
                        crearPresupuesto.Show();
                        this.Close();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("    ¿Quieres darlo de alta?    ", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Cliente c2 = new Cliente(mtbDNI.Text);
                            Form crearCliente = new Alta_Cliente(c2);
                            crearCliente.ShowDialog();
                            if (LNCliente.existeCliente(c2) == true)
                            {
                                Form crearPresupuesto = new FormCrearMostrarPresupuesto(LNCliente.readCliente(c2), this.comercial);
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
                    Cliente c3 = new Cliente(mtbDNI.Text);
                    if (LNCliente.existeCliente(c3) == true)
                    {
                        LNCliente.readCliente(c3);
                        List<Presupuesto> listaCribaDNI = LNPresupuesto.SELECTALL();
                        List<Presupuesto> listaCribadaDNI = new List<Presupuesto>();
                        foreach (Presupuesto p in listaCribaDNI)
                        {
                            if (p.Cliente.getDNI.Equals(mtbDNI.Text) == true)
                            {
                                listaCribadaDNI.Add(p);
                            }
                        }

                        if (listaCribadaDNI.Count != 0)
                        {
                            Form busquedaPresupuestoPorDNI = new FormListadoPresupuestos(listaCribadaDNI);
                            busquedaPresupuestoPorDNI.Show();
                            this.Close();
                        }else
                        {
                            DialogResult result = MessageBox.Show("    ¿Quieres crear uno?    ", "No existe ningún presupuesto para un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                Form crearPresupuesto = new FormCrearMostrarPresupuesto(LNCliente.readCliente(c3), this.comercial);
                                crearPresupuesto.Show();
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
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

        /// <summary>
        /// Evento que carga la máscara y lanza los eventos de esta.
        /// </summary>
        private void FormIntroducirDNIPresupuesto_Load(object sender, EventArgs e)
        {
            mtbDNI.Mask = ">00000000L";

            mtbDNI.MaskInputRejected += new MaskInputRejectedEventHandler(mtbDNI_MaskInputRejected);
            mtbDNI.KeyDown += new KeyEventHandler(mtbDNI_KeyDown);
        }

        /// <summary>
        /// Si la mascara falla te muestra diferentes ToolTip Ballon dependiendo de la causa del fallo.
        /// </summary>
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

        /// <summary>
        /// Evento que cuando la tecla este sobre la MaskedTextBox hace que el ToolTip ballon desaparezca durando menos de los 5 segundos
        /// especificados.
        /// </summary>
        private void mtbDNI_KeyDown(object sender, KeyEventArgs e)
        {
            ttDNI.Hide(mtbDNI);
        }

        /// <summary>
        /// Evento que te permite cancelar la operación cerrando el formualrio.
        /// </summary>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
