namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class Pantalla_Datos_Empresa
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textNomCon = new System.Windows.Forms.TextBox();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.textDepto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textCodPos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDom = new System.Windows.Forms.TextBox();
            this.textCuit = new System.Windows.Forms.TextBox();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textNumDom = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.gD1C2016DataSet = new WindowsFormsApplication1.GD1C2016DataSet();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubrosTableAdapter = new WindowsFormsApplication1.GD1C2016DataSetTableAdapters.rubrosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboRubro);
            this.groupBox1.Controls.Add(this.textPass);
            this.groupBox1.Controls.Add(this.textUser);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textNomCon);
            this.groupBox1.Controls.Add(this.textCiudad);
            this.groupBox1.Controls.Add(this.textDepto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textCodPos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textDom);
            this.groupBox1.Controls.Add(this.textCuit);
            this.groupBox1.Controls.Add(this.textPiso);
            this.groupBox1.Controls.Add(this.textLocal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.textNumDom);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos adicionales empresa";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(234, 33);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(74, 20);
            this.textPass.TabIndex = 31;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(80, 33);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(74, 20);
            this.textUser.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Contraseña:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Username:";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(80, 118);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(74, 20);
            this.textTel.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(507, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Rubro:";
            // 
            // textNomCon
            // 
            this.textNomCon.Location = new System.Drawing.Point(427, 163);
            this.textNomCon.Name = "textNomCon";
            this.textNomCon.Size = new System.Drawing.Size(74, 20);
            this.textNomCon.TabIndex = 24;
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(549, 118);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(98, 20);
            this.textCiudad.TabIndex = 23;
            // 
            // textDepto
            // 
            this.textDepto.Location = new System.Drawing.Point(549, 75);
            this.textDepto.Name = "textDepto";
            this.textDepto.Size = new System.Drawing.Size(98, 20);
            this.textDepto.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "CUIT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ciudad:";
            // 
            // textCodPos
            // 
            this.textCodPos.Location = new System.Drawing.Point(427, 118);
            this.textCodPos.Name = "textCodPos";
            this.textCodPos.Size = new System.Drawing.Size(74, 20);
            this.textCodPos.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Código postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Localidad:";
            // 
            // textDom
            // 
            this.textDom.Location = new System.Drawing.Point(80, 75);
            this.textDom.Name = "textDom";
            this.textDom.Size = new System.Drawing.Size(74, 20);
            this.textDom.TabIndex = 16;
            // 
            // textCuit
            // 
            this.textCuit.Location = new System.Drawing.Point(234, 163);
            this.textCuit.Name = "textCuit";
            this.textCuit.Size = new System.Drawing.Size(74, 20);
            this.textCuit.TabIndex = 15;
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(427, 75);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(74, 20);
            this.textPiso.TabIndex = 14;
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(234, 118);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(74, 20);
            this.textLocal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre de contacto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Depto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nro piso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "N° domicilio:";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(80, 163);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(74, 20);
            this.textMail.TabIndex = 7;
            // 
            // textNumDom
            // 
            this.textNumDom.Location = new System.Drawing.Point(234, 75);
            this.textNumDom.Name = "textNumDom";
            this.textNumDom.Size = new System.Drawing.Size(74, 20);
            this.textNumDom.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(427, 33);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(74, 20);
            this.textNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razón social:";
            // 
            // comboRubro
            // 
            this.comboRubro.DataSource = this.rubrosBindingSource;
            this.comboRubro.DisplayMember = "descripcion_corta";
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(549, 33);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(98, 21);
            this.comboRubro.TabIndex = 32;
            // 
            // gD1C2016DataSet
            // 
            this.gD1C2016DataSet.DataSetName = "GD1C2016DataSet";
            this.gD1C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "rubros";
            this.rubrosBindingSource.DataSource = this.gD1C2016DataSet;
            // 
            // rubrosTableAdapter
            // 
            this.rubrosTableAdapter.ClearBeforeFill = true;
            // 
            // Pantalla_Datos_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Pantalla_Datos_Empresa";
            this.ShowIcon = false;
            this.Text = "Alta de empresa";
            this.Load += new System.EventHandler(this.Pantalla_Datos_Empresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCuit;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textNumDom;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCodPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDom;
        private System.Windows.Forms.TextBox textNomCon;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.TextBox textDepto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboRubro;
        private GD1C2016DataSet gD1C2016DataSet;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private GD1C2016DataSetTableAdapters.rubrosTableAdapter rubrosTableAdapter;
    }
}