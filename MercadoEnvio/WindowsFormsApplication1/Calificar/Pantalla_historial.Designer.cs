namespace WindowsFormsApplication1.Calificar
{
    partial class Pantalla_historial
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "estrellas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 175);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de compras calificadas con:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCompra});
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 46);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnaCompra
            // 
            this.ColumnaCompra.HeaderText = "Compra";
            this.ColumnaCompra.Name = "ColumnaCompra";
            this.ColumnaCompra.Width = 200;
            // 
            // Pantalla_historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pantalla_historial";
            this.Text = "Pantalla_historial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCompra;
        private System.Windows.Forms.Button button2;
    }
}