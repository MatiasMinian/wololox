namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class FormComprayOferta
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
            this.button3 = new System.Windows.Forms.Button();
            this.textRubros = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaPubl = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVisibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPubl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textRubros);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";

            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Seleccionar rubros";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textRubros
            // 
            this.textRubros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRubros.Location = new System.Drawing.Point(168, 49);
            this.textRubros.Name = "textRubros";
            this.textRubros.ReadOnly = true;
            this.textRubros.Size = new System.Drawing.Size(305, 20);
            this.textRubros.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar filtro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione uno o más rubros:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(168, 17);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(305, 20);
            this.textDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese parte de la descripción:";
            // 
            // tablaPubl
            // 
            this.tablaPubl.AllowUserToAddRows = false;
            this.tablaPubl.AllowUserToDeleteRows = false;
            this.tablaPubl.AllowUserToResizeRows = false;
            this.tablaPubl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPubl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigoPublicacion,
            this.ColDesc,
            this.ColPrec,
            this.ColumnStock,
            this.ColumnaTipo,
            this.ColumnaVisibilidad,
            this.ColumnaVendedor});
            this.tablaPubl.Location = new System.Drawing.Point(12, 138);
            this.tablaPubl.MultiSelect = false;
            this.tablaPubl.Name = "tablaPubl";
            this.tablaPubl.ReadOnly = true;
            this.tablaPubl.RowHeadersWidth = 20;
            this.tablaPubl.RowTemplate.ReadOnly = true;
            this.tablaPubl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPubl.Size = new System.Drawing.Size(739, 133);
            this.tablaPubl.TabIndex = 1;
            // 
            // ColumnaCodigoPublicacion
            // 
            this.ColumnaCodigoPublicacion.HeaderText = "Codigo";
            this.ColumnaCodigoPublicacion.Name = "ColumnaCodigoPublicacion";
            this.ColumnaCodigoPublicacion.ReadOnly = true;
            this.ColumnaCodigoPublicacion.Width = 50;
            // 
            // ColDesc
            // 
            this.ColDesc.HeaderText = "Descripción";
            this.ColDesc.Name = "ColDesc";
            this.ColDesc.ReadOnly = true;
            this.ColDesc.Width = 200;
            // 
            // ColPrec
            // 
            this.ColPrec.HeaderText = "Precio";
            this.ColPrec.Name = "ColPrec";
            this.ColPrec.ReadOnly = true;
            // 
            // ColumnStock
            // 
            this.ColumnStock.HeaderText = "Stock";
            this.ColumnStock.Name = "ColumnStock";
            this.ColumnStock.ReadOnly = true;
            this.ColumnStock.Width = 50;
            // 
            // ColumnaTipo
            // 
            this.ColumnaTipo.HeaderText = "Tipo_Publicacion";
            this.ColumnaTipo.Name = "ColumnaTipo";
            this.ColumnaTipo.ReadOnly = true;
            // 
            // ColumnaVisibilidad
            // 
            this.ColumnaVisibilidad.HeaderText = "Visibilidad";
            this.ColumnaVisibilidad.Name = "ColumnaVisibilidad";
            this.ColumnaVisibilidad.ReadOnly = true;
            // 
            // ColumnaVendedor
            // 
            this.ColumnaVendedor.HeaderText = "Vendedor";
            this.ColumnaVendedor.Name = "ColumnaVendedor";
            this.ColumnaVendedor.ReadOnly = true;
            this.ColumnaVendedor.Width = 116;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(239, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Página anterior";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(430, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Página siguiente";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Comprar/Ofertar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(659, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "mPages";
            // 
            // FormComprayOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tablaPubl);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormComprayOferta";
            this.ShowIcon = false;
            this.Text = "Comprar producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPubl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textRubros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tablaPubl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVisibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}