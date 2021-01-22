using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionCliente
{
    public partial class Control_datos_cliente : UserControl
    {
        public Control_datos_cliente()
        {
            InitializeComponent();
        }

        public bool DNI_readOnly(bool b)
        {
            this.textBox1.ReadOnly = b;
            return this.textBox1.ReadOnly;
        }

        public bool nombre_readOnly(bool b)
        {
            this.textBox2.ReadOnly = b;
            return this.textBox1.ReadOnly;
        }

        public bool tfno_readOnly(bool b)
        {
            this.textBox3.ReadOnly = b;
            return this.textBox1.ReadOnly;
        }

        public bool rbA_Enabled(bool b)
        {
            this.radioButton1.Enabled = b;
            return this.textBox1.ReadOnly;
        }

        public bool rbB_Enabled(bool b)
        {
            this.radioButton1.Enabled = b;
            return this.textBox1.ReadOnly;
        }

        public bool rbC_Enabled(bool b)
        {
            this.radioButton1.Enabled = b;
            return this.textBox1.ReadOnly;
        }
    }
}
