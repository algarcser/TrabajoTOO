using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionGeneral
{
    public partial class gestionador : Form
    {

        public static gestionador login_instance;
        public gestionador()
        {
            login_instance = this;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;

            InitializeComponent();

            Login login_form = new Login();
            login_form.Show();
        }

        
    }
}
