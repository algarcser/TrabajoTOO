
namespace CapaPresentacionPresupuesto
{
    partial class FormIntroducirDNIPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntroducirDNIPresupuesto));
            this.mtbDNI = new System.Windows.Forms.MaskedTextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.ttDNI = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // mtbDNI
            // 
            this.mtbDNI.Location = new System.Drawing.Point(122, 62);
            this.mtbDNI.Name = "mtbDNI";
            this.mtbDNI.Size = new System.Drawing.Size(90, 20);
            this.mtbDNI.TabIndex = 0;
            this.mtbDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDNI_MaskInputRejected);
            this.mtbDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbDNI_KeyDown);
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(50, 66);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(29, 13);
            this.lbDNI.TabIndex = 1;
            this.lbDNI.Text = "DNI:";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(45, 130);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(152, 130);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ttDNI
            // 
            this.ttDNI.IsBalloon = true;
            // 
            // FormIntroducirDNIPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 195);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.mtbDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIntroducirDNIPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introducir DNI";
            this.Load += new System.EventHandler(this.FormIntroducirDNIPresupuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDNI;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ToolTip ttDNI;
    }
}