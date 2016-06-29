namespace WindowsFormsApplication1
{
    partial class Menu_Cliente
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
            this.botonPublic = new System.Windows.Forms.Button();
            this.botonCompra = new System.Windows.Forms.Button();
            this.botonHistorial = new System.Windows.Forms.Button();
            this.botonCalificar = new System.Windows.Forms.Button();
            this.botonEstadisticas = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonPublic
            // 
            this.botonPublic.Location = new System.Drawing.Point(241, 22);
            this.botonPublic.Name = "botonPublic";
            this.botonPublic.Size = new System.Drawing.Size(122, 23);
            this.botonPublic.TabIndex = 3;
            this.botonPublic.Text = "Generar publicación";
            this.botonPublic.UseVisualStyleBackColor = true;
            this.botonPublic.Click += new System.EventHandler(this.botonPublic_Click);
            // 
            // botonCompra
            // 
            this.botonCompra.Location = new System.Drawing.Point(241, 51);
            this.botonCompra.Name = "botonCompra";
            this.botonCompra.Size = new System.Drawing.Size(122, 23);
            this.botonCompra.TabIndex = 4;
            this.botonCompra.Text = "Comprar/Ofertar";
            this.botonCompra.UseVisualStyleBackColor = true;
            this.botonCompra.Click += new System.EventHandler(this.botonCompra_Click);
            // 
            // botonHistorial
            // 
            this.botonHistorial.Location = new System.Drawing.Point(241, 80);
            this.botonHistorial.Name = "botonHistorial";
            this.botonHistorial.Size = new System.Drawing.Size(122, 23);
            this.botonHistorial.TabIndex = 5;
            this.botonHistorial.Text = "Ver Historial";
            this.botonHistorial.UseVisualStyleBackColor = true;
            this.botonHistorial.Click += new System.EventHandler(this.botonHistorial_Click);
            // 
            // botonCalificar
            // 
            this.botonCalificar.Location = new System.Drawing.Point(241, 109);
            this.botonCalificar.Name = "botonCalificar";
            this.botonCalificar.Size = new System.Drawing.Size(122, 23);
            this.botonCalificar.TabIndex = 6;
            this.botonCalificar.Text = "Calificar Vendedor";
            this.botonCalificar.UseVisualStyleBackColor = true;
            this.botonCalificar.Click += new System.EventHandler(this.botonCalificar_Click);
            // 
            // botonEstadisticas
            // 
            this.botonEstadisticas.Location = new System.Drawing.Point(241, 138);
            this.botonEstadisticas.Name = "botonEstadisticas";
            this.botonEstadisticas.Size = new System.Drawing.Size(122, 23);
            this.botonEstadisticas.TabIndex = 8;
            this.botonEstadisticas.Text = "Ver estadísticas";
            this.botonEstadisticas.UseVisualStyleBackColor = true;
            this.botonEstadisticas.Click += new System.EventHandler(this.botonEstadisticas_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(241, 196);
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
            this.labelBienvenida.Size = new System.Drawing.Size(94, 13);
            this.labelBienvenida.TabIndex = 10;
            this.labelBienvenida.Text = "Bienvenido cliente";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(113, 22);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(35, 13);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modificaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonEstadisticas);
            this.Controls.Add(this.botonCalificar);
            this.Controls.Add(this.botonHistorial);
            this.Controls.Add(this.botonCompra);
            this.Controls.Add(this.botonPublic);
            this.Name = "Menu_Cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonPublic;
        private System.Windows.Forms.Button botonCompra;
        private System.Windows.Forms.Button botonHistorial;
        private System.Windows.Forms.Button botonCalificar;
        private System.Windows.Forms.Button botonEstadisticas;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button button1;
    }
}