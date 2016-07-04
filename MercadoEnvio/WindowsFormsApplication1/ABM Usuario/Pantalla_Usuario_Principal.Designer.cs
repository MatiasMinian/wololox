namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class Pantalla_Usuario_Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.botonCreacion = new System.Windows.Forms.Button();
            this.botonModif = new System.Windows.Forms.Button();
            this.botonElim = new System.Windows.Forms.Button();
            this.botonHabilitar = new System.Windows.Forms.Button();
            this.botonPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione lo que desea hacer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Atras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // botonCreacion
            // 
            this.botonCreacion.Location = new System.Drawing.Point(121, 55);
            this.botonCreacion.Name = "botonCreacion";
            this.botonCreacion.Size = new System.Drawing.Size(109, 30);
            this.botonCreacion.TabIndex = 2;
            this.botonCreacion.Text = "Crear usuario";
            this.botonCreacion.UseVisualStyleBackColor = true;
            this.botonCreacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonModif
            // 
            this.botonModif.Location = new System.Drawing.Point(121, 109);
            this.botonModif.Name = "botonModif";
            this.botonModif.Size = new System.Drawing.Size(109, 30);
            this.botonModif.TabIndex = 4;
            this.botonModif.Text = "Modificar datos";
            this.botonModif.UseVisualStyleBackColor = true;
            this.botonModif.Click += new System.EventHandler(this.botonModif_Click);
            // 
            // botonElim
            // 
            this.botonElim.Location = new System.Drawing.Point(121, 164);
            this.botonElim.Name = "botonElim";
            this.botonElim.Size = new System.Drawing.Size(109, 30);
            this.botonElim.TabIndex = 5;
            this.botonElim.Text = "Eliminar usuario";
            this.botonElim.UseVisualStyleBackColor = true;
            this.botonElim.Click += new System.EventHandler(this.botonElim_Click);
            // 
            // botonHabilitar
            // 
            this.botonHabilitar.Location = new System.Drawing.Point(121, 217);
            this.botonHabilitar.Name = "botonHabilitar";
            this.botonHabilitar.Size = new System.Drawing.Size(109, 30);
            this.botonHabilitar.TabIndex = 6;
            this.botonHabilitar.Text = "Habilitar usuario";
            this.botonHabilitar.UseVisualStyleBackColor = true;
            this.botonHabilitar.Click += new System.EventHandler(this.botonHabilitar_Click);
            // 
            // botonPass
            // 
            this.botonPass.Location = new System.Drawing.Point(121, 271);
            this.botonPass.Name = "botonPass";
            this.botonPass.Size = new System.Drawing.Size(109, 30);
            this.botonPass.TabIndex = 7;
            this.botonPass.Text = "Cambiar password";
            this.botonPass.UseVisualStyleBackColor = true;
            this.botonPass.Click += new System.EventHandler(this.botonPass_Click);
            // 
            // Pantalla_Usuario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 362);
            this.Controls.Add(this.botonPass);
            this.Controls.Add(this.botonHabilitar);
            this.Controls.Add(this.botonElim);
            this.Controls.Add(this.botonModif);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.botonCreacion);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla_Usuario_Principal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.Text = "Menu usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button botonCreacion;
        private System.Windows.Forms.Button botonModif;
        private System.Windows.Forms.Button botonElim;
        private System.Windows.Forms.Button botonHabilitar;
        private System.Windows.Forms.Button botonPass;
    }
}