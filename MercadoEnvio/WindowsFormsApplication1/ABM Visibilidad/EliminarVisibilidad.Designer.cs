namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class EliminarVisibilidad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelección = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesc,
            this.colCosto,
            this.colTipo,
            this.colProd,
            this.colEnvio,
            this.colSelección});
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 225);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "y:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo entre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Descripción";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Com. por tipo de publicación";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colProd
            // 
            this.colProd.HeaderText = "Com. por producto vendido";
            this.colProd.Name = "colProd";
            this.colProd.ReadOnly = true;
            // 
            // colEnvio
            // 
            this.colEnvio.HeaderText = "Com. por envío";
            this.colEnvio.Name = "colEnvio";
            this.colEnvio.ReadOnly = true;
            // 
            // colSelección
            // 
            this.colSelección.HeaderText = "Eliminar";
            this.colSelección.Name = "colSelección";
            this.colSelección.ReadOnly = true;
            this.colSelección.Text = "Eliminar";
            this.colSelección.ToolTipText = "Eliminar";
            // 
            // EliminarVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 307);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EliminarVisibilidad";
            this.ShowIcon = false;
            this.Text = "Eliminar visibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnvio;
        private System.Windows.Forms.DataGridViewButtonColumn colSelección;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}