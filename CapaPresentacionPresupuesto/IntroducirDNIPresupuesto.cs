﻿using System;
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
    /// Formulario com
    /// </summary>
    public partial class FormIntroducirDNIPresupuesto : Form
    {
        private string accion; //acciones busqueda(mostrar) por cliente y crear presupuesto
        private string comercial;

        /// <summary>
        /// 
        /// </summary>
        public FormIntroducirDNIPresupuesto(string ac, string comercial)
        {
            this.accion = ac;
            this.comercial = comercial;
            InitializeComponent();
        }

        /// <summary>
        /// 
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

        /// <summary>
        /// 
        /// </summary>
        private void FormIntroducirDNIPresupuesto_Load(object sender, EventArgs e)
        {
            mtbDNI.Mask = ">00000000L";

            mtbDNI.MaskInputRejected += new MaskInputRejectedEventHandler(mtbDNI_MaskInputRejected);
            mtbDNI.KeyDown += new KeyEventHandler(mtbDNI_KeyDown);
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        private void mtbDNI_KeyDown(object sender, KeyEventArgs e)
        {
            ttDNI.Hide(mtbDNI);
        }

        /// <summary>
        /// 
        /// </summary>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
