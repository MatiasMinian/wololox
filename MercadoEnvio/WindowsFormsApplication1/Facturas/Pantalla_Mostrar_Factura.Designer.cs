namespace WindowsFormsApplication1.Facturas
{
    partial class Pantalla_Mostrar_Factura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDpublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroFactura,
            this.IDcompra,
            this.IDpublicacion,
            this.FechaFactura,
            this.TotalFactura});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "Nro_Factura";
            this.NroFactura.Name = "NroFactura";
            // 
            // IDcompra
            // 
            this.IDcompra.HeaderText = "ID_compra";
            this.IDcompra.Name = "IDcompra";
            // 
            // IDpublicacion
            // 
            this.IDpublicacion.HeaderText = "ID_publicacion";
            this.IDpublicacion.Name = "IDpublicacion";
            // 
            // FechaFactura
            // 
            this.FechaFactura.HeaderText = "Fecha_Factura";
            this.FechaFactura.Name = "FechaFactura";
            // 
            // TotalFactura
            // 
            this.TotalFactura.HeaderText = "Total_Factura";
            this.TotalFactura.Name = "TotalFactura";
            // 
            // Pantalla_Mostrar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pantalla_Mostrar_Factura";
            this.Text = "Factura generada";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFactura;
    }
}