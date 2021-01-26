
namespace CapaPresentacionPresupuesto
{
    partial class FormIntroducirNBastidorPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntroducirNBastidorPresupuesto));
            this.mtbNBastidor = new System.Windows.Forms.MaskedTextBox();
            this.lbNbastidor = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.ttNBastidor = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // mtbNBastidor
            // 
            this.mtbNBastidor.Location = new System.Drawing.Point(118, 68);
            this.mtbNBastidor.Name = "mtbNBastidor";
            this.mtbNBastidor.Size = new System.Drawing.Size(136, 20);
            this.mtbNBastidor.TabIndex = 0;
            this.mtbNBastidor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNBastidor_MaskInputRejected);
            this.mtbNBastidor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNBastidor_KeyDown);
            // 
            // lbNbastidor
            // 
            this.lbNbastidor.AutoSize = true;
            this.lbNbastidor.Location = new System.Drawing.Point(33, 72);
            this.lbNbastidor.Name = "lbNbastidor";
            this.lbNbastidor.Size = new System.Drawing.Size(77, 13);
            this.lbNbastidor.TabIndex = 1;
            this.lbNbastidor.Text = "Nº de bastidor:";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(48, 130);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(163, 130);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ttNBastidor
            // 
            this.ttNBastidor.IsBalloon = true;
            // 
            // FormIntroducirNBastidorPresupuesto
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 195);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbNbastidor);
            this.Controls.Add(this.mtbNBastidor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIntroducirNBastidorPresupuesto";
            this.Text = "Introducir Nº de bastidor";
            this.Load += new System.EventHandler(this.IntroducirNBastidorPresupuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbNBastidor;
        private System.Windows.Forms.Label lbNbastidor;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ToolTip ttNBastidor;
    }
}