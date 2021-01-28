
namespace CapaPresentacionPresupuesto
{
    partial class FormIntroducirEstadoPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntroducirEstadoPresupuesto));
            this.cbCreado = new System.Windows.Forms.CheckBox();
            this.cbAceptado = new System.Windows.Forms.CheckBox();
            this.cbPendiente = new System.Windows.Forms.CheckBox();
            this.cbDesestimado = new System.Windows.Forms.CheckBox();
            this.lbInformacion = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCreado
            // 
            this.cbCreado.AutoSize = true;
            this.cbCreado.Location = new System.Drawing.Point(66, 47);
            this.cbCreado.Name = "cbCreado";
            this.cbCreado.Size = new System.Drawing.Size(60, 17);
            this.cbCreado.TabIndex = 0;
            this.cbCreado.Text = "Creado";
            this.cbCreado.UseVisualStyleBackColor = true;
            // 
            // cbAceptado
            // 
            this.cbAceptado.AutoSize = true;
            this.cbAceptado.Location = new System.Drawing.Point(66, 83);
            this.cbAceptado.Name = "cbAceptado";
            this.cbAceptado.Size = new System.Drawing.Size(72, 17);
            this.cbAceptado.TabIndex = 1;
            this.cbAceptado.Text = "Aceptado";
            this.cbAceptado.UseVisualStyleBackColor = true;
            // 
            // cbPendiente
            // 
            this.cbPendiente.AutoSize = true;
            this.cbPendiente.Location = new System.Drawing.Point(169, 47);
            this.cbPendiente.Name = "cbPendiente";
            this.cbPendiente.Size = new System.Drawing.Size(74, 17);
            this.cbPendiente.TabIndex = 2;
            this.cbPendiente.Text = "Pendiente";
            this.cbPendiente.UseVisualStyleBackColor = true;
            // 
            // cbDesestimado
            // 
            this.cbDesestimado.AutoSize = true;
            this.cbDesestimado.Location = new System.Drawing.Point(169, 83);
            this.cbDesestimado.Name = "cbDesestimado";
            this.cbDesestimado.Size = new System.Drawing.Size(87, 17);
            this.cbDesestimado.TabIndex = 3;
            this.cbDesestimado.Text = "Desestimado";
            this.cbDesestimado.UseVisualStyleBackColor = true;
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacion.Location = new System.Drawing.Point(12, 119);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(295, 13);
            this.lbInformacion.TabIndex = 4;
            this.lbInformacion.Text = "Puede marcar más de un estado para la búsqueda.";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(71, 153);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(177, 153);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(122, 17);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(73, 22);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Estados";
            // 
            // FormIntroducirEstadoPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 190);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbInformacion);
            this.Controls.Add(this.cbDesestimado);
            this.Controls.Add(this.cbPendiente);
            this.Controls.Add(this.cbAceptado);
            this.Controls.Add(this.cbCreado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIntroducirEstadoPresupuesto";
            this.Text = "Marcar estado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCreado;
        private System.Windows.Forms.CheckBox cbAceptado;
        private System.Windows.Forms.CheckBox cbPendiente;
        private System.Windows.Forms.CheckBox cbDesestimado;
        private System.Windows.Forms.Label lbInformacion;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbTitulo;
    }
}