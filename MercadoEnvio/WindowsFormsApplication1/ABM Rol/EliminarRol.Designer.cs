namespace WindowsFormsApplication1.ABM_Rol
{
    partial class PantallaEliminarRol
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Boton_Eliminar_Rol = new System.Windows.Forms.Button();
            this.Boton_Cancelar_Eliminar_Rol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Texto_Rol = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Boton_Eliminar_Rol
            // 
            this.Boton_Eliminar_Rol.Location = new System.Drawing.Point(27, 89);
            this.Boton_Eliminar_Rol.Name = "Boton_Eliminar_Rol";
            this.Boton_Eliminar_Rol.Size = new System.Drawing.Size(75, 23);
            this.Boton_Eliminar_Rol.TabIndex = 1;
            this.Boton_Eliminar_Rol.Text = "Eliminar";
            this.Boton_Eliminar_Rol.UseVisualStyleBackColor = true;
            // 
            // Boton_Cancelar_Eliminar_Rol
            // 
            this.Boton_Cancelar_Eliminar_Rol.Location = new System.Drawing.Point(147, 89);
            this.Boton_Cancelar_Eliminar_Rol.Name = "Boton_Cancelar_Eliminar_Rol";
            this.Boton_Cancelar_Eliminar_Rol.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar_Eliminar_Rol.TabIndex = 2;
            this.Boton_Cancelar_Eliminar_Rol.Text = "Cancelar";
            this.Boton_Cancelar_Eliminar_Rol.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Texto_Rol);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Boton_Cancelar_Eliminar_Rol);
            this.groupBox1.Controls.Add(this.Boton_Eliminar_Rol);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Texto_Rol
            // 
            this.Texto_Rol.AutoSize = true;
            this.Texto_Rol.Location = new System.Drawing.Point(27, 37);
            this.Texto_Rol.Name = "Texto_Rol";
            this.Texto_Rol.Size = new System.Drawing.Size(26, 13);
            this.Texto_Rol.TabIndex = 3;
            this.Texto_Rol.Text = "Rol:";
            // 
            // PantallaEliminarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaEliminarRol";
            this.Text = "Eliminar Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Boton_Eliminar_Rol;
        private System.Windows.Forms.Button Boton_Cancelar_Eliminar_Rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Texto_Rol;
    }
}