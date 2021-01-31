using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacionVehiculo;
using LogicaNegocioVehiculo;
using LogicaModeloVehiculo;
using LogicaModeloPresupuesto;
using LogicaNegocioPresupuesto;

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Formulario que te permite realizar una busqeuda de presupuestos por Nº de bastidor o Introducir un vehículo, tanto para modificar
    /// como para crear un presupuesto.
    /// </summary>
    public partial class FormIntroducirNBastidorPresupuesto : Form
    {
        private string accion; //acciones busqueda(mostrar) por vehículo e introducir(crear) vehiculo
        private vehiculo vehiculo; //vehiculo asociado a introducir vehículo.

        /// <summary>
        /// Constructor del formualrio.
        /// PRE: Requiere string ac, solo válido si es introducir o busqueda.
        /// POST:
        /// </summary>
        public FormIntroducirNBastidorPresupuesto(string ac)
        {
            this.accion = ac;
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad del formualrio que te devuelve el vehiculo que se ha introducido.
        /// </summary>
        public vehiculo Vehiculo
        {
            get
            {
                return (this.vehiculo);
            }
        }

        /// <summary>
        /// Evento que te permite realizar la búsqeuda o  introducir un vehículo existente en la BD en un presupuesto, ya sea para crear o
        /// modificar. SI no existe te redirige a darlo de alta.
        /// </summary>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (mtbNBastidor.MaskFull)
            {
                if (this.accion.Equals("introducir")) //introducir(crear)
                {
                    vehiculoNuevo v = new vehiculoNuevo(mtbNBastidor.Text);
                    if (LNVehiculo.EXISTS(v) == true)
                    {
                        LNVehiculo.READ(v, out this.vehiculo);
                        this.Close();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("                 ¿Quieres darlo de alta?                 ", "No existe un vehiculo con ese Nº de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Form crearVehiculo = new formularioVehiculo(mtbNBastidor.Text, enumObjetivo.Alta);
                            crearVehiculo.ShowDialog();
                            if (LNVehiculo.EXISTS(v) == true)
                            {
                                LNVehiculo.READ(v, out this.vehiculo);
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
                    vehiculoNuevo v = new vehiculoNuevo(mtbNBastidor.Text);
                    if (LNVehiculo.EXISTS(v) == true)
                    {
                        List<Presupuesto> listaCribaNBastidor = LNPresupuesto.SELECTALL();
                        List<Presupuesto> listaCribadaNBastidor = new List<Presupuesto>();
                        
                        foreach (Presupuesto p in listaCribaNBastidor)
                        {
                            foreach (vehiculo v1 in p.ListaVehiculos)
                            {
                                if (v1.NBastidor.Equals(mtbNBastidor.Text) == true)
                                {
                                    listaCribadaNBastidor.Add(p);
                                }
                            }
                        }

                        if (listaCribadaNBastidor.Count != 0)
                        {
                            Form busquedaPresupuestoPorNBastidor = new FormListadoPresupuestos(listaCribadaNBastidor);
                            busquedaPresupuestoPorNBastidor.Show();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("No existe ningún presupuesto para un cliente con un vehículo con ese Nº de bastidor.", "No existe ningún presupuesto para ese Nº de bastidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("               ¿Quieres introducir otro?               ", "No existe un vehiculo con ese Nº de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.mtbNBastidor.Text = "";
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
                MessageBox.Show("Introduce un Nº de bastidor válido.", "No se ha introducido un Nº de bastidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que te permite cancelar la operación a realizar.
        /// </summary>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que carga la máscara y lanza los eventos de esta.
        /// </summary>
        private void IntroducirNBastidorPresupuesto_Load(object sender, EventArgs e)
        {
            mtbNBastidor.Mask = ">AAAAAAAAAAAAAAAAA";

            mtbNBastidor.MaskInputRejected += new MaskInputRejectedEventHandler(mtbNBastidor_MaskInputRejected);
            mtbNBastidor.KeyDown += new KeyEventHandler(mtbNBastidor_KeyDown);
        }

        /// <summary>
        /// Si la mascara falla te muestra diferentes ToolTip Ballon dependiendo de la causa del fallo.
        /// </summary>
        private void mtbNBastidor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNBastidor.MaskFull)
            {
                ttNBastidor.ToolTipTitle = "Nº de bastidor rechazado - Demasiada información";
                ttNBastidor.Show("No puede introducir más información en el campo Nº de bastidor. Elimine algunos caracteres para poder introducir más datos.", mtbNBastidor, 120, 10, 5000);
            }
            else if (e.Position == mtbNBastidor.Mask.Length)
            {
                ttNBastidor.ToolTipTitle = "Nº de bastidor rechazado - Tamaño alcanzado";
                ttNBastidor.Show("No puede añadir más caracteres al final del campo Nº de bastidor", mtbNBastidor, 120, 10, 5000);
            }
            else
            {
                ttNBastidor.ToolTipTitle = "Nº de bastidor rechazado";
                ttNBastidor.Show("Solo pueden introducir diecisiete caracteres alfanuméricos (0-9) seguidos de una letra [a-zA-Z] en el campo DNI.", mtbNBastidor, 120, 10, 5000);
            }
        }

        /// <summary>
        /// Evento que cuando la tecla este sobre la MaskedTextBox hace que el ToolTip ballon desaparezca durando menos de los 5 segundos
        /// especificados.
        /// </summary>
        private void mtbNBastidor_KeyDown(object sender, KeyEventArgs e)
        {
            ttNBastidor.Hide(mtbNBastidor);
        }
    }
}
