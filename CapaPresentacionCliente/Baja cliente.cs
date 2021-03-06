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
using LogicaNegocioCliente;

namespace CapaPresentacionCliente
{
    public partial class Baja_cliente : Form
    {
        Cliente clBuscado;
        /// <summary>
        /// Constructor del form
        /// </summary>
        /// <param name="c"></param>
        public Baja_cliente(Cliente c)
        {
            InitializeComponent();

            //Se ponen los controles a solo lectura y se introducen los datos de un cliente que se pasa por parametro

            this.control_alternativo_datos_cliente1.DNI_readOnly(true);
            this.control_alternativo_datos_cliente1.nombre_readOnly(true);
            this.control_alternativo_datos_cliente1.apellidos_readOnly(true);
            this.control_alternativo_datos_cliente1.tfno_readOnly(true);
            this.control_alternativo_datos_cliente1.rbA_Enabled(false);
            this.control_alternativo_datos_cliente1.rbB_Enabled(false);
            this.control_alternativo_datos_cliente1.rbC_Enabled(false);

            clBuscado = LNCliente.readCliente(c);


            this.control_alternativo_datos_cliente1.setDNI(clBuscado.getDNI);
            this.control_alternativo_datos_cliente1.setNombre(clBuscado.getNombre);
            this.control_alternativo_datos_cliente1.setApellidos(clBuscado.getApellidos);
            this.control_alternativo_datos_cliente1.setCategoria(clBuscado.getcategoria);
            this.control_alternativo_datos_cliente1.setTfno(clBuscado.getTlfno.ToString());
        }

        /// <summary>
        /// Accion que ocurre al hacer click sobre el boton aceptar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Se elimina un cliente y sale el mensaje de confirmacion
            DialogResult result = MessageBox.Show("Está seguro que desea dar de baja a este cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                LNCliente.bajaCliente(clBuscado);
                MessageBox.Show("Cliente eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        ///  Accion que ocurre al hacer click sobre el boton cancelar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
