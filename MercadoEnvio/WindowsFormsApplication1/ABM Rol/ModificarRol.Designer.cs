namespace WindowsFormsApplication1.ABM_Rol
{
    partial class PantallaModificarRol
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
            this.Grupo_Modificar_Rol = new System.Windows.Forms.GroupBox();
            this.Modificar_Rol_Desplegable_Roles = new System.Windows.Forms.ComboBox();
            this.Modificar_Rol_Texto_Rol = new System.Windows.Forms.Label();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Grupo_Modificar_Rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_Modificar_Rol
            // 
            this.Grupo_Modificar_Rol.Controls.Add(this.Modificar_Rol_Desplegable_Roles);
            this.Grupo_Modificar_Rol.Controls.Add(this.Modificar_Rol_Texto_Rol);
            this.Grupo_Modificar_Rol.Location = new System.Drawing.Point(13, 13);
            this.Grupo_Modificar_Rol.Name = "Grupo_Modificar_Rol";
            this.Grupo_Modificar_Rol.Size = new System.Drawing.Size(215, 92);
            this.Grupo_Modificar_Rol.TabIndex = 0;
            this.Grupo_Modificar_Rol.TabStop = false;
            this.Grupo_Modificar_Rol.Text = "Modificar Rol";
            // 
            // Modificar_Rol_Desplegable_Roles
            // 
            this.Modificar_Rol_Desplegable_Roles.FormattingEnabled = true;
            this.Modificar_Rol_Desplegable_Roles.Location = new System.Drawing.Point(69, 37);
            this.Modificar_Rol_Desplegable_Roles.Name = "Modificar_Rol_Desplegable_Roles";
            this.Modificar_Rol_Desplegable_Roles.Size = new System.Drawing.Size(121, 21);
            this.Modificar_Rol_Desplegable_Roles.TabIndex = 1;
            // 
            // Modificar_Rol_Texto_Rol
            // 
            this.Modificar_Rol_Texto_Rol.AutoSize = true;
            this.Modificar_Rol_Texto_Rol.Location = new System.Drawing.Point(21, 40);
            this.Modificar_Rol_Texto_Rol.Name = "Modificar_Rol_Texto_Rol";
            this.Modificar_Rol_Texto_Rol.Size = new System.Drawing.Size(26, 13);
            this.Modificar_Rol_Texto_Rol.TabIndex = 0;
            this.Modificar_Rol_Texto_Rol.Text = "Rol:";
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(153, 127);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar.TabIndex = 1;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(12, 127);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar.TabIndex = 2;
            this.Boton_Cancelar.Text = "Atras";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // PantallaModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 164);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Grupo_Modificar_Rol);
            this.Name = "PantallaModificarRol";
            this.Text = "Modificar Rol";
            this.Grupo_Modificar_Rol.ResumeLayout(false);
            this.Grupo_Modificar_Rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Modificar_Rol;
        private System.Windows.Forms.Label Modificar_Rol_Texto_Rol;
        private System.Windows.Forms.ComboBox Modificar_Rol_Desplegable_Roles;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}