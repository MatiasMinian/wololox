namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class Pantalla_Historial_Principal
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de compras y subastas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompra,
            this.ColumnaDescripcion,
            this.ColumnaCantidad,
            this.ColumnPrecio,
            this.ColumnaTipoPublicacion,
            this.ColumnaFecha,
            this.ColumnaEstrellas,
            this.ColumnaVendedor});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 242);
            this.dataGridView2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnCompra
            // 
            this.ColumnCompra.HeaderText = "Codigo";
            this.ColumnCompra.Name = "ColumnCompra";
            this.ColumnCompra.Width = 95;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.HeaderText = "Descripcion";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.Width = 50;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio_Unidad";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnaTipoPublicacion
            // 
            this.ColumnaTipoPublicacion.HeaderText = "Tipo";
            this.ColumnaTipoPublicacion.Name = "ColumnaTipoPublicacion";
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha";
            this.ColumnaFecha.Name = "ColumnaFecha";
            this.ColumnaFecha.Width = 70;
            // 
            // ColumnaEstrellas
            // 
            this.ColumnaEstrellas.HeaderText = "Estrellas";
            this.ColumnaEstrellas.Name = "ColumnaEstrellas";
            this.ColumnaEstrellas.Width = 50;
            // 
            // ColumnaVendedor
            // 
            this.ColumnaVendedor.FillWeight = 105F;
            this.ColumnaVendedor.HeaderText = "Vendedor";
            this.ColumnaVendedor.Name = "ColumnaVendedor";
            this.ColumnaVendedor.Width = 151;
            // 
            // Pantalla_Historial_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pantalla_Historial_Principal";
            this.Text = "Historial de compras";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVendedor;
    }
}