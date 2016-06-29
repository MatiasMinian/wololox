namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class Pantalla_Busqueda_Empresa_A_Eliminar
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataEmpresas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gD1C2016DataSet = new WindowsFormsApplication1.GD1C2016DataSet();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new WindowsFormsApplication1.GD1C2016DataSetTableAdapters.empresasTableAdapter();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRepMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textRepMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textCUIT = new System.Windows.Forms.TextBox();
            this.textRazSoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codrubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reputacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRubro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textRepMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textRepMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Controls.Add(this.textCUIT);
            this.groupBox1.Controls.Add(this.textRazSoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // dataEmpresas
            // 
            this.dataEmpresas.AutoGenerateColumns = false;
            this.dataEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.razonsocialDataGridViewTextBoxColumn,
            this.codrubroDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.nombrecontactoDataGridViewTextBoxColumn,
            this.reputacionDataGridViewTextBoxColumn,
            this.colSeleccion});
            this.dataEmpresas.DataSource = this.empresasBindingSource;
            this.dataEmpresas.Location = new System.Drawing.Point(12, 135);
            this.dataEmpresas.Name = "dataEmpresas";
            this.dataEmpresas.Size = new System.Drawing.Size(503, 150);
            this.dataEmpresas.TabIndex = 2;
            this.dataEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmpresas_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gD1C2016DataSet
            // 
            this.gD1C2016DataSet.DataSetName = "GD1C2016DataSet";
            this.gD1C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "empresas";
            this.empresasBindingSource.DataSource = this.gD1C2016DataSet;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // textRubro
            // 
            this.textRubro.Location = new System.Drawing.Point(231, 23);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(80, 20);
            this.textRubro.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rubro:";
            // 
            // textRepMax
            // 
            this.textRepMax.Location = new System.Drawing.Point(428, 60);
            this.textRepMax.Name = "textRepMax";
            this.textRepMax.Size = new System.Drawing.Size(69, 20);
            this.textRepMax.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "y menor a:";
            // 
            // textRepMin
            // 
            this.textRepMin.Location = new System.Drawing.Point(428, 26);
            this.textRepMin.Name = "textRepMin";
            this.textRepMin.Size = new System.Drawing.Size(69, 20);
            this.textRepMin.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Reputación mayor a:";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(231, 60);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(80, 20);
            this.textNom.TabIndex = 20;
            // 
            // textCUIT
            // 
            this.textCUIT.Location = new System.Drawing.Point(104, 64);
            this.textCUIT.Name = "textCUIT";
            this.textCUIT.Size = new System.Drawing.Size(76, 20);
            this.textCUIT.TabIndex = 19;
            // 
            // textRazSoc
            // 
            this.textRazSoc.Location = new System.Drawing.Point(104, 23);
            this.textRazSoc.Name = "textRazSoc";
            this.textRazSoc.Size = new System.Drawing.Size(76, 20);
            this.textRazSoc.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Razón social:";
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Width = 40;
            // 
            // razonsocialDataGridViewTextBoxColumn
            // 
            this.razonsocialDataGridViewTextBoxColumn.DataPropertyName = "razon_social";
            this.razonsocialDataGridViewTextBoxColumn.HeaderText = "Razón social";
            this.razonsocialDataGridViewTextBoxColumn.Name = "razonsocialDataGridViewTextBoxColumn";
            this.razonsocialDataGridViewTextBoxColumn.Width = 80;
            // 
            // codrubroDataGridViewTextBoxColumn
            // 
            this.codrubroDataGridViewTextBoxColumn.DataPropertyName = "cod_rubro";
            this.codrubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.codrubroDataGridViewTextBoxColumn.Name = "codrubroDataGridViewTextBoxColumn";
            this.codrubroDataGridViewTextBoxColumn.Width = 60;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            this.cuitDataGridViewTextBoxColumn.Width = 60;
            // 
            // nombrecontactoDataGridViewTextBoxColumn
            // 
            this.nombrecontactoDataGridViewTextBoxColumn.DataPropertyName = "nombre_contacto";
            this.nombrecontactoDataGridViewTextBoxColumn.HeaderText = "Nombre contacto";
            this.nombrecontactoDataGridViewTextBoxColumn.Name = "nombrecontactoDataGridViewTextBoxColumn";
            this.nombrecontactoDataGridViewTextBoxColumn.Width = 80;
            // 
            // reputacionDataGridViewTextBoxColumn
            // 
            this.reputacionDataGridViewTextBoxColumn.DataPropertyName = "reputacion";
            this.reputacionDataGridViewTextBoxColumn.HeaderText = "Reputación";
            this.reputacionDataGridViewTextBoxColumn.Name = "reputacionDataGridViewTextBoxColumn";
            this.reputacionDataGridViewTextBoxColumn.Width = 70;
            // 
            // colSeleccion
            // 
            this.colSeleccion.HeaderText = "Seleccionar";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.Width = 70;
            // 
            // Pantalla_Busqueda_Empresa_A_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataEmpresas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pantalla_Busqueda_Empresa_A_Eliminar";
            this.ShowIcon = false;
            this.Text = "Selección empresa a eliminar";
            this.Load += new System.EventHandler(this.Pantalla_Busqueda_Empresa_A_Eliminar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataEmpresas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private GD1C2016DataSet gD1C2016DataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private GD1C2016DataSetTableAdapters.empresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRepMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRepMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textCUIT;
        private System.Windows.Forms.TextBox textRazSoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codrubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reputacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colSeleccion;
    }
}