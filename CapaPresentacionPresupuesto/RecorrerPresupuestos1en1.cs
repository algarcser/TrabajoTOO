using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloPresupuesto;

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Formualrio qeu implementa el control ucPresupuesto para mostrar y mdoificar Vehiculos y estado de una presupuesto en tiempo real
    /// mientras los recorres uno por uno.
    /// </summary>
    public partial class FormRecorrerPresupuestos1en1 : Form
    {
        private List<Presupuesto> listaPresupuestos; //lista de presupuetsos a mostrar.
        private ucPresupuesto mostrarModificarPresupuesto; //control de usuario usado al que se le cambian lso presupuestos que muestra.

        /// <summary>
        /// Constructor del formulario.
        /// PRE: Requiere List<Presupuesto> lp.
        /// POST:
        /// </summary>
        public FormRecorrerPresupuestos1en1(List<Presupuesto> lp)
        {
            this.listaPresupuestos = lp;
            
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaPresupuestos;
            this.bnPresupuestos.BindingSource = bindingSource;
        }

        /// <summary>
        /// Evento que carga el control de usuario ucPresupuesto en el formulario.
        /// </summary>
        private void FormRecorrerPresupuestos1en1_Load(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto = new ucPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1], true);
            this.Controls.Add(this.mostrarModificarPresupuesto);
        }

        /// <summary>
        /// Evento que te permite mostrar y modificar el presupuesto siguiente al que ves de la lista de presupuestos de atributo.
        /// </summary>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }

        /// <summary>
        /// Evento que te permite mostrar y modificar el último presupuesto de la lista de presupuestos de atributo.
        /// </summary>
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }

        /// <summary>
        /// Evento que te permite mostrar y modificar el presupuesto anterior al que ves de la lista de presupuestos de atributo.
        /// </summary>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }

        /// <summary>
        /// Evento que te permite mostrar y modificar el primer presupuesto de la lista de presupuestos de atributo.
        /// </summary>
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }
    }
}
