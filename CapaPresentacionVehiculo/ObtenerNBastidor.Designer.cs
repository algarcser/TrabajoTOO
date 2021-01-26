namespace CapaPresentacionVehiculo
{
    partial class ObtenerNBastidor
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
            this.components = new System.ComponentModel.Container();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.maskedTextBox_NBastidor = new System.Windows.Forms.MaskedTextBox();
            this.toolTip_NBastidor = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(72, 167);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 1;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(190, 167);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 2;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // maskedTextBox_NBastidor
            // 
            this.maskedTextBox_NBastidor.Location = new System.Drawing.Point(110, 83);
            this.maskedTextBox_NBastidor.Name = "maskedTextBox_NBastidor";
            this.maskedTextBox_NBastidor.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_NBastidor.TabIndex = 3;
            this.maskedTextBox_NBastidor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_NBastidor_MaskInputRejected);
            this.maskedTextBox_NBastidor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_NBastidor_KeyDown);
            // 
            // toolTip_NBastidor
            // 
            this.toolTip_NBastidor.IsBalloon = true;
            // 
            // ObtenerNBastidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 242);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.maskedTextBox_NBastidor);
            this.Name = "ObtenerNBastidor";
            this.Text = "Introducir el numero de bastidor";
            this.Load += new System.EventHandler(this.ObtenerNBastidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_NBastidor;
        private System.Windows.Forms.ToolTip toolTip_NBastidor;
    }
}