namespace WindowsFormsApplication1.Calificar
{
    partial class Pantalla_Compras_Segun_Estrellas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompra,
            this.ColumnaCantidad,
            this.ColumnaFecha,
            this.ColumnaDescripcion,
            this.ColumnaEstrellas,
            this.ColumnaVendedor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnCompra
            // 
            this.ColumnCompra.HeaderText = "Codigo";
            this.ColumnCompra.Name = "ColumnCompra";
            this.ColumnCompra.Width = 50;
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.Width = 50;
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha";
            this.ColumnaFecha.Name = "ColumnaFecha";
            this.ColumnaFecha.Width = 130;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.HeaderText = "Descripcion";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            // 
            // ColumnaEstrellas
            // 
            this.ColumnaEstrellas.HeaderText = "Estrellas";
            this.ColumnaEstrellas.Name = "ColumnaEstrellas";
            this.ColumnaEstrellas.Width = 50;
            // 
            // ColumnaVendedor
            // 
            this.ColumnaVendedor.HeaderText = "Vendedor";
            this.ColumnaVendedor.Name = "ColumnaVendedor";
            this.ColumnaVendedor.Width = 120;
            // 
            // Pantalla_Compras_Segun_Estrellas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pantalla_Compras_Segun_Estrellas";
            this.Text = "Pantalla_Compras_Segun_Estrellas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVendedor;
    }
}