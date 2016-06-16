namespace WindowsFormsApplication1.Calificar
{
    partial class Pantalla_Calificacion_Principal
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de compras pendientes de calificacion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnaDescripcion,
            this.ColumnTipo,
            this.ColumnaValor,
            this.ColumnCantidad,
            this.ColumnaUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 163);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.HeaderText = "Descripcion";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo_Publicacion";
            this.ColumnTipo.Name = "ColumnTipo";
            // 
            // ColumnaValor
            // 
            this.ColumnaValor.HeaderText = "Precio";
            this.ColumnaValor.Name = "ColumnaValor";
            this.ColumnaValor.Width = 50;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Width = 50;
            // 
            // ColumnaUsuario
            // 
            this.ColumnaUsuario.HeaderText = "Vendedor";
            this.ColumnaUsuario.Name = "ColumnaUsuario";
            this.ColumnaUsuario.Width = 109;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Últimas 5 compras calificadas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Compras según cantidad de estrellas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pantalla_Calificacion_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 257);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pantalla_Calificacion_Principal";
            this.Text = "Calificaciones";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}