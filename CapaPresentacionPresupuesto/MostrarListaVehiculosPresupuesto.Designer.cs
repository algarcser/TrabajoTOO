
namespace CapaPresentacionPresupuesto
{
    partial class FormMostrarListaVehiculosPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarListaVehiculosPresupuesto));
            this.lboVehiculos = new System.Windows.Forms.ListBox();
            this.btMostrarVehiculo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboVehiculos
            // 
            this.lboVehiculos.FormattingEnabled = true;
            this.lboVehiculos.Location = new System.Drawing.Point(23, 26);
            this.lboVehiculos.Name = "lboVehiculos";
            this.lboVehiculos.Size = new System.Drawing.Size(120, 95);
            this.lboVehiculos.TabIndex = 0;
            // 
            // btMostrarVehiculo
            // 
            this.btMostrarVehiculo.AutoSize = true;
            this.btMostrarVehiculo.Location = new System.Drawing.Point(176, 26);
            this.btMostrarVehiculo.Name = "btMostrarVehiculo";
            this.btMostrarVehiculo.Size = new System.Drawing.Size(97, 23);
            this.btMostrarVehiculo.TabIndex = 1;
            this.btMostrarVehiculo.Text = "Mostrar vehículo";
            this.btMostrarVehiculo.UseVisualStyleBackColor = true;
            this.btMostrarVehiculo.Click += new System.EventHandler(this.btMostrarVehiculo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMostrarListaVehiculosPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 222);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMostrarVehiculo);
            this.Controls.Add(this.lboVehiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMostrarListaVehiculosPresupuesto";
            this.Text = "Lista de vehículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboVehiculos;
        private System.Windows.Forms.Button btMostrarVehiculo;
        private System.Windows.Forms.Button button2;
    }
}