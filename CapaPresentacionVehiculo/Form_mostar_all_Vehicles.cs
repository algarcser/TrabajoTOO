using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocioVehiculo;

namespace CapaPresentacionVehiculo
{
    public partial class Form_mostar_all_Vehicles : Form
    {
        public Form_mostar_all_Vehicles()
        {
            InitializeComponent();

            BindingSource bindingSourceExtras = new BindingSource();
            bindingSourceExtras.DataSource = LNVehiculo.SELECT_ALL();

            this.listBox_NBastidor.DataSource = bindingSourceExtras;
            this.listBox_NBastidor.SelectionMode = SelectionMode.None;
            this.listBox_NBastidor.DisplayMember = "NBastidor";

            this.listBox_Marca.DataSource = bindingSourceExtras;
            this.listBox_Marca.SelectionMode = SelectionMode.None;
            this.listBox_Marca.DisplayMember = "Marca";

            this.listBox_Modelo.DataSource = bindingSourceExtras;
            this.listBox_Modelo.SelectionMode = SelectionMode.None;
            this.listBox_Modelo.DisplayMember = "Modelo";

            this.listBox_Potencia.DataSource = bindingSourceExtras;
            this.listBox_Potencia.SelectionMode = SelectionMode.None;
            this.listBox_Potencia.DisplayMember = "Potencia";

            this.listBox_PrecioRecomendado.DataSource = bindingSourceExtras;
            this.listBox_PrecioRecomendado.SelectionMode = SelectionMode.None;
            this.listBox_PrecioRecomendado.DisplayMember = "PrecioRecomendado";

            this.listBox_PVP.DataSource = bindingSourceExtras;
            this.listBox_PVP.SelectionMode = SelectionMode.None;
            this.listBox_PVP.DisplayMember = "PVP";

            this.listBox_Tipo.DataSource = bindingSourceExtras;
            this.listBox_Tipo.SelectionMode = SelectionMode.None;
            this.listBox_Tipo.DisplayMember = "Tipo";

        }
    }
}
