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
using LogicaNegocioPresupuesto;

namespace CapaPresentacionPresupuesto
{
    public partial class FormIntroducirEstadoPresupuesto : Form
    {
        public FormIntroducirEstadoPresupuesto()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            List<Presupuesto> listaCribaNBastidor = LNPresupuesto.SELECTALL();
            List<Presupuesto> listaCribadaNBastidor = new List<Presupuesto>();

            foreach (Presupuesto p in listaCribaNBastidor)
            {
                if ((this.cbCreado.Checked == true) && (p.EstadoPresupuesto == EstadoPresupuesto.creado))
                {
                    listaCribadaNBastidor.Add(p);
                }else if ((this.cbPendiente.Checked == true) && (p.EstadoPresupuesto == EstadoPresupuesto.pendiente))
                {
                    listaCribadaNBastidor.Add(p);
                }else if ((this.cbAceptado.Checked == true) && (p.EstadoPresupuesto == EstadoPresupuesto.aceptado))
                {
                    listaCribadaNBastidor.Add(p);
                }else if ((this.cbDesestimado.Checked == true) && (p.EstadoPresupuesto == EstadoPresupuesto.desestimado))
                {
                    listaCribadaNBastidor.Add(p);
                }
            }

            if (listaCribadaNBastidor.Count != 0)
            {
                Form busquedaPresupuestoPorNBastidor = new FormListadoPresupuestos(listaCribadaNBastidor);
                busquedaPresupuestoPorNBastidor.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("No existe ningún presupuesto en la base de datos para ese/esos estado/s.", "No existe ningún presupuesto para ese/esos estado/s", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
