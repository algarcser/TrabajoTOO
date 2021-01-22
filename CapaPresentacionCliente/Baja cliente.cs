using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionCliente
{
    public partial class Baja_cliente : Form
    {
        public Baja_cliente()
        {
            InitializeComponent();
            this.control_datos_cliente1.DNI_readOnly(true);
            this.control_datos_cliente1.nombre_readOnly(true);
            this.control_datos_cliente1.tfno_readOnly(true);
            this.control_datos_cliente1.rbA_Enabled(false);
            this.control_datos_cliente1.rbB_Enabled(false);
            this.control_datos_cliente1.rbC_Enabled(false);
        }
    }
}
