﻿namespace WindowsFormsApplication1
{
    partial class Menu_Empresa
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
            this.label2 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonPublic = new System.Windows.Forms.Button();
            this.botonFacturas = new System.Windows.Forms.Button();
            this.botonEstadisticas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(238, 138);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(122, 23);
            this.botonSalir.TabIndex = 12;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonPublic
            // 
            this.botonPublic.Location = new System.Drawing.Point(238, 22);
            this.botonPublic.Name = "botonPublic";
            this.botonPublic.Size = new System.Drawing.Size(122, 23);
            this.botonPublic.TabIndex = 11;
            this.botonPublic.Text = "Generar publicación";
            this.botonPublic.UseVisualStyleBackColor = true;
            this.botonPublic.Click += new System.EventHandler(this.botonPublic_Click);
            // 
            // botonFacturas
            // 
            this.botonFacturas.Location = new System.Drawing.Point(238, 51);
            this.botonFacturas.Name = "botonFacturas";
            this.botonFacturas.Size = new System.Drawing.Size(122, 23);
            this.botonFacturas.TabIndex = 13;
            this.botonFacturas.Text = "Consultar Facturas";
            this.botonFacturas.UseVisualStyleBackColor = true;
            this.botonFacturas.Click += new System.EventHandler(this.botonFacturas_Click);
            // 
            // botonEstadisticas
            // 
            this.botonEstadisticas.Location = new System.Drawing.Point(238, 80);
            this.botonEstadisticas.Name = "botonEstadisticas";
            this.botonEstadisticas.Size = new System.Drawing.Size(122, 23);
            this.botonEstadisticas.TabIndex = 14;
            this.botonEstadisticas.Text = "Ver estadísticas";
            this.botonEstadisticas.UseVisualStyleBackColor = true;
            this.botonEstadisticas.Click += new System.EventHandler(this.botonEstadisticas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Modificaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "empresa";
            // 
            // Menu_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonEstadisticas);
            this.Controls.Add(this.botonFacturas);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonPublic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Empresa";
            this.ShowIcon = false;
            this.Text = "Menú de empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonPublic;
        private System.Windows.Forms.Button botonFacturas;
        private System.Windows.Forms.Button botonEstadisticas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}