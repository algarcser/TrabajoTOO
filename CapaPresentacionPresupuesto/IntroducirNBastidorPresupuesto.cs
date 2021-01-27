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
    public partial class FormIntroducirNBastidorPresupuesto : Form
    {
        private string accion; //acciones busqueda(mostrar) por vehículo e introducir(crear) vehiculo
        private vehiculo vehiculo;

        public FormIntroducirNBastidorPresupuesto(string ac)
        {
            this.accion = ac;
            InitializeComponent();
        }

        public vehiculo Vehiculo
        {
            get
            {
                return (this.vehiculo);
            }
        }

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
                        DialogResult result = MessageBox.Show("¿Quieres darlo de alta?", "No existe un vehiculo con ese Nº de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        LNVehiculo.READ(v, out this.vehiculo);
                        List<Presupuesto> listaCribaNBastidor = LNPresupuesto.SELECTALL();
                        List<Presupuesto> listaCribadaNBastidor = new List<Presupuesto>();
                        /*
                        foreach (Presupuesto p in listaCribaNBastidor)
                        {
                            if (p.Cliente.getDNI.Equals(mtbDNI.Text) == true)
                            {
                                listaCribadaDNI.Add(p);
                            }
                        }

                        if (listaCribadaDNI.Count != 0)
                        {
                            Form busquedaPresupuestoPorDNI = new FormListadoOrdenadoPresupuestos(listaCribadaDNI);
                            busquedaPresupuestoPorDNI.Show();
                            this.Close();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("    ¿Quieres crear uno?    ", "No existe ningún presupuesto para un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                Form crearPresupuesto = new FormCrearMostrarPresupuesto(LNCliente.readCliente(c3));
                                crearPresupuesto.Show();
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
                        }*/

                        //COMPLETAR con listado ordenado de presupuestos

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("    ¿Quieres introducir otro?    ", "No existe un vehiculo con ese Nº de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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



        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IntroducirNBastidorPresupuesto_Load(object sender, EventArgs e)
        {
            mtbNBastidor.Mask = ">AAAAAAAAAAAAAAAAA";

            mtbNBastidor.MaskInputRejected += new MaskInputRejectedEventHandler(mtbNBastidor_MaskInputRejected);
            mtbNBastidor.KeyDown += new KeyEventHandler(mtbNBastidor_KeyDown);
        }

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

        private void mtbNBastidor_KeyDown(object sender, KeyEventArgs e)
        {
            ttNBastidor.Hide(mtbNBastidor);
        }
    }
}
