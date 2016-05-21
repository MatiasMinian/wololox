namespace WindowsFormsApplication1.ABM_Rol
{
    partial class Pantalla_ABM_Rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_ABM_Rol));
            this.Boton_Crear_Rol = new System.Windows.Forms.Button();
            this.Boton_Mod_Rol = new System.Windows.Forms.Button();
            this.Boton_Eliminar_Rol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton_Crear_Rol
            // 
            resources.ApplyResources(this.Boton_Crear_Rol, "Boton_Crear_Rol");
            this.Boton_Crear_Rol.Name = "Boton_Crear_Rol";
            this.Boton_Crear_Rol.UseVisualStyleBackColor = true;
            this.Boton_Crear_Rol.Click += new System.EventHandler(this.Boton_Crear_Rol_Click);
            // 
            // Boton_Mod_Rol
            // 
            resources.ApplyResources(this.Boton_Mod_Rol, "Boton_Mod_Rol");
            this.Boton_Mod_Rol.Name = "Boton_Mod_Rol";
            this.Boton_Mod_Rol.UseVisualStyleBackColor = true;
            this.Boton_Mod_Rol.Click += new System.EventHandler(this.Boton_Mod_Rol_Click);
            // 
            // Boton_Eliminar_Rol
            // 
            resources.ApplyResources(this.Boton_Eliminar_Rol, "Boton_Eliminar_Rol");
            this.Boton_Eliminar_Rol.Name = "Boton_Eliminar_Rol";
            this.Boton_Eliminar_Rol.UseVisualStyleBackColor = true;
            this.Boton_Eliminar_Rol.Click += new System.EventHandler(this.Boton_Eliminar_Rol_Click);
            // 
            // Pantalla_ABM_Rol
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Boton_Eliminar_Rol);
            this.Controls.Add(this.Boton_Mod_Rol);
            this.Controls.Add(this.Boton_Crear_Rol);
            this.Name = "Pantalla_ABM_Rol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_Crear_Rol;
        private System.Windows.Forms.Button Boton_Mod_Rol;
        private System.Windows.Forms.Button Boton_Eliminar_Rol;
    }
}