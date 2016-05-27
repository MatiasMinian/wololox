namespace WindowsFormsApplication1
{
    partial class FormularioLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textoUser = new System.Windows.Forms.TextBox();
            this.textoPass = new System.Windows.Forms.TextBox();
            this.botonIngreso = new System.Windows.Forms.Button();
            this.botonLimpieza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(45, 50);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(45, 79);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(64, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Contraseña:";
            // 
            // textoUser
            // 
            this.textoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoUser.Location = new System.Drawing.Point(133, 50);
            this.textoUser.Name = "textoUser";
            this.textoUser.Size = new System.Drawing.Size(116, 20);
            this.textoUser.TabIndex = 3;

            // 
            // textoPass
            // 
            this.textoPass.Location = new System.Drawing.Point(133, 76);
            this.textoPass.Name = "textoPass";
            this.textoPass.Size = new System.Drawing.Size(116, 20);
            this.textoPass.TabIndex = 4;
            this.textoPass.UseSystemPasswordChar = true;
            // 
            // botonIngreso
            // 
            this.botonIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngreso.Location = new System.Drawing.Point(49, 135);
            this.botonIngreso.Name = "botonIngreso";
            this.botonIngreso.Size = new System.Drawing.Size(87, 23);
            this.botonIngreso.TabIndex = 5;
            this.botonIngreso.Text = "Ingresar";
            this.botonIngreso.UseVisualStyleBackColor = true;
            this.botonIngreso.Click += new System.EventHandler(this.botonIngreso_Click);
            // 
            // botonLimpieza
            // 
            this.botonLimpieza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpieza.Location = new System.Drawing.Point(162, 135);
            this.botonLimpieza.Name = "botonLimpieza";
            this.botonLimpieza.Size = new System.Drawing.Size(87, 23);
            this.botonLimpieza.TabIndex = 6;
            this.botonLimpieza.Text = "Limpiar";
            this.botonLimpieza.UseVisualStyleBackColor = true;
            this.botonLimpieza.Click += new System.EventHandler(this.botonLimpieza_Click);
            // 
            // FormularioLogin
            // 
            this.AcceptButton = this.botonIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonLimpieza;
            this.ClientSize = new System.Drawing.Size(316, 214);
            this.Controls.Add(this.botonLimpieza);
            this.Controls.Add(this.botonIngreso);
            this.Controls.Add(this.textoPass);
            this.Controls.Add(this.textoUser);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Name = "FormularioLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textoUser;
        private System.Windows.Forms.TextBox textoPass;
        private System.Windows.Forms.Button botonIngreso;
        private System.Windows.Forms.Button botonLimpieza;
    }
}

