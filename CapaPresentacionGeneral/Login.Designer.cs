
namespace CapaPresentacionGeneral
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.cbMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(31, 42);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(58, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(31, 86);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(80, 16);
            this.lbContraseña.TabIndex = 1;
            this.lbContraseña.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(137, 40);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(137, 84);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(105, 141);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // cbMostrarContraseña
            // 
            this.cbMostrarContraseña.AutoSize = true;
            this.cbMostrarContraseña.Location = new System.Drawing.Point(137, 108);
            this.cbMostrarContraseña.Name = "cbMostrarContraseña";
            this.cbMostrarContraseña.Size = new System.Drawing.Size(117, 17);
            this.cbMostrarContraseña.TabIndex = 5;
            this.cbMostrarContraseña.Text = "Mostrar contraseña";
            this.cbMostrarContraseña.UseVisualStyleBackColor = true;
            this.cbMostrarContraseña.CheckedChanged += new System.EventHandler(this.cbMostrarContraseña_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.btEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.cbMostrarContraseña);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.CheckBox cbMostrarContraseña;
    }
}