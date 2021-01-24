
namespace CapaPresentacionGeneral
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPresupuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrearPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBPPorCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBPPorVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBPPorEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMostrarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiVehiculos,
            this.tsmiPresupuestos,
            this.tsmiConfiguracion});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(706, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaCliente,
            this.tsmiBajaCliente,
            this.tsmiBusquedaCliente});
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmiClientes.Text = "Clientes";
            // 
            // tsmiAltaCliente
            // 
            this.tsmiAltaCliente.Name = "tsmiAltaCliente";
            this.tsmiAltaCliente.Size = new System.Drawing.Size(126, 22);
            this.tsmiAltaCliente.Text = "Alta";
            this.tsmiAltaCliente.Click += new System.EventHandler(this.tsmiAltaCliente_Click);
            // 
            // tsmiBajaCliente
            // 
            this.tsmiBajaCliente.Name = "tsmiBajaCliente";
            this.tsmiBajaCliente.Size = new System.Drawing.Size(126, 22);
            this.tsmiBajaCliente.Text = "Baja";
            this.tsmiBajaCliente.Click += new System.EventHandler(this.tsmiBajaCliente_Click);
            // 
            // tsmiBusquedaCliente
            // 
            this.tsmiBusquedaCliente.Name = "tsmiBusquedaCliente";
            this.tsmiBusquedaCliente.Size = new System.Drawing.Size(126, 22);
            this.tsmiBusquedaCliente.Text = "Búsqueda";
            this.tsmiBusquedaCliente.Click += new System.EventHandler(this.tsmiBusquedaCliente_Click);
            // 
            // tsmiVehiculos
            // 
            this.tsmiVehiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaVehiculo,
            this.tsmiBusquedaVehiculo,
            this.bajaToolStripMenuItem});
            this.tsmiVehiculos.Name = "tsmiVehiculos";
            this.tsmiVehiculos.Size = new System.Drawing.Size(69, 20);
            this.tsmiVehiculos.Text = "Vehículos";
            // 
            // tsmiAltaVehiculo
            // 
            this.tsmiAltaVehiculo.Name = "tsmiAltaVehiculo";
            this.tsmiAltaVehiculo.Size = new System.Drawing.Size(126, 22);
            this.tsmiAltaVehiculo.Text = "Alta";
            this.tsmiAltaVehiculo.Click += new System.EventHandler(this.tsmiAltaVehiculo_Click);
            // 
            // tsmiBusquedaVehiculo
            // 
            this.tsmiBusquedaVehiculo.Name = "tsmiBusquedaVehiculo";
            this.tsmiBusquedaVehiculo.Size = new System.Drawing.Size(126, 22);
            this.tsmiBusquedaVehiculo.Text = "Búsqueda";
            this.tsmiBusquedaVehiculo.Click += new System.EventHandler(this.tsmiBusquedaVehiculo_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // tsmiPresupuestos
            // 
            this.tsmiPresupuestos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrearPresupuesto,
            this.tsmiBusquedaPresupuesto,
            this.tsmiMostrarTodos});
            this.tsmiPresupuestos.Name = "tsmiPresupuestos";
            this.tsmiPresupuestos.Size = new System.Drawing.Size(89, 20);
            this.tsmiPresupuestos.Text = "Presupuestos";
            // 
            // tsmiCrearPresupuesto
            // 
            this.tsmiCrearPresupuesto.Name = "tsmiCrearPresupuesto";
            this.tsmiCrearPresupuesto.Size = new System.Drawing.Size(180, 22);
            this.tsmiCrearPresupuesto.Text = "Crear";
            this.tsmiCrearPresupuesto.Click += new System.EventHandler(this.tsmiCrearPresupuesto_Click);
            // 
            // tsmiBusquedaPresupuesto
            // 
            this.tsmiBusquedaPresupuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBPPorCliente,
            this.tsmiBPPorVehiculo,
            this.tsmiBPPorEstado});
            this.tsmiBusquedaPresupuesto.Name = "tsmiBusquedaPresupuesto";
            this.tsmiBusquedaPresupuesto.Size = new System.Drawing.Size(180, 22);
            this.tsmiBusquedaPresupuesto.Text = "Búsqueda";
            // 
            // tsmiBPPorCliente
            // 
            this.tsmiBPPorCliente.Name = "tsmiBPPorCliente";
            this.tsmiBPPorCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmiBPPorCliente.Text = "Por cliente";
            this.tsmiBPPorCliente.Click += new System.EventHandler(this.tsmiBPPorCliente_Click);
            // 
            // tsmiBPPorVehiculo
            // 
            this.tsmiBPPorVehiculo.Name = "tsmiBPPorVehiculo";
            this.tsmiBPPorVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsmiBPPorVehiculo.Text = "Por vehículo";
            // 
            // tsmiBPPorEstado
            // 
            this.tsmiBPPorEstado.Name = "tsmiBPPorEstado";
            this.tsmiBPPorEstado.Size = new System.Drawing.Size(180, 22);
            this.tsmiBPPorEstado.Text = "Por estado";
            // 
            // tsmiConfiguracion
            // 
            this.tsmiConfiguracion.Name = "tsmiConfiguracion";
            this.tsmiConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.tsmiConfiguracion.Text = "Configuración";
            // 
            // tsmiMostrarTodos
            // 
            this.tsmiMostrarTodos.Name = "tsmiMostrarTodos";
            this.tsmiMostrarTodos.Size = new System.Drawing.Size(180, 22);
            this.tsmiMostrarTodos.Text = "Mostrar todos";
            this.tsmiMostrarTodos.Click += new System.EventHandler(this.tsmiMostrarTodos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 349);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Concesionario Pepérez® - v1.0.19012021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPresupuestos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem tsmiBPPorCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiBPPorVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBPPorEstado;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMostrarTodos;
    }
}