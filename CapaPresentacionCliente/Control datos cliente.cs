using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloCliente;

namespace CapaPresentacionCliente
{
    public partial class Control_datos_cliente : UserControl
    {
        
        public String getDNI()
        {
            return this.textBox1.Text;
        }

        public String getNombre()
        {
            return this.textBox2.Text;
        }

        public String getTelefono()
        {
            return this.textBox3.Text;
        }

        public CategoriaCliente getCategoria()
        {
            if(this.radioButton1.Checked == true)
            {
                return CategoriaCliente.A;
            }
            else if(this.radioButton2.Checked == true)
            {
                return CategoriaCliente.B;
            }
            else
            {
                return CategoriaCliente.C;
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
