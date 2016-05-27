namespace WindowsFormsApplication1
{
    partial class MenuForm
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
            this.botonRol = new System.Windows.Forms.Button();
            this.botonUser = new System.Windows.Forms.Button();
            this.botonVisibilidad = new System.Windows.Forms.Button();
            this.botonPublic = new System.Windows.Forms.Button();
            this.botonCompra = new System.Windows.Forms.Button();
            this.botonHistorial = new System.Windows.Forms.Button();
            this.botonCalificar = new System.Windows.Forms.Button();
            this.botonFacturas = new System.Windows.Forms.Button();
            this.botonEstadisticas = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonRol
            // 
            this.botonRol.Location = new System.Drawing.Point(241, 12);
            this.botonRol.Name = "botonRol";
            this.botonRol.Size = new System.Drawing.Size(122, 23);
            this.botonRol.TabIndex = 0;
            this.botonRol.Text = "ABM de Rol";
            this.botonRol.UseVisualStyleBackColor = true;
            this.botonRol.Click += new System.EventHandler(this.botonRol_Click);
            // 
            // botonUser
            // 
            this.botonUser.Location = new System.Drawing.Point(241, 41);
            this.botonUser.Name = "botonUser";
            this.botonUser.Size = new System.Drawing.Size(122, 23);
            this.botonUser.TabIndex = 1;
            this.botonUser.Text = "ABM de Usuario";
            this.botonUser.UseVisualStyleBackColor = true;
            this.botonUser.Click += new System.EventHandler(this.botonUser_Click);
            // 
            // botonVisibilidad
            // 
            this.botonVisibilidad.Location = new System.Drawing.Point(241, 70);
            this.botonVisibilidad.Name = "botonVisibilidad";
            this.botonVisibilidad.Size = new System.Drawing.Size(122, 23);
            this.botonVisibilidad.TabIndex = 2;
            this.botonVisibilidad.Text = "ABM de Visibilidad";
            this.botonVisibilidad.UseVisualStyleBackColor = true;
            // 
            // botonPublic
            // 
            this.botonPublic.Location = new System.Drawing.Point(241, 99);
            this.botonPublic.Name = "botonPublic";
            this.botonPublic.Size = new System.Drawing.Size(122, 23);
            this.botonPublic.TabIndex = 3;
            this.botonPublic.Text = "Generar publicación";
            this.botonPublic.UseVisualStyleBackColor = true;
            // 
            // botonCompra
            // 
            this.botonCompra.Location = new System.Drawing.Point(241, 128);
            this.botonCompra.Name = "botonCompra";
            this.botonCompra.Size = new System.Drawing.Size(122, 23);
            this.botonCompra.TabIndex = 4;
            this.botonCompra.Text = "Compar/Ofertar";
            this.botonCompra.UseVisualStyleBackColor = true;
            // 
            // botonHistorial
            // 
            this.botonHistorial.Location = new System.Drawing.Point(241, 157);
            this.botonHistorial.Name = "botonHistorial";
            this.botonHistorial.Size = new System.Drawing.Size(122, 23);
            this.botonHistorial.TabIndex = 5;
            this.botonHistorial.Text = "Ver Historial";
            this.botonHistorial.UseVisualStyleBackColor = true;
            this.botonHistorial.Click += new System.EventHandler(this.botonHistorial_Click);
            // 
            // botonCalificar
            // 
            this.botonCalificar.Location = new System.Drawing.Point(241, 186);
            this.botonCalificar.Name = "botonCalificar";
            this.botonCalificar.Size = new System.Drawing.Size(122, 23);
            this.botonCalificar.TabIndex = 6;
            this.botonCalificar.Text = "Calificar Vendedor";
            this.botonCalificar.UseVisualStyleBackColor = true;
            this.botonCalificar.Click += new System.EventHandler(this.botonCalificar_Click);
            // 
            // botonFacturas
            // 
            this.botonFacturas.Location = new System.Drawing.Point(241, 215);
            this.botonFacturas.Name = "botonFacturas";
            this.botonFacturas.Size = new System.Drawing.Size(122, 23);
            this.botonFacturas.TabIndex = 7;
            this.botonFacturas.Text = "Consultar Facturas";
            this.botonFacturas.UseVisualStyleBackColor = true;
            // 
            // botonEstadisticas
            // 
            this.botonEstadisticas.Location = new System.Drawing.Point(241, 244);
            this.botonEstadisticas.Name = "botonEstadisticas";
            this.botonEstadisticas.Size = new System.Drawing.Size(122, 23);
            this.botonEstadisticas.TabIndex = 8;
            this.botonEstadisticas.Text = "Ver estadísticas";
            this.botonEstadisticas.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(241, 273);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(122, 23);
            this.botonSalir.TabIndex = 9;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Location = new System.Drawing.Point(22, 22);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(97, 13);
            this.labelBienvenida.TabIndex = 10;
            this.labelBienvenida.Text = "Bienvenido usuario";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(116, 22);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(35, 13);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "label1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonEstadisticas);
            this.Controls.Add(this.botonFacturas);
            this.Controls.Add(this.botonCalificar);
            this.Controls.Add(this.botonHistorial);
            this.Controls.Add(this.botonCompra);
            this.Controls.Add(this.botonPublic);
            this.Controls.Add(this.botonVisibilidad);
            this.Controls.Add(this.botonUser);
            this.Controls.Add(this.botonRol);
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRol;
        private System.Windows.Forms.Button botonUser;
        private System.Windows.Forms.Button botonVisibilidad;
        private System.Windows.Forms.Button botonPublic;
        private System.Windows.Forms.Button botonCompra;
        private System.Windows.Forms.Button botonHistorial;
        private System.Windows.Forms.Button botonCalificar;
        private System.Windows.Forms.Button botonFacturas;
        private System.Windows.Forms.Button botonEstadisticas;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelUsuario;
    }
}