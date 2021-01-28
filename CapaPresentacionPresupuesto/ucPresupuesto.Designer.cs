
namespace CapaPresentacionPresupuesto
{
    partial class ucPresupuesto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbDesestimado = new System.Windows.Forms.RadioButton();
            this.rbCreado = new System.Windows.Forms.RadioButton();
            this.rbAceptado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btMostrarCliente = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.btQuitarVehiculo = new System.Windows.Forms.Button();
            this.lbListaVehiculos = new System.Windows.Forms.Label();
            this.lboListaVehiculos = new System.Windows.Forms.ListBox();
            this.btMostrarVehiculo = new System.Windows.Forms.Button();
            this.btIntroducirVehiculo = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbImporte = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.gbEstado.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(18, 10);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(99, 13);
            this.lbFechaCreacion.TabIndex = 1;
            this.lbFechaCreacion.Text = "Fecha de creación:";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbDesestimado);
            this.gbEstado.Controls.Add(this.rbCreado);
            this.gbEstado.Controls.Add(this.rbAceptado);
            this.gbEstado.Controls.Add(this.rbPendiente);
            this.gbEstado.Location = new System.Drawing.Point(75, 131);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(225, 79);
            this.gbEstado.TabIndex = 5;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbDesestimado
            // 
            this.rbDesestimado.AutoSize = true;
            this.rbDesestimado.Location = new System.Drawing.Point(116, 47);
            this.rbDesestimado.Name = "rbDesestimado";
            this.rbDesestimado.Size = new System.Drawing.Size(86, 17);
            this.rbDesestimado.TabIndex = 3;
            this.rbDesestimado.Text = "Desestimado";
            this.rbDesestimado.UseVisualStyleBackColor = true;
            this.rbDesestimado.CheckedChanged += new System.EventHandler(this.rbDesestimado_CheckedChanged);
            // 
            // rbCreado
            // 
            this.rbCreado.AutoCheck = false;
            this.rbCreado.AutoSize = true;
            this.rbCreado.Location = new System.Drawing.Point(22, 15);
            this.rbCreado.Name = "rbCreado";
            this.rbCreado.Size = new System.Drawing.Size(59, 17);
            this.rbCreado.TabIndex = 0;
            this.rbCreado.Text = "Creado";
            this.rbCreado.UseVisualStyleBackColor = true;
            this.rbCreado.CheckedChanged += new System.EventHandler(this.rbCreado_CheckedChanged);
            // 
            // rbAceptado
            // 
            this.rbAceptado.AutoSize = true;
            this.rbAceptado.Location = new System.Drawing.Point(22, 47);
            this.rbAceptado.Name = "rbAceptado";
            this.rbAceptado.Size = new System.Drawing.Size(71, 17);
            this.rbAceptado.TabIndex = 2;
            this.rbAceptado.Text = "Aceptado";
            this.rbAceptado.UseVisualStyleBackColor = true;
            this.rbAceptado.CheckedChanged += new System.EventHandler(this.rbAceptado_CheckedChanged);
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Location = new System.Drawing.Point(116, 15);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbPendiente.TabIndex = 1;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            this.rbPendiente.CheckedChanged += new System.EventHandler(this.rbPendiente_CheckedChanged);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btMostrarCliente);
            this.gbCliente.Controls.Add(this.lbNombre);
            this.gbCliente.Controls.Add(this.lbDNI);
            this.gbCliente.Controls.Add(this.tbNombre);
            this.gbCliente.Controls.Add(this.tbDNI);
            this.gbCliente.Location = new System.Drawing.Point(30, 36);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(315, 89);
            this.gbCliente.TabIndex = 12;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btMostrarCliente
            // 
            this.btMostrarCliente.AutoSize = true;
            this.btMostrarCliente.Location = new System.Drawing.Point(114, 60);
            this.btMostrarCliente.Name = "btMostrarCliente";
            this.btMostrarCliente.Size = new System.Drawing.Size(86, 23);
            this.btMostrarCliente.TabIndex = 4;
            this.btMostrarCliente.Text = "Mostrar cliente";
            this.btMostrarCliente.UseVisualStyleBackColor = true;
            this.btMostrarCliente.Click += new System.EventHandler(this.btMostrarCliente_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(154, 24);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(13, 24);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(29, 13);
            this.lbDNI.TabIndex = 2;
            this.lbDNI.Text = "DNI:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(207, 20);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(48, 20);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 0;
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.btQuitarVehiculo);
            this.gbVehiculos.Controls.Add(this.lbListaVehiculos);
            this.gbVehiculos.Controls.Add(this.lboListaVehiculos);
            this.gbVehiculos.Controls.Add(this.btMostrarVehiculo);
            this.gbVehiculos.Controls.Add(this.btIntroducirVehiculo);
            this.gbVehiculos.Location = new System.Drawing.Point(49, 216);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Size = new System.Drawing.Size(276, 194);
            this.gbVehiculos.TabIndex = 13;
            this.gbVehiculos.TabStop = false;
            this.gbVehiculos.Text = "Vehículos";
            // 
            // btQuitarVehiculo
            // 
            this.btQuitarVehiculo.AutoSize = true;
            this.btQuitarVehiculo.Location = new System.Drawing.Point(16, 118);
            this.btQuitarVehiculo.Name = "btQuitarVehiculo";
            this.btQuitarVehiculo.Size = new System.Drawing.Size(88, 23);
            this.btQuitarVehiculo.TabIndex = 4;
            this.btQuitarVehiculo.Text = "Quitar vehiculo";
            this.btQuitarVehiculo.UseVisualStyleBackColor = true;
            this.btQuitarVehiculo.Click += new System.EventHandler(this.btQuitarVehiculo_Click);
            // 
            // lbListaVehiculos
            // 
            this.lbListaVehiculos.AutoSize = true;
            this.lbListaVehiculos.Location = new System.Drawing.Point(13, 59);
            this.lbListaVehiculos.Name = "lbListaVehiculos";
            this.lbListaVehiculos.Size = new System.Drawing.Size(97, 13);
            this.lbListaVehiculos.TabIndex = 3;
            this.lbListaVehiculos.Text = "Lista de vehículos:";
            // 
            // lboListaVehiculos
            // 
            this.lboListaVehiculos.FormattingEnabled = true;
            this.lboListaVehiculos.Location = new System.Drawing.Point(116, 59);
            this.lboListaVehiculos.Name = "lboListaVehiculos";
            this.lboListaVehiculos.Size = new System.Drawing.Size(140, 82);
            this.lboListaVehiculos.TabIndex = 2;
            // 
            // btMostrarVehiculo
            // 
            this.btMostrarVehiculo.AutoSize = true;
            this.btMostrarVehiculo.Location = new System.Drawing.Point(138, 158);
            this.btMostrarVehiculo.Name = "btMostrarVehiculo";
            this.btMostrarVehiculo.Size = new System.Drawing.Size(97, 23);
            this.btMostrarVehiculo.TabIndex = 1;
            this.btMostrarVehiculo.Text = "Mostrar vehículo";
            this.btMostrarVehiculo.UseVisualStyleBackColor = true;
            this.btMostrarVehiculo.Click += new System.EventHandler(this.btMostrarVehiculo_Click);
            // 
            // btIntroducirVehiculo
            // 
            this.btIntroducirVehiculo.AutoSize = true;
            this.btIntroducirVehiculo.Location = new System.Drawing.Point(133, 19);
            this.btIntroducirVehiculo.Name = "btIntroducirVehiculo";
            this.btIntroducirVehiculo.Size = new System.Drawing.Size(106, 23);
            this.btIntroducirVehiculo.TabIndex = 0;
            this.btIntroducirVehiculo.Text = "Introducir vehículo";
            this.btIntroducirVehiculo.UseVisualStyleBackColor = true;
            this.btIntroducirVehiculo.Click += new System.EventHandler(this.btIntroducirVehiculo_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(78, 452);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(222, 452);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImporte.Location = new System.Drawing.Point(95, 423);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(64, 16);
            this.lbImporte.TabIndex = 16;
            this.lbImporte.Text = "Importe:";
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(187, 421);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.ReadOnly = true;
            this.tbImporte.Size = new System.Drawing.Size(100, 20);
            this.tbImporte.TabIndex = 17;
            // 
            // ucPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.lbImporte);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbVehiculos);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.lbFechaCreacion);
            this.Name = "ucPresupuesto";
            this.Size = new System.Drawing.Size(374, 495);
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbVehiculos.ResumeLayout(false);
            this.gbVehiculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbDesestimado;
        private System.Windows.Forms.RadioButton rbAceptado;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.RadioButton rbCreado;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btMostrarCliente;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.GroupBox gbVehiculos;
        private System.Windows.Forms.Label lbListaVehiculos;
        private System.Windows.Forms.ListBox lboListaVehiculos;
        private System.Windows.Forms.Button btMostrarVehiculo;
        private System.Windows.Forms.Button btIntroducirVehiculo;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.Button btQuitarVehiculo;
        private System.Windows.Forms.TextBox tbImporte;
    }
}
