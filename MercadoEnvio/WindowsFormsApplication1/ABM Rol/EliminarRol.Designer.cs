﻿namespace WindowsFormsApplication1.ABM_Rol
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
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.Boton_Eliminar_Rol = new System.Windows.Forms.Button();
            this.Boton_Cancelar_Eliminar_Rol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Texto_Rol = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboRoles
            // 
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(65, 41);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(121, 21);
            this.comboRoles.TabIndex = 0;
            // 
            // Boton_Eliminar_Rol
            // 
            this.Boton_Eliminar_Rol.Location = new System.Drawing.Point(154, 131);
            this.Boton_Eliminar_Rol.Name = "Boton_Eliminar_Rol";
            this.Boton_Eliminar_Rol.Size = new System.Drawing.Size(75, 23);
            this.Boton_Eliminar_Rol.TabIndex = 1;
            this.Boton_Eliminar_Rol.Text = "Inhabilitar";
            this.Boton_Eliminar_Rol.UseVisualStyleBackColor = true;
            this.Boton_Eliminar_Rol.Click += new System.EventHandler(this.Boton_Eliminar_Rol_Click);
            // 
            // Boton_Cancelar_Eliminar_Rol
            // 
            this.Boton_Cancelar_Eliminar_Rol.Location = new System.Drawing.Point(7, 131);
            this.Boton_Cancelar_Eliminar_Rol.Name = "Boton_Cancelar_Eliminar_Rol";
            this.Boton_Cancelar_Eliminar_Rol.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar_Eliminar_Rol.TabIndex = 2;
            this.Boton_Cancelar_Eliminar_Rol.Text = "Atras";
            this.Boton_Cancelar_Eliminar_Rol.UseVisualStyleBackColor = true;
            this.Boton_Cancelar_Eliminar_Rol.Click += new System.EventHandler(this.Boton_Cancelar_Eliminar_Rol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Texto_Rol);
            this.groupBox1.Controls.Add(this.comboRoles);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección roles";
            // 
            // Texto_Rol
            // 
            this.Texto_Rol.AutoSize = true;
            this.Texto_Rol.Location = new System.Drawing.Point(24, 49);
            this.Texto_Rol.Name = "Texto_Rol";
            this.Texto_Rol.Size = new System.Drawing.Size(26, 13);
            this.Texto_Rol.TabIndex = 3;
            this.Texto_Rol.Text = "Rol:";
            // 
            // PantallaEliminarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 172);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Boton_Eliminar_Rol);
            this.Controls.Add(this.Boton_Cancelar_Eliminar_Rol);
            this.Name = "PantallaEliminarRol";
            this.ShowIcon = false;
            this.Text = "Eliminar rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.Button Boton_Eliminar_Rol;
        private System.Windows.Forms.Button Boton_Cancelar_Eliminar_Rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Texto_Rol;
    }
}