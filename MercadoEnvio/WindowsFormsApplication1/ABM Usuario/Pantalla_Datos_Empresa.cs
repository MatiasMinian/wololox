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

    public partial class Pantalla_Datos_Empresa : Form
    {
        private GD1C2016DataSetTableAdapters.empresasTableAdapter empAdapter;
        public Pantalla_Datos_Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNombre.ResetText();
            textNumDom.ResetText();
            textLocal.ResetText();
            textMail.ResetText();
            textPiso.ResetText();
            textCuit.ResetText();
            textDom.ResetText();
            textCodPos.ResetText();
            textDepto.ResetText();
            textCiudad.ResetText();
            textNomCon.ResetText();
            textRubro.ResetText();
            textTel.ResetText();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" || textNumDom.Text == "" || textLocal.Text == "" || textMail.Text == ""
              || textPiso.Text == "" || textCuit.Text == "" || textDom.Text == "" || textCodPos.Text == ""
              || textDepto.Text == "" || textCiudad.Text == "" || textNomCon.Text == "" || textRubro.Text == ""
              || textTel.Text == "")
            {

                MessageBox.Show("Complete campos vacíos");
            }
            empAdapter = new GD1C2016DataSetTableAdapters.empresasTableAdapter();
            empAdapter.crearEmpresa(textUser.Text, textPass.Text, textNombre.Text, textMail.Text, textTel.Text, textDom.Text, textNumDom.Text, textPiso.Text, textDepto.Text, textLocal.Text, textCiudad.Text, textCodPos.Text, textCuit.Text, comboRubro.SelectedText,textNomCon.Text);
        }

        private void Pantalla_Datos_Empresa_Load(object sender, EventArgs e)
        {
            this.rubrosTableAdapter.Fill(this.gD1C2016DataSet.rubros);

        }


    }
}
