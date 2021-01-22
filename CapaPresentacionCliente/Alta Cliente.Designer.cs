namespace CapaPresentacionCliente
{
    partial class Alta_Cliente
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
            this.control_datos_cliente1 = new CapaPresentacionCliente.Control_datos_cliente();
            this.SuspendLayout();
            // 
            // control_datos_cliente1
            // 
            this.control_datos_cliente1.Location = new System.Drawing.Point(0, 0);
            this.control_datos_cliente1.Name = "control_datos_cliente1";
            this.control_datos_cliente1.Size = new System.Drawing.Size(274, 269);
            this.control_datos_cliente1.TabIndex = 0;
            // 
            // Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 270);
            this.Controls.Add(this.control_datos_cliente1);
            this.Name = "Alta_Cliente";
            this.Text = "Alta_Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private Control_datos_cliente control_datos_cliente1;
    }
}