namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class FormSelecRubro
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
            this.button7 = new System.Windows.Forms.Button();
            this.tablaRubros = new System.Windows.Forms.DataGridView();
            this.ColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(520, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tablaRubros
            // 
            this.tablaRubros.AllowUserToAddRows = false;
            this.tablaRubros.AllowUserToDeleteRows = false;
            this.tablaRubros.AllowUserToResizeRows = false;
            this.tablaRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRubros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDesc});
            this.tablaRubros.Location = new System.Drawing.Point(12, 12);
            this.tablaRubros.Name = "tablaRubros";
            this.tablaRubros.ReadOnly = true;
            this.tablaRubros.RowHeadersWidth = 20;
            this.tablaRubros.RowTemplate.ReadOnly = true;
            this.tablaRubros.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRubros.Size = new System.Drawing.Size(600, 289);
            this.tablaRubros.TabIndex = 7;
            // 
            // ColDesc
            // 
            this.ColDesc.HeaderText = "Rubro";
            this.ColDesc.Name = "ColDesc";
            this.ColDesc.ReadOnly = true;
            this.ColDesc.Width = 577;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Seleccionar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormSelecRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 344);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tablaRubros);
            this.Name = "FormSelecRubro";
            this.ShowIcon = false;
            this.Text = "Seleccionar rubro";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView tablaRubros;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesc;
    }
}