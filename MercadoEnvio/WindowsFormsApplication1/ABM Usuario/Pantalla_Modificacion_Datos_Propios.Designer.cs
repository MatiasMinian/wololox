namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class Pantalla_Modificacion_Datos_Propios
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
            this.botonPass = new System.Windows.Forms.Button();
            this.botonModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonPass
            // 
            this.botonPass.Location = new System.Drawing.Point(93, 77);
            this.botonPass.Name = "botonPass";
            this.botonPass.Size = new System.Drawing.Size(109, 30);
            this.botonPass.TabIndex = 10;
            this.botonPass.Text = "Cambiar password";
            this.botonPass.UseVisualStyleBackColor = true;
            this.botonPass.Click += new System.EventHandler(this.botonPass_Click);
            // 
            // botonModif
            // 
            this.botonModif.Location = new System.Drawing.Point(93, 41);
            this.botonModif.Name = "botonModif";
            this.botonModif.Size = new System.Drawing.Size(109, 30);
            this.botonModif.TabIndex = 9;
            this.botonModif.Text = "Modificar datos";
            this.botonModif.UseVisualStyleBackColor = true;
            this.botonModif.Click += new System.EventHandler(this.botonModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione lo que desea hacer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pantalla_Modificacion_Datos_Propios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonPass);
            this.Controls.Add(this.botonModif);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla_Modificacion_Datos_Propios";
            this.ShowIcon = false;
            this.Text = "Modificación datos propios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonPass;
        private System.Windows.Forms.Button botonModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}