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

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Formulario con doble constructor para una doble funcionalidad, te permite crear un presupuesto o mostrar un presupuesto por medio
    /// del control de usuario ucPresupuesto. Es decir, esto solo sirve para mostrar el grueso de ucPresupuesto.
    /// </summary>
    public partial class FormCrearMostrarPresupuesto : Form
    {
        private Cliente cliente; //Cliente necesario para crear un presupuesto, pasado desde IntroducirDNIPresupuesto.
        private Presupuesto presupuesto; //Presupuesto necesario apra mostrar un presupuesto, pasado desde ListadoPresupuestos.

        /// <summary>
        /// Contructor del formulario para crear un Presupuesto por medio de ucPresupuesto.
        /// PRE: Requiere Cliente c y string comercial.
        /// POST:
        /// </summary>
        public FormCrearMostrarPresupuesto(Cliente c, string comercial) //crear
        {
            this.cliente = c;
            ucPresupuesto crearPresupuesto = new ucPresupuesto(this.cliente, comercial);
            this.Controls.Add(crearPresupuesto);
            InitializeComponent();
            this.Text = "Crear presupuesto";
        }

        /// <summary>
        /// Contructor del formulario para mostrar un Presupuesto por medio de ucPresupuesto.
        /// PRE: Requiere presupuesto p.
        /// POST:
        /// </summary>
        public FormCrearMostrarPresupuesto(Presupuesto p) //mostrar
        {
            this.presupuesto = p;
            ucPresupuesto mostrarPresupuesto = new ucPresupuesto(this.presupuesto, false); //Opción mod en false, porque este formualrio solo es para mostrar o crear un presupuesto, no para modificarlo.
            this.Controls.Add(mostrarPresupuesto);
            InitializeComponent();
            this.Text = "Mostrar presupuesto";
        }
    }
}
