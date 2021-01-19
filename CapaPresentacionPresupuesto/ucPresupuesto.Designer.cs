
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbCreado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbAceptado = new System.Windows.Forms.RadioButton();
            this.rbDesestimado = new System.Windows.Forms.RadioButton();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btMostrarCliente = new System.Windows.Forms.Button();
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.btIntroducirVehiculo = new System.Windows.Forms.Button();
            this.btMostrarVehiculo = new System.Windows.Forms.Button();
            this.lboListaVehiculos = new System.Windows.Forms.ListBox();
            this.lbListaVehiculos = new System.Windows.Forms.Label();
            this.btSeleccionarCliente = new System.Windows.Forms.Button();
            this.btSeleccionarVehiculo = new System.Windows.Forms.Button();
            this.btIntroducirCliente = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbEstado.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(15, 10);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID nº";
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(75, 10);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(99, 13);
            this.lbFechaCreacion.TabIndex = 1;
            this.lbFechaCreacion.Text = "Fecha de creación:";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbDesestimado);
            this.gbEstado.Controls.Add(this.rbAceptado);
            this.gbEstado.Controls.Add(this.rbPendiente);
            this.gbEstado.Controls.Add(this.rbCreado);
            this.gbEstado.Location = new System.Drawing.Point(78, 36);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(225, 79);
            this.gbEstado.TabIndex = 5;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbCreado
            // 
            this.rbCreado.AutoSize = true;
            this.rbCreado.Location = new System.Drawing.Point(22, 15);
            this.rbCreado.Name = "rbCreado";
            this.rbCreado.Size = new System.Drawing.Size(59, 17);
            this.rbCreado.TabIndex = 0;
            this.rbCreado.TabStop = true;
            this.rbCreado.Text = "Creado";
            this.rbCreado.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Location = new System.Drawing.Point(116, 15);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbPendiente.TabIndex = 1;
            this.rbPendiente.TabStop = true;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbAceptado
            // 
            this.rbAceptado.AutoSize = true;
            this.rbAceptado.Location = new System.Drawing.Point(22, 47);
            this.rbAceptado.Name = "rbAceptado";
            this.rbAceptado.Size = new System.Drawing.Size(71, 17);
            this.rbAceptado.TabIndex = 2;
            this.rbAceptado.TabStop = true;
            this.rbAceptado.Text = "Aceptado";
            this.rbAceptado.UseVisualStyleBackColor = true;
            // 
            // rbDesestimado
            // 
            this.rbDesestimado.AutoSize = true;
            this.rbDesestimado.Location = new System.Drawing.Point(116, 47);
            this.rbDesestimado.Name = "rbDesestimado";
            this.rbDesestimado.Size = new System.Drawing.Size(86, 17);
            this.rbDesestimado.TabIndex = 3;
            this.rbDesestimado.TabStop = true;
            this.rbDesestimado.Text = "Desestimado";
            this.rbDesestimado.UseVisualStyleBackColor = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btIntroducirCliente);
            this.gbCliente.Controls.Add(this.btSeleccionarCliente);
            this.gbCliente.Controls.Add(this.btMostrarCliente);
            this.gbCliente.Controls.Add(this.lbNombre);
            this.gbCliente.Controls.Add(this.lbDNI);
            this.gbCliente.Controls.Add(this.tbNombre);
            this.gbCliente.Controls.Add(this.tbDNI);
            this.gbCliente.Location = new System.Drawing.Point(33, 121);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(315, 89);
            this.gbCliente.TabIndex = 12;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(48, 20);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(207, 20);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
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
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(154, 24);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // btMostrarCliente
            // 
            this.btMostrarCliente.AutoSize = true;
            this.btMostrarCliente.Location = new System.Drawing.Point(221, 46);
            this.btMostrarCliente.Name = "btMostrarCliente";
            this.btMostrarCliente.Size = new System.Drawing.Size(86, 23);
            this.btMostrarCliente.TabIndex = 4;
            this.btMostrarCliente.Text = "Mostrar cliente";
            this.btMostrarCliente.UseVisualStyleBackColor = true;
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.btSeleccionarVehiculo);
            this.gbVehiculos.Controls.Add(this.lbListaVehiculos);
            this.gbVehiculos.Controls.Add(this.lboListaVehiculos);
            this.gbVehiculos.Controls.Add(this.btMostrarVehiculo);
            this.gbVehiculos.Controls.Add(this.btIntroducirVehiculo);
            this.gbVehiculos.Location = new System.Drawing.Point(21, 216);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Size = new System.Drawing.Size(339, 164);
            this.gbVehiculos.TabIndex = 13;
            this.gbVehiculos.TabStop = false;
            this.gbVehiculos.Text = "Vehículos";
            // 
            // btIntroducirVehiculo
            // 
            this.btIntroducirVehiculo.AutoSize = true;
            this.btIntroducirVehiculo.Location = new System.Drawing.Point(188, 19);
            this.btIntroducirVehiculo.Name = "btIntroducirVehiculo";
            this.btIntroducirVehiculo.Size = new System.Drawing.Size(106, 23);
            this.btIntroducirVehiculo.TabIndex = 0;
            this.btIntroducirVehiculo.Text = "Introducir vehículo";
            this.btIntroducirVehiculo.UseVisualStyleBackColor = true;
            // 
            // btMostrarVehiculo
            // 
            this.btMostrarVehiculo.AutoSize = true;
            this.btMostrarVehiculo.Location = new System.Drawing.Point(233, 93);
            this.btMostrarVehiculo.Name = "btMostrarVehiculo";
            this.btMostrarVehiculo.Size = new System.Drawing.Size(97, 23);
            this.btMostrarVehiculo.TabIndex = 1;
            this.btMostrarVehiculo.Text = "Mostrar vehículo";
            this.btMostrarVehiculo.UseVisualStyleBackColor = true;
            // 
            // lboListaVehiculos
            // 
            this.lboListaVehiculos.FormattingEnabled = true;
            this.lboListaVehiculos.Location = new System.Drawing.Point(120, 57);
            this.lboListaVehiculos.Name = "lboListaVehiculos";
            this.lboListaVehiculos.Size = new System.Drawing.Size(105, 95);
            this.lboListaVehiculos.TabIndex = 2;
            // 
            // lbListaVehiculos
            // 
            this.lbListaVehiculos.AutoSize = true;
            this.lbListaVehiculos.Location = new System.Drawing.Point(17, 57);
            this.lbListaVehiculos.Name = "lbListaVehiculos";
            this.lbListaVehiculos.Size = new System.Drawing.Size(97, 13);
            this.lbListaVehiculos.TabIndex = 3;
            this.lbListaVehiculos.Text = "Lista de vehículos:";
            // 
            // btSeleccionarCliente
            // 
            this.btSeleccionarCliente.AutoSize = true;
            this.btSeleccionarCliente.Location = new System.Drawing.Point(7, 46);
            this.btSeleccionarCliente.Name = "btSeleccionarCliente";
            this.btSeleccionarCliente.Size = new System.Drawing.Size(107, 23);
            this.btSeleccionarCliente.TabIndex = 5;
            this.btSeleccionarCliente.Text = "Seleccionar cliente";
            this.btSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // btSeleccionarVehiculo
            // 
            this.btSeleccionarVehiculo.AutoSize = true;
            this.btSeleccionarVehiculo.Location = new System.Drawing.Point(44, 19);
            this.btSeleccionarVehiculo.Name = "btSeleccionarVehiculo";
            this.btSeleccionarVehiculo.Size = new System.Drawing.Size(116, 23);
            this.btSeleccionarVehiculo.TabIndex = 4;
            this.btSeleccionarVehiculo.Text = "Seleccionar vehiculo";
            this.btSeleccionarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btIntroducirCliente
            // 
            this.btIntroducirCliente.AutoSize = true;
            this.btIntroducirCliente.Location = new System.Drawing.Point(121, 46);
            this.btIntroducirCliente.Name = "btIntroducirCliente";
            this.btIntroducirCliente.Size = new System.Drawing.Size(95, 23);
            this.btIntroducirCliente.TabIndex = 6;
            this.btIntroducirCliente.Text = "Introducir cliente";
            this.btIntroducirCliente.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(78, 395);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(222, 395);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // ucPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbVehiculos);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.lbFechaCreacion);
            this.Controls.Add(this.lbID);
            this.Name = "ucPresupuesto";
            this.Size = new System.Drawing.Size(374, 430);
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

        private System.Windows.Forms.Label lbID;
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
        private System.Windows.Forms.Button btIntroducirCliente;
        private System.Windows.Forms.Button btSeleccionarCliente;
        private System.Windows.Forms.Button btSeleccionarVehiculo;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}
