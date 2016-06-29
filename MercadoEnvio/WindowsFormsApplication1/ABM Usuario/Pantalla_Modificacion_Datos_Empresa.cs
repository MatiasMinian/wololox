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
    public partial class Pantalla_Modificacion_Datos_Empresa : Form
    {
        private GD1C2016DataSetTableAdapters.empresasTableAdapter empAdapter;
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter;
        private GD1C2016DataSetTableAdapters.direccionesTableAdapter dirAdapter;
        String id;

        public Pantalla_Modificacion_Datos_Empresa(DataGridViewRow empresaSeleccionada)
        {
            this.id = empresaSeleccionada.Cells[0].Value.ToString();
            textRacSoc.Text = empresaSeleccionada.Cells[1].Value.ToString();
            comboRubro.SelectedText = empresaSeleccionada.Cells[2].Value.ToString();
            textCUIT.Text = empresaSeleccionada.Cells[3].Value.ToString();
            textNomCon.Text = empresaSeleccionada.Cells[4].Value.ToString();
            GD1C2016DataSet.usuariosDataTable usersData = userAdapter.BuscarUsuario(Convert.ToDecimal(id));
            textMail.Text = usersData.Columns[0].ToString();
            textTel.Text = usersData.Columns[1].ToString();
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Columns[0].ToString();
            textNumDom.Text = direccionData.Columns[1].ToString();
            textPiso.Text = direccionData.Columns[2].ToString();
            textDepto.Text = direccionData.Columns[3].ToString();
            textLocal.Text = direccionData.Columns[4].ToString();
            textCodPos.Text = direccionData.Columns[5].ToString();
            textCiudad.Text = direccionData.Columns[6].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRacSoc.ResetText();
            textMail.ResetText();
            textDepto.ResetText();
            textDom.ResetText();
            textPiso.ResetText();
            textLocal.ResetText();
            textNumDom.ResetText();
            textCodPos.ResetText();
            textCiudad.ResetText();
            textCUIT.ResetText();
            textNomCon.ResetText();
            textTel.ResetText();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textRacSoc.Text == "" && textMail.Text == "" && textDepto.Text == "" && textDom.Text == ""
                && textPiso.Text == "" && textLocal.Text == "" && textNumDom.Text == "" && textCodPos.Text == ""
                && textCiudad.Text == "" && textCUIT.Text == "" && textNomCon.Text == "" && textTel.Text == "")
            {
                MessageBox.Show("Complete algún campo a modificar");
            }
            empAdapter.actualizarEmpresa(Convert.ToDecimal(id), textRacSoc.Text, Convert.ToDecimal(comboRubro.SelectedValue), textMail.Text, textTel.Text, textDom.Text, Convert.ToDecimal(textNumDom.Text),Convert.ToDecimal(textPiso.Text), textDepto.Text, textLocal.Text, textCiudad.Text,textCodPos.Text, textCUIT.Text, textNomCon.Text);
        }

        private void Pantalla_Modificacion_Datos_Empresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet.rubros' table. You can move, or remove it, as needed.
            this.rubrosTableAdapter.Fill(this.gD1C2016DataSet.rubros);

        }


    }
}
