using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaModeloVehiculo;

namespace CapaPresentacionVehiculo
{
    public partial class AnadirVehiculo : Form
    {
        


        public AnadirVehiculo()
        {
            InitializeComponent();
        }

        private void radioButton_nuevo_CheckedChanged(object sender, EventArgs e)
        {
            BindingSource bindingSourceExtras = new BindingSource();

            ListBox lista_extras = new ListBox();
            lista_extras.Location = new Point(450, 184);
            bindingSourceExtras.DataSource = listaExtras.Extras;
            lista_extras.DataSource = bindingSourceExtras;
            lista_extras.SelectionMode = SelectionMode.MultiSimple;

            lista_extras.DisplayMember = "Descripcion";      // esto es para indicarle que propiedad se muestra de la data source asociada. que es la pera

        }
    }
}
