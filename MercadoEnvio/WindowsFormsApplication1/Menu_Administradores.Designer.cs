namespace WindowsFormsApplication1
{
    partial class Menu_Administradores
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
            this.botonVisibilidad = new System.Windows.Forms.Button();
            this.botonUser = new System.Windows.Forms.Button();
            this.botonRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonVisibilidad
            // 
            this.botonVisibilidad.Location = new System.Drawing.Point(250, 89);
            this.botonVisibilidad.Name = "botonVisibilidad";
            this.botonVisibilidad.Size = new System.Drawing.Size(122, 27);
            this.botonVisibilidad.TabIndex = 5;
            this.botonVisibilidad.Text = "ABM de Visibilidad";
            this.botonVisibilidad.UseVisualStyleBackColor = true;
            this.botonVisibilidad.Click += new System.EventHandler(this.botonVisibilidad_Click);
            // 
            // botonUser
            // 
            this.botonUser.Location = new System.Drawing.Point(250, 56);
            this.botonUser.Name = "botonUser";
            this.botonUser.Size = new System.Drawing.Size(122, 27);
            this.botonUser.TabIndex = 4;
            this.botonUser.Text = "ABM de Usuario";
            this.botonUser.UseVisualStyleBackColor = true;
            this.botonUser.Click += new System.EventHandler(this.botonUser_Click);
            // 
            // botonRol
            // 
            this.botonRol.Location = new System.Drawing.Point(250, 23);
            this.botonRol.Name = "botonRol";
            this.botonRol.Size = new System.Drawing.Size(122, 27);
            this.botonRol.TabIndex = 3;
            this.botonRol.Text = "ABM de Rol";
            this.botonRol.UseVisualStyleBackColor = true;
            this.botonRol.Click += new System.EventHandler(this.botonRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido administrador ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(250, 122);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(122, 27);
            this.botonSalir.TabIndex = 10;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Menu_Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 172);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonVisibilidad);
            this.Controls.Add(this.botonUser);
            this.Controls.Add(this.botonRol);
            this.Name = "Menu_Administradores";
            this.Text = "Menu de administradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVisibilidad;
        private System.Windows.Forms.Button botonUser;
        private System.Windows.Forms.Button botonRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSalir;
    }
}