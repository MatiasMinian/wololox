namespace WindowsFormsApplication1.ABM_Rol
{
    partial class PantallaCrearRol
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
            this.Grupo_Crear_Rol = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Crear_Rol_Texto_Rol = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Boton_Crear = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Grupo_Crear_Rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_Crear_Rol
            // 
            this.Grupo_Crear_Rol.Controls.Add(this.listBox1);
            this.Grupo_Crear_Rol.Controls.Add(this.label1);
            this.Grupo_Crear_Rol.Controls.Add(this.Crear_Rol_Texto_Rol);
            this.Grupo_Crear_Rol.Controls.Add(this.textBox1);
            this.Grupo_Crear_Rol.Location = new System.Drawing.Point(12, 12);
            this.Grupo_Crear_Rol.Name = "Grupo_Crear_Rol";
            this.Grupo_Crear_Rol.Size = new System.Drawing.Size(344, 196);
            this.Grupo_Crear_Rol.TabIndex = 0;
            this.Grupo_Crear_Rol.TabStop = false;
            this.Grupo_Crear_Rol.Text = "Crear Rol";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(156, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 82);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de funcionalidades:";
            // 
            // Crear_Rol_Texto_Rol
            // 
            this.Crear_Rol_Texto_Rol.AutoSize = true;
            this.Crear_Rol_Texto_Rol.Location = new System.Drawing.Point(92, 30);
            this.Crear_Rol_Texto_Rol.Name = "Crear_Rol_Texto_Rol";
            this.Crear_Rol_Texto_Rol.Size = new System.Drawing.Size(61, 13);
            this.Crear_Rol_Texto_Rol.TabIndex = 1;
            this.Crear_Rol_Texto_Rol.Text = "Nombre rol:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Boton_Crear
            // 
            this.Boton_Crear.Location = new System.Drawing.Point(281, 214);
            this.Boton_Crear.Name = "Boton_Crear";
            this.Boton_Crear.Size = new System.Drawing.Size(75, 23);
            this.Boton_Crear.TabIndex = 1;
            this.Boton_Crear.Text = "Crear";
            this.Boton_Crear.UseVisualStyleBackColor = true;
            this.Boton_Crear.Click += new System.EventHandler(this.Boton_Crear_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(12, 214);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar.TabIndex = 2;
            this.Boton_Cancelar.Text = "Atras";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // PantallaCrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 244);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Crear);
            this.Controls.Add(this.Grupo_Crear_Rol);
            this.Name = "PantallaCrearRol";
            this.Text = "Creación de Rol";
            this.Grupo_Crear_Rol.ResumeLayout(false);
            this.Grupo_Crear_Rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Crear_Rol;
        private System.Windows.Forms.Label Crear_Rol_Texto_Rol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Boton_Crear;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}