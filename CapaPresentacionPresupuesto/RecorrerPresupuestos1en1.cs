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

        public FormRecorrerPresupuestos1en1(List<Presupuesto> lp)
        {
            this.listaPresupuestos = lp;
            InitializeComponent();
        }
    }
}
