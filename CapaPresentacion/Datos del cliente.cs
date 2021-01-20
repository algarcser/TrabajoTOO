using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Datos_del_cliente : Form
    {
        public Datos_del_cliente()
        {
            InitializeComponent();
            this.alta_de_un_cliente1.DNI_readOnly(true);
            this.alta_de_un_cliente1.nombre_readOnly(true);
            this.alta_de_un_cliente1.tfno_readOnly(true);
            this.alta_de_un_cliente1.rbA_Enabled(false);
            this.alta_de_un_cliente1.rbB_Enabled(false);
            this.alta_de_un_cliente1.rbC_Enabled(false);
        }
    }
}
