namespace CapaPresentacionVehiculo
{
    partial class Datos2Mano
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
            this.components = new System.ComponentModel.Container();
            this.label_matricula = new System.Windows.Forms.Label();
            this.label_fechaMatriculacion = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maskedTextBox_Matricula = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker_FechaMatriculacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_matricula
            // 
            this.label_matricula.AutoSize = true;
            this.label_matricula.Location = new System.Drawing.Point(14, 36);
            this.label_matricula.Name = "label_matricula";
            this.label_matricula.Size = new System.Drawing.Size(50, 13);
            this.label_matricula.TabIndex = 0;
            this.label_matricula.Text = "Matricula";
            // 
            // label_fechaMatriculacion
            // 
            this.label_fechaMatriculacion.AutoSize = true;
            this.label_fechaMatriculacion.Location = new System.Drawing.Point(14, 68);
            this.label_fechaMatriculacion.Name = "label_fechaMatriculacion";
            this.label_fechaMatriculacion.Size = new System.Drawing.Size(123, 13);
            this.label_fechaMatriculacion.TabIndex = 1;
            this.label_fechaMatriculacion.Text = "Fecha de matriculacion: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // maskedTextBox_Matricula
            // 
            this.maskedTextBox_Matricula.Location = new System.Drawing.Point(143, 33);
            this.maskedTextBox_Matricula.Name = "maskedTextBox_Matricula";
            this.maskedTextBox_Matricula.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Matricula.TabIndex = 4;
            // 
            // dateTimePicker_FechaMatriculacion
            // 
            this.dateTimePicker_FechaMatriculacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FechaMatriculacion.Location = new System.Drawing.Point(157, 68);
            this.dateTimePicker_FechaMatriculacion.Name = "dateTimePicker_FechaMatriculacion";
            this.dateTimePicker_FechaMatriculacion.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker_FechaMatriculacion.TabIndex = 6;
            // 
            // Datos2Mano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker_FechaMatriculacion);
            this.Controls.Add(this.maskedTextBox_Matricula);
            this.Controls.Add(this.label_fechaMatriculacion);
            this.Controls.Add(this.label_matricula);
            this.Name = "Datos2Mano";
            this.Size = new System.Drawing.Size(254, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_matricula;
        private System.Windows.Forms.Label label_fechaMatriculacion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Matricula;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaMatriculacion;
    }
}
