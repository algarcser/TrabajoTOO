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
    public partial class Motrar_Todos_Vehiculos : Form
    {
        public Motrar_Todos_Vehiculos()
        {
            InitializeComponent();

            BindingSource bindingSource_Vehiculos= new BindingSource();
            bindingSource_Vehiculos.DataSource = LNExtras.SELECT_ALL();

            this.listBox_Marca.DataSource = bindingSource_Vehiculos;
            this.listBox_Marca.SelectionMode = SelectionMode.None;
            this.listBox_Marca.DisplayMember = "Marca";

            this.listBox_Modelo.DataSource = bindingSource_Vehiculos;
            this.listBox_Modelo.SelectionMode = SelectionMode.None;
            this.listBox_Modelo.DisplayMember = "Modelo";

            this.listBox_NBastidor.DataSource = bindingSource_Vehiculos;
            this.listBox_NBastidor.SelectionMode = SelectionMode.None;
            this.listBox_NBastidor.DisplayMember = "NBastidor";

            this.listBox_Potencia.DataSource = bindingSource_Vehiculos;
            this.listBox_Potencia.SelectionMode = SelectionMode.None;
            this.listBox_Potencia.DisplayMember = "Potencia";

            this.listBox_PrecioRecomendado.DataSource = bindingSource_Vehiculos;
            this.listBox_PrecioRecomendado.SelectionMode = SelectionMode.None;
            this.listBox_PrecioRecomendado.DisplayMember = "PrecioRecomendado";

            this.listBox_PVP.DataSource = bindingSource_Vehiculos;
            this.listBox_PVP.SelectionMode = SelectionMode.None;
            this.listBox_PVP.DisplayMember = "PVP";

            this.listBox_Tipo.DataSource = bindingSource_Vehiculos;
            this.listBox_Tipo.SelectionMode = SelectionMode.None;
            this.listBox_Tipo.DisplayMember = "Tipo";

        }
    }
}
