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
        }

        public string FechaMatriculacion
        {
            get
            {
                return this.textBox_fechaMatriculacion.Text;
            }
        }
    }
}