namespace CapaPresentacionVehiculo
{
    partial class Gestionar_Extra
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
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.TextBox_Precio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(37, 52);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(61, 13);
            this.label_descripcion.TabIndex = 0;
            this.label_descripcion.Text = "descripcion";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(37, 122);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(36, 13);
            this.label_precio.TabIndex = 1;
            this.label_precio.Text = "precio";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(119, 49);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(195, 20);
            this.textBox_descripcion.TabIndex = 2;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(93, 163);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 4;
            this.button_aceptar.Text = "aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(249, 163);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // TextBox_Precio
            // 
            this.TextBox_Precio.Location = new System.Drawing.Point(119, 115);
            this.TextBox_Precio.Name = "TextBox_Precio";
            this.TextBox_Precio.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Precio.TabIndex = 7;
            this.TextBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_KeyPress);
            // 
            // Gestionar_Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 202);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.TextBox_Precio);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_descripcion);
            this.Name = "Gestionar_Extra";
            this.Text = "introducir un extra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox TextBox_Precio;
    }
}