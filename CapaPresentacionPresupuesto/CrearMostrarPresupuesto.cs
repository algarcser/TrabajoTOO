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
    public partial class CrearMostrarPresupuesto : Form
    {
        private Cliente cliente;
        private Presupuesto presupuesto;

        public CrearMostrarPresupuesto(Cliente c) //crear
        {
            this.cliente = c;
            InitializeComponent();
        }

        public CrearMostrarPresupuesto(Presupuesto p) //mostrar
        {
            this.presupuesto = p;
            InitializeComponent();
        }

        private void FormCrearMostrarPresupuesto_Load(object sender, EventArgs e)
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
                
        }
    }
}
