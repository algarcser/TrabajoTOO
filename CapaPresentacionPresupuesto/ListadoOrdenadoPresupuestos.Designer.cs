﻿
namespace CapaPresentacionPresupuesto
{
    partial class FormListadoOrdenadoPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListadoOrdenadoPresupuestos));
            this.lboFechaCreacion = new System.Windows.Forms.ListBox();
            this.lboCliente = new System.Windows.Forms.ListBox();
            this.lboEstado = new System.Windows.Forms.ListBox();
            this.lboNVehiculos = new System.Windows.Forms.ListBox();
            this.lboImporte = new System.Windows.Forms.ListBox();
            this.btMostrarPresupuesto = new System.Windows.Forms.Button();
            this.btRecorrerP1en1 = new System.Windows.Forms.Button();
            this.btMostrarCliente = new System.Windows.Forms.Button();
            this.btMostrarListaVehiculos = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboFechaCreacion
            // 
            this.lboFechaCreacion.FormattingEnabled = true;
            this.lboFechaCreacion.Location = new System.Drawing.Point(25, 93);
            this.lboFechaCreacion.Name = "lboFechaCreacion";
            this.lboFechaCreacion.Size = new System.Drawing.Size(120, 95);
            this.lboFechaCreacion.TabIndex = 0;
            // 
            // lboCliente
            // 
            this.lboCliente.FormattingEnabled = true;
            this.lboCliente.Location = new System.Drawing.Point(172, 93);
            this.lboCliente.Name = "lboCliente";
            this.lboCliente.Size = new System.Drawing.Size(120, 95);
            this.lboCliente.TabIndex = 1;
            // 
            // lboEstado
            // 
            this.lboEstado.FormattingEnabled = true;
            this.lboEstado.Location = new System.Drawing.Point(319, 93);
            this.lboEstado.Name = "lboEstado";
            this.lboEstado.Size = new System.Drawing.Size(120, 95);
            this.lboEstado.TabIndex = 2;
            // 
            // lboNVehiculos
            // 
            this.lboNVehiculos.FormattingEnabled = true;
            this.lboNVehiculos.Location = new System.Drawing.Point(466, 93);
            this.lboNVehiculos.Name = "lboNVehiculos";
            this.lboNVehiculos.Size = new System.Drawing.Size(120, 95);
            this.lboNVehiculos.TabIndex = 3;
            // 
            // lboImporte
            // 
            this.lboImporte.FormattingEnabled = true;
            this.lboImporte.Location = new System.Drawing.Point(613, 93);
            this.lboImporte.Name = "lboImporte";
            this.lboImporte.Size = new System.Drawing.Size(120, 95);
            this.lboImporte.TabIndex = 4;
            // 
            // btMostrarPresupuesto
            // 
            this.btMostrarPresupuesto.AutoSize = true;
            this.btMostrarPresupuesto.Location = new System.Drawing.Point(323, 237);
            this.btMostrarPresupuesto.Name = "btMostrarPresupuesto";
            this.btMostrarPresupuesto.Size = new System.Drawing.Size(113, 23);
            this.btMostrarPresupuesto.TabIndex = 10;
            this.btMostrarPresupuesto.Text = "Mostrar presupuesto";
            this.btMostrarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btRecorrerP1en1
            // 
            this.btRecorrerP1en1.AutoSize = true;
            this.btRecorrerP1en1.Location = new System.Drawing.Point(553, 269);
            this.btRecorrerP1en1.Name = "btRecorrerP1en1";
            this.btRecorrerP1en1.Size = new System.Drawing.Size(172, 23);
            this.btRecorrerP1en1.TabIndex = 11;
            this.btRecorrerP1en1.Text = "Recorrer presupuestos de 1 en 1";
            this.btRecorrerP1en1.UseVisualStyleBackColor = true;
            this.btRecorrerP1en1.Click += new System.EventHandler(this.btRecorrerP1en1_Click);
            // 
            // btMostrarCliente
            // 
            this.btMostrarCliente.AutoSize = true;
            this.btMostrarCliente.Location = new System.Drawing.Point(189, 205);
            this.btMostrarCliente.Name = "btMostrarCliente";
            this.btMostrarCliente.Size = new System.Drawing.Size(86, 23);
            this.btMostrarCliente.TabIndex = 13;
            this.btMostrarCliente.Text = "Mostrar cliente";
            this.btMostrarCliente.UseVisualStyleBackColor = true;
            this.btMostrarCliente.Click += new System.EventHandler(this.btMostrarCliente_Click);
            // 
            // btMostrarListaVehiculos
            // 
            this.btMostrarListaVehiculos.AutoSize = true;
            this.btMostrarListaVehiculos.Location = new System.Drawing.Point(457, 205);
            this.btMostrarListaVehiculos.Name = "btMostrarListaVehiculos";
            this.btMostrarListaVehiculos.Size = new System.Drawing.Size(138, 23);
            this.btMostrarListaVehiculos.TabIndex = 15;
            this.btMostrarListaVehiculos.Text = "Mostrar lista de vehículos";
            this.btMostrarListaVehiculos.UseVisualStyleBackColor = true;
            this.btMostrarListaVehiculos.Click += new System.EventHandler(this.btMostrarListaVehiculos_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(342, 301);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 16;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // FormListadoOrdenadoPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 362);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btMostrarListaVehiculos);
            this.Controls.Add(this.btMostrarCliente);
            this.Controls.Add(this.btRecorrerP1en1);
            this.Controls.Add(this.btMostrarPresupuesto);
            this.Controls.Add(this.lboImporte);
            this.Controls.Add(this.lboNVehiculos);
            this.Controls.Add(this.lboEstado);
            this.Controls.Add(this.lboCliente);
            this.Controls.Add(this.lboFechaCreacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListadoOrdenadoPresupuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de presupuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboFechaCreacion;
        private System.Windows.Forms.ListBox lboCliente;
        private System.Windows.Forms.ListBox lboEstado;
        private System.Windows.Forms.ListBox lboNVehiculos;
        private System.Windows.Forms.ListBox lboImporte;
        private System.Windows.Forms.Button btMostrarPresupuesto;
        private System.Windows.Forms.Button btRecorrerP1en1;
        private System.Windows.Forms.Button btMostrarCliente;
        private System.Windows.Forms.Button btMostrarListaVehiculos;
        private System.Windows.Forms.Button btCerrar;
    }
}