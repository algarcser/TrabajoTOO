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
    public partial class FormRecorrerPresupuestos1en1 : Form
    {
        private List<Presupuesto> listaPresupuestos;
        private ucPresupuesto mostrarModificarPresupuesto;

        public FormRecorrerPresupuestos1en1(List<Presupuesto> lp)
        {
            this.listaPresupuestos = lp;
            
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.listaPresupuestos;
            this.bnPresupuestos.BindingSource = bindingSource;
        }

        private void FormRecorrerPresupuestos1en1_Load(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto = new ucPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1], true);
            this.Controls.Add(this.mostrarModificarPresupuesto);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.mostrarModificarPresupuesto.cambiarPresupuesto(this.listaPresupuestos[Convert.ToInt32(this.bnPresupuestos.PositionItem.Text) - 1]);
        }
    }
}
