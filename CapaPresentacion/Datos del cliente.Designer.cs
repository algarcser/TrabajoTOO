namespace CapaPresentacion
{
    partial class Datos_del_cliente
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
            this.alta_de_un_cliente1 = new CapaPresentacion.Alta_de_un_cliente();
            this.SuspendLayout();
            // 
            // alta_de_un_cliente1
            // 
            this.alta_de_un_cliente1.Location = new System.Drawing.Point(-1, -2);
            this.alta_de_un_cliente1.Name = "alta_de_un_cliente1";
            this.alta_de_un_cliente1.Size = new System.Drawing.Size(301, 306);
            this.alta_de_un_cliente1.TabIndex = 0;
            // 
            // Datos_del_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 307);
            this.Controls.Add(this.alta_de_un_cliente1);
            this.Name = "Datos_del_cliente";
            this.Text = "Datos_del_cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private Alta_de_un_cliente alta_de_un_cliente1;
    }
}