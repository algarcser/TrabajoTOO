namespace CapaPresentacionCliente
{
    partial class Busqueda_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_cliente));
            this.button1 = new System.Windows.Forms.Button();
            this.control_alternativo_datos_cliente1 = new CapaPresentacionCliente.Control_alternativo_datos_cliente();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // control_alternativo_datos_cliente1
            // 
            this.control_alternativo_datos_cliente1.Location = new System.Drawing.Point(-2, 0);
            this.control_alternativo_datos_cliente1.Name = "control_alternativo_datos_cliente1";
            this.control_alternativo_datos_cliente1.Size = new System.Drawing.Size(279, 274);
            this.control_alternativo_datos_cliente1.TabIndex = 2;
            // 
            // Busqueda_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 317);
            this.Controls.Add(this.control_alternativo_datos_cliente1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Busqueda_cliente";
            this.Text = "Busqueda_cliente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Control_alternativo_datos_cliente control_alternativo_datos_cliente1;
    }
}