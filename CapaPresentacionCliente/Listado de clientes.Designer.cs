namespace CapaPresentacionCliente
{
    partial class Listado_de_clientes
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
            this.listBoxDNI = new System.Windows.Forms.ListBox();
            this.listBoxNombre = new System.Windows.Forms.ListBox();
            this.listBoxImporte = new System.Windows.Forms.ListBox();
            this.btDNI = new System.Windows.Forms.Button();
            this.btNombre = new System.Windows.Forms.Button();
            this.btImporte = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDNI
            // 
            this.listBoxDNI.FormattingEnabled = true;
            this.listBoxDNI.Location = new System.Drawing.Point(41, 111);
            this.listBoxDNI.Name = "listBoxDNI";
            this.listBoxDNI.Size = new System.Drawing.Size(120, 173);
            this.listBoxDNI.TabIndex = 0;
            // 
            // listBoxNombre
            // 
            this.listBoxNombre.FormattingEnabled = true;
            this.listBoxNombre.Location = new System.Drawing.Point(219, 111);
            this.listBoxNombre.Name = "listBoxNombre";
            this.listBoxNombre.Size = new System.Drawing.Size(120, 173);
            this.listBoxNombre.TabIndex = 1;
            // 
            // listBoxImporte
            // 
            this.listBoxImporte.FormattingEnabled = true;
            this.listBoxImporte.Location = new System.Drawing.Point(396, 111);
            this.listBoxImporte.Name = "listBoxImporte";
            this.listBoxImporte.Size = new System.Drawing.Size(120, 173);
            this.listBoxImporte.TabIndex = 2;
            // 
            // btDNI
            // 
            this.btDNI.Location = new System.Drawing.Point(41, 57);
            this.btDNI.Name = "btDNI";
            this.btDNI.Size = new System.Drawing.Size(120, 31);
            this.btDNI.TabIndex = 3;
            this.btDNI.Text = "DNI";
            this.btDNI.UseVisualStyleBackColor = true;
            this.btDNI.Click += new System.EventHandler(this.btDNI_Click);
            // 
            // btNombre
            // 
            this.btNombre.Location = new System.Drawing.Point(219, 57);
            this.btNombre.Name = "btNombre";
            this.btNombre.Size = new System.Drawing.Size(120, 31);
            this.btNombre.TabIndex = 4;
            this.btNombre.Text = "Nombre";
            this.btNombre.UseVisualStyleBackColor = true;
            this.btNombre.Click += new System.EventHandler(this.btNombre_Click);
            // 
            // btImporte
            // 
            this.btImporte.Location = new System.Drawing.Point(396, 57);
            this.btImporte.Name = "btImporte";
            this.btImporte.Size = new System.Drawing.Size(120, 31);
            this.btImporte.TabIndex = 5;
            this.btImporte.Text = "Importe";
            this.btImporte.UseVisualStyleBackColor = true;
            this.btImporte.Click += new System.EventHandler(this.btImporte_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(219, 333);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(120, 35);
            this.btCerrar.TabIndex = 6;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // Listado_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 402);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btImporte);
            this.Controls.Add(this.btNombre);
            this.Controls.Add(this.btDNI);
            this.Controls.Add(this.listBoxImporte);
            this.Controls.Add(this.listBoxNombre);
            this.Controls.Add(this.listBoxDNI);
            this.Name = "Listado_de_clientes";
            this.Text = "Listado_de_clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDNI;
        private System.Windows.Forms.ListBox listBoxNombre;
        private System.Windows.Forms.ListBox listBoxImporte;
        private System.Windows.Forms.Button btDNI;
        private System.Windows.Forms.Button btNombre;
        private System.Windows.Forms.Button btImporte;
        private System.Windows.Forms.Button btCerrar;
    }
}