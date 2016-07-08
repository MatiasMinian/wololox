using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Pantalla_Datos_Cliente : Form
    {

        private String idUsuario;
        private String contraseña;


        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter;
        public Pantalla_Datos_Cliente(String id, String pass)
        {
            InitializeComponent();

           var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

           String appDate = value;

            //Formato fecha
            this.idUsuario = id;
            this.contraseña = pass;

            textFechaNac.Format = DateTimePickerFormat.Custom;
            textFechaNac.CustomFormat = "dd/MM/yyyy";

            textFechaNac.MaxDate = Convert.ToDateTime(appDate);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNom.ResetText();
            textTel.ResetText();
            texDom.ResetText();
            textApe.ResetText();
            textDNI.ResetText();
            textNumDom.ResetText();
            textMail.ResetText();
            textPiso.ResetText();
            textDepto.ResetText();
            textLoc.ResetText();
            textPost.ResetText();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textTel.Text == "" || texDom.Text == "" || textApe.Text == ""
               || textNumDom.Text == "" || textMail.Text == "" || textDNI.Text=="" || textPiso.Text=="" || textDepto.Text==""
               || textLoc.Text == "" || textPost.Text == "")
            {

                MessageBox.Show("Complete campos obligatorios");

            }
            else
            {
                cliAdapter = new GD1C2016DataSetTableAdapters.clientesTableAdapter();
                cliAdapter.CrearCliente(idUsuario, contraseña, textNom.Text, textApe.Text, textMail.Text, textTel.Text, texDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textPost.Text, Convert.ToDecimal(textDNI.Text), Convert.ToDateTime(textFechaNac.Text));
                MessageBox.Show("Usuario creado");
                this.Close();
            }

        }

    }

}