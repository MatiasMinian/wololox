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
    public partial class Pantalla_Datos_Cliente : Form{

        private Decimal id;

 
        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter;
        public Pantalla_Datos_Cliente()
        {
            InitializeComponent();

            //Formato fecha

            textFechaNac.Format = DateTimePickerFormat.Custom;
            textFechaNac.CustomFormat = "dd/MM/yyyy";

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
            textUser.ResetText();
            textPass.ResetText();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textTel.Text == "" || texDom.Text == "" || textApe.Text == ""
               || textDNI.Text == "" || textNumDom.Text == "" || textMail.Text == "" || textPiso.Text == ""
               || textDepto.Text == "" || textLoc.Text == "" || textPost.Text == "" || textUser.Text == "" || textPass.Text == "")
            {

                MessageBox.Show("Complete campos vacíos");

            }

            cliAdapter = new GD1C2016DataSetTableAdapters.clientesTableAdapter();
            cliAdapter.actualizarCliente(id, textNom.Text, textApe.Text, textMail.Text, textTel.Text, texDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textPost.Text, Convert.ToDecimal(textDNI.Text), Convert.ToDateTime(textFechaNac.Text));
            
        }

    }

}