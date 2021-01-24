using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionVehiculo
{
    public partial class Datos2Mano : UserControl
    {
        public Datos2Mano()
        {
            InitializeComponent();
        }


        public string Matricula
        {
            get
            {
                return this.textBox_matricula.Text;
            }
            set
            {
                this.textBox_matricula.Text = value;
            }
        }

        public string FechaMatriculacion
        {
            get
            {
                return this.textBox_fechaMatriculacion.Text;
            }
            set
            {
                this.textBox_fechaMatriculacion.Text = value.ToString().Substring(0,10);
            }
        }

        internal void cerrar_modificacion()
        {
            this.textBox_fechaMatriculacion.ReadOnly = true;
            this.textBox_matricula.ReadOnly = true;
        }

    }
}