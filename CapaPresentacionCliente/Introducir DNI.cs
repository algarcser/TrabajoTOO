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

        /// <summary>
        /// Constructor del form
        /// </summary>
        /// <param name="accion"></param>
        public Introducir_DNI(string accion)
        {
            InitializeComponent();
            this.accion = accion;
        }

        /// <summary>
        /// Accion que ocurre al pulsar sobre el boton aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click_1(object sender, EventArgs e)
        {
            // Si la mascara del dni esta compelta, se llama a alta, baja o busqueda (dependiendo de lo que se ha solicitado hacer)

            if (maskedTextBox1.MaskFull) {
                // Si no existe el cliente se abre el form para dar de alta, y si existe te da la opcion de introducir otro dni
                if (this.accion.Equals("alta"))
                {
                    if (!LogicaNegocioCliente.LNCliente.existeCliente(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text)))
                    {
                        Cliente c = new Cliente(this.maskedTextBox1.Text);
                        Console.WriteLine(this.maskedTextBox1.Text);
                        Form altaCliente = new Alta_Cliente(c);
                        altaCliente.Show();
                        this.Close();

                    }
                    else if (LogicaNegocioCliente.LNCliente.existeCliente(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text)))
                    {
                        DialogResult result = MessageBox.Show("Quieres introducir otro?", "Ya existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            this.maskedTextBox1.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                else if (this.accion.Equals("baja"))
                {
                    // Si existe el cliente se abre el form para dar de baja, y si no existe te da la opcion de introducir otro dni
                    if (LogicaNegocioCliente.LNCliente.existeCliente(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text)))
                    {
                        Cliente c = new Cliente(this.maskedTextBox1.Text);
                        Form bajaCliente = new Baja_cliente(c);
                        bajaCliente.Show();
                        this.Close();
                    }
                    else if (!LogicaNegocioCliente.LNCliente.existeCliente(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text)))
                    {
                        Console.WriteLine(this.maskedTextBox1.Text);
                        DialogResult result = MessageBox.Show("Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            this.maskedTextBox1.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }

                // Este es el codigo para lo que era el metodo de busqueda anterior a que el cliente cambiara de idea y decidiera poner otro

                //else if (this.accion.Equals("busqueda"))
                //{
                //    if (LogicaNegocioCliente.LNCliente.existeCliente(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text)))
                //    {
                //        Cliente c;
                //        c = CapaPersistenciaCliente.PersistenciaCliente.READ(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text));

                //        Form datosAlternativoCliente = new Busqueda_alternativa_cliente(c);
                //        datosAlternativoCliente.Show();

                //        this.Close();
                //    }
                //    else if (!LogicaNegocioCliente.LNCliente.existeCliente(new LogicaModeloCliente.Cliente(this.maskedTextBox1.Text)))
                //    {
                //        DialogResult result = MessageBox.Show("Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //        if (result == DialogResult.Yes)
                //        {
                //            this.maskedTextBox1.Text = "";
                //        }
                //        else
                //        {
                //            this.Close();
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("error");
                //    }
                //}
                else { }
            }
            
        }

        /// <summary>
        /// Mensajes del tooltip por si no se cumplen las normas de la mascara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "DNI rechazado - Demasiada información";
                toolTip1.Show("No puede introducir más información en el campo DNI. Elimine algunos caracteres para poder introducir más datos.", maskedTextBox1, 120, 10, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "DNI rechazado - Tamaño alcanzado";
                toolTip1.Show("No puede añadir más caracteres al final del campo DNI", maskedTextBox1, 120, 10, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "DNI rechazado";
                toolTip1.Show("Solo pueden introducir ocho caracteres numéricos (0-9) seguidos de una letra [a-zA-Z] en el campo DNI.", maskedTextBox1, 120, 10, 5000);
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
            toolTip1.Hide(maskedTextBox1);
        }

        /// <summary>
        /// Accion que ocurre al pulsar sobre el boton cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Inicializa la mascara al cargar el Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Introducir_DNI_Load_1(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = ">00000000L";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }
    }
}