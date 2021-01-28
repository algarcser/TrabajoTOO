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
    public partial class FormCrearMostrarPresupuesto : Form
    {
        private Cliente cliente;
        private Presupuesto presupuesto;

        public FormCrearMostrarPresupuesto(Cliente c) //crear
        {
            this.cliente = c;
            ucPresupuesto crearPresupuesto = new ucPresupuesto(this.cliente);
            this.Controls.Add(crearPresupuesto);
            InitializeComponent();
            this.Text = "Crear presupuesto";
        }

        public FormCrearMostrarPresupuesto(Presupuesto p, bool mod) //mostrar y mostrar modificando (para 1en1), depende del bool
        {
            this.presupuesto = p;
            ucPresupuesto mostrarPresupuesto = new ucPresupuesto(this.presupuesto, mod);
            this.Controls.Add(mostrarPresupuesto);
            InitializeComponent();
            this.Text = "Mostrar presupuesto";
        }

        /*private void FormCrearMostrarPresupuesto_Load(object sender, EventArgs e)
        {
            if (this.presupuesto == null) //crear cliente != null
            {
                ucPresupuesto crearPresupuesto = new ucPresupuesto(this.cliente);
                this.Controls.Add(crearPresupuesto);
            }
            else //mostrar pesupuesto cliente == null
            {
                ucPresupuesto mostrarPresupuesto = new ucPresupuesto(this.presupuesto);
                this.Controls.Add(mostrarPresupuesto);
            }    
        }*/
    }
}
