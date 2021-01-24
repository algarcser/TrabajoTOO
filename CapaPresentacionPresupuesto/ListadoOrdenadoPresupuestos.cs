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
    public partial class ListadoOrdenadoPresupuestos : Form
    {
        public ListadoOrdenadoPresupuestos()
        {
            Presupuesto presupuesto;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = presupuesto.FechaRealizacion;
            this.lboFechaCreacion.DataSource = bindingSource;
            this.lboFechaCreacion.DataBindings.Add(new Binding("DisplayMember", bindingSource, "Date"));
            InitializeComponent();
        }
    }
}
