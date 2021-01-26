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
                return this.maskedTextBox_Matricula.Text;
            }
            set
            {
                this.maskedTextBox_Matricula.Text = value;
            }
        }

        public string FechaMatriculacion
        {
            get
            {
                return this.dateTimePicker_FechaMatriculacion.Text;
            }
            set
            {
                this.dateTimePicker_FechaMatriculacion.Text = value.ToString().Substring(0,10);
            }
        }

        internal void cerrar_modificacion()
        {
            this.maskedTextBox_Matricula.ReadOnly = true;
            this.dateTimePicker_FechaMatriculacion.Enabled = false;
        }

        public bool Lectura_Correcta()
        {
            return ( this.maskedTextBox_Matricula.Text != "") ;
        }


    }
}