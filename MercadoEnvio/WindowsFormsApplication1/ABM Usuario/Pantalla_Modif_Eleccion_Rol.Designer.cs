namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class Pantalla_Modif_Eleccion_Rol
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
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.gD1C2016DataSet = new WindowsFormsApplication1.GD1C2016DataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new WindowsFormsApplication1.GD1C2016DataSetTableAdapters.rolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRol
            // 
            this.comboRol.DataSource = this.rolesBindingSource;
            this.comboRol.DisplayMember = "nombre";
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(110, 22);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(121, 21);
            this.comboRol.TabIndex = 0;
            this.comboRol.ValueMember = "id";
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un rol:";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(84, 49);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 2;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // gD1C2016DataSet
            // 
            this.gD1C2016DataSet.DataSetName = "GD1C2016DataSet";
            this.gD1C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.gD1C2016DataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Pantalla_Modif_Eleccion_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 93);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRol);
            this.Name = "Pantalla_Modif_Eleccion_Rol";
            this.ShowIcon = false;
            this.Text = "Selección de rol";
            this.Load += new System.EventHandler(this.Pantalla_Modif_Eleccion_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAceptar;
        private GD1C2016DataSet gD1C2016DataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private GD1C2016DataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
    }
}