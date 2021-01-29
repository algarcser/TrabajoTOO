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
        private void btAceptar_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull) {
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

        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(maskedTextBox1);
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Introducir_DNI_Load_1(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = ">00000000L";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }
    }
}