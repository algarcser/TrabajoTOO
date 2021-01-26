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

        public void setDNI(string DNI)
        {
            this.textBox1.Text = DNI;
        }

        public String getNombre()
        {
            return this.textBox2.Text;
        }
        public void setNombre(string nom)
        {
            this.textBox2.Text = nom;
        }

        public String getTelefono()
        {
            return this.textBox3.Text;
        }

        public void setTfno(string tfno)
        {
            this.textBox3.Text = tfno;
        }

        public CategoriaCliente getCategoria()
        {
            if (this.radioButton1.Checked == true)
            {
                return CategoriaCliente.A;
            }
            else if (this.radioButton2.Checked == true)
            {
                return CategoriaCliente.B;
            }
            else
            {
                return CategoriaCliente.C;
            }
        }

        public void setCategoria(CategoriaCliente cat)
        {
            if (cat.Equals(CategoriaCliente.A))
            {
                this.radioButton1.Checked = true;
            }
            if (cat.Equals(CategoriaCliente.B))
            {
                this.radioButton2.Checked = true;
            }
            if (cat.Equals(CategoriaCliente.C))
            {
                this.radioButton3.Checked = true;
            }

        }

        public bool getAchecked()
        {
            return this.radioButton1.Checked;
        }

        public bool getBchecked()
        {
            return this.radioButton2.Checked;
        }

        public bool getCchecked()
        {
            return this.radioButton3.Checked;
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
            this.radioButton2.Enabled = b;
            return this.textBox1.ReadOnly;
        }

        public bool rbC_Enabled(bool b)
        {
            this.radioButton3.Enabled = b;
            return this.textBox1.ReadOnly;
        }
    }
}
