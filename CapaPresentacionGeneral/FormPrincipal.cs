﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacionVehiculo;
using CapaPresentacionPresupuesto;
using LogicaNegocioPresupuesto;
using LogicaModeloPresupuesto;
using CapaPresentacionCliente;

namespace CapaPresentacionGeneral
{
    /// <summary>
    /// Formulario principal de la aplicación.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        private string usuario;

        /// <summary>
        /// Constructor del formulario.
        /// PRE: requiere string usuario.
        /// POST:
        /// </summary>
        public FormPrincipal(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();

            this.Text = "Concesionario Pepérez® - v1.0.19012021" + "  -  Usuario: " + this.usuario;
        }

        /// <summary>
        /// Evento que permite dar de alta a un cliente, pasándole un form de introduccion de DNI, 
        /// para asegurarse de no existe ya, sino pide introducir otro
        /// </summary>
        private void tsmiAltaCliente_Click(object sender, EventArgs e)
        {
            Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("alta");
            intrDNI.Show();
        }

        /// <summary>
        /// Evento que permite dar de baja a un cliente, pasándole un form de introduccion de DNI,
        /// para asegurarse de que ya existe, sino pide introducir otro
        /// </summary>
        private void tsmiBajaCliente_Click(object sender, EventArgs e)
        {
            Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("baja");
            intrDNI.Show();
        }

        /// <summary>
        /// Evento que permite realizar la busqueda de un cliente, teniendo un comboBox que permite elegir 
        /// entre los clientes existentes por su DNI
        /// </summary>
        private void tsmiBusquedaCliente_Click(object sender, EventArgs e)
        {
            // La version comentada es la version antigua de busqueda, antes de que se pidiera 
            // realizar la otra nueva que viene tras ella

            //Form intrDNI = new CapaPresentacionCliente.Introducir_DNI("busqueda");
            //intrDNI.Show();

            Form busquedaCliente = new CapaPresentacionCliente.Busqueda_alternativa_cliente();
            busquedaCliente.Show();
        }

        /// <summary>
        /// Evento que muestra todos los clientes por partes en tres listas diferentes, cada una con un dato del cliente,
        /// teniendo DNI, nombre e importe de su presupuesto, puediendo ordenarlos por cada campo haciendo click
        /// en el boton correspondiente
        /// </summary>
        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = new CapaPresentacionCliente.Listado_de_clientes();
            listado.Show();
        }

        /// <summary>
        /// Muestra todos los clientes, pero uno a uno, puediendose mover con las flechas para ver los demas clientes
        /// </summary>
        private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form recorrido = new CapaPresentacionCliente.Recorrido_uno_a_uno();
            recorrido.Show();
        }

        /// <summary>
        /// obtiene un numero de bastidor y si no esta en la base de datos, y si no hay un vehiculo en la base de datos entonces pide los datos para crear un vehiculo, y lo introduce en la base de datos
        /// </summary>
        private void tsmiAltaVehiculo_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Alta );
            obtenerNBastidor.Show();
        }

        /// <summary>
        /// obrtiene el numero de bastidor, y si existe un vehiculo en la base de datos iguales, entonces muestra sus datos por pantalla
        /// </summary>
        private void tsmiBusquedaVehiculo_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Ver );
            obtenerNBastidor.Show();
        }

        /// <summary>
        /// muestra el formulario para obtener un numero de bastidor de un vehiculo, si este existe en la base de datos, lo elimina y muestra sus datos por pantalla
        /// </summary>
        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obtenerNBastidor = new ObtenerNBastidor( enumObjetivo.Baja );
            obtenerNBastidor.Show();
        }

        /// <summary>
        /// Evento que accede a la función Crear presupuesto por medio de un DNI de Cliente.
        /// </summary>
        private void tsmiCrearPresupuesto_Click(object sender, EventArgs e)
        {
            Form crearPresupuesto = new FormIntroducirDNIPresupuesto("crear", this.usuario);
            crearPresupuesto.Show();
        }

        /// <summary>
        /// Evento que permite buscar presupuestos asociados a un Cliente por su DNI, si existe algún presupuesto.
        /// </summary>
        private void tsmiBPPorCliente_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form busquedaPresupuestosCliente = new FormIntroducirDNIPresupuesto("busqueda", this.usuario);
                busquedaPresupuestosCliente.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Búsqueda\\Por cliente\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento que permite Mostrar un listado completo de presupuestos con diversas funciones si existe al menos 1 Presupuesto en la BD.
        /// </summary>
        private void tsmiMostrarTodos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form mostrarTodosPresupuestos = new FormListadoPresupuestos(LNPresupuesto.SELECTALL());
                mostrarTodosPresupuestos.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Mostrar presupuestos\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        private void anadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestionar_Extra alta_extra = new Gestionar_Extra();
            alta_extra.Show();
        }

        /// <summary>
        /// muestra todos los vehiculos en un form
        /// </summary>
        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motrar_Todos_Vehiculos mostrar_todos_vehiculos = new Motrar_Todos_Vehiculos();
            mostrar_todos_vehiculos.Show();
        }

        /// <summary>
        /// Evento que permite buscar presupuestos asociados a un Nº de bastidor de un vehículo, si existe algún presupuesto.
        /// </summary>
        private void tsmiBPPorVehiculo_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form busquedaPresupuestosVehiculo = new FormIntroducirNBastidorPresupuesto("busqueda");
                busquedaPresupuestosVehiculo.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Búsqueda\\Por vehículo\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento que permite buscar presupuestos de un tipo o tipos de estados determinados, si existe algún presupuesto.
        /// </summary>
        private void tsmiBPPorEstado_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form busquedaPresupuestosEstado = new FormIntroducirEstadoPresupuesto();
                busquedaPresupuestosEstado.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Búsqueda\\Por estado\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento que permite modificar los presupuestos creados en cuanto a estado y vehículos recorriendo 1 por 1, si existe algún presupuesto.
        /// </summary>
        private void tsmiModificarPresupuestos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                Form modificarPresupuestos = new FormRecorrerPresupuestos1en1(LNPresupuesto.SELECTALL());
                modificarPresupuestos.Show();
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Configuración\\Modificar presupuestos\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento que actualiza todos los presupuestos con estado creado a desestimado si han pasado más de 15 días y te indica cuántos
        /// se han actualizado, si existe algún presupuesto.
        /// </summary>
        private void tsmiActualizarPresupuestos_Click(object sender, EventArgs e)
        {
            if (LNPresupuesto.SELECTALL().Count != 0)
            {
                int presupuestosActualizados = 0;
                foreach (Presupuesto p in LNPresupuesto.SELECTALL())
                {
                    if (LNPresupuesto.actualizarEstado(p) == true)
                    {
                        if (LNPresupuesto.UPDATE(p) == true)
                        {
                            presupuestosActualizados++;
                        }
                    }
                }
                MessageBox.Show("Se han actualizado " + presupuestosActualizados.ToString() + " presupuestos.", "Presupuestos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Introduce al menos 1 presupuesto para poder usar \"Configuración\\Actualizar presupuestos\"", "No hay ningun presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// muestra uno por uno todos los vehiculos almacenados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarUnoPorUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recorrido_1_a_1 mostrar1a1 = new Recorrido_1_a_1();
            mostrar1a1.Show();
        }
    }
}
