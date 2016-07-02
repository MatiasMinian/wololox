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
    public partial class Pantalla_Modificacion_Datos_RolGenerico : Form
    {
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter;
        private GD1C2016DataSetTableAdapters.direccionesTableAdapter dirAdapter;
        private string id;

        public Pantalla_Modificacion_Datos_RolGenerico()
        {
            InitializeComponent();
        }

        public Pantalla_Modificacion_Datos_RolGenerico(DataGridViewRow usuarioSeleccionado)
        {
            this.id = usuarioSeleccionado.Cells[0].Value.ToString();
            textNom.Text = usuarioSeleccionado.Cells[1].Value.ToString();
            textMail.Text = usuarioSeleccionado.Cells[2].Value.ToString();
            textTel.Text = usuarioSeleccionado.Cells[3].Value.ToString();
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Columns[0].ToString();
            textNumDom.Text = direccionData.Columns[1].ToString();
            textPiso.Text = direccionData.Columns[2].ToString();
            textDepto.Text = direccionData.Columns[3].ToString();
            textLoc.Text = direccionData.Columns[4].ToString();
            textCodPos.Text = direccionData.Columns[5].ToString();
            textCiudad.Text = direccionData.Columns[6].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNom.ResetText();
            textTel.ResetText();
            textDom.ResetText();
            textNumDom.ResetText();
            textMail.ResetText();
            textPiso.ResetText();
            textDepto.ResetText();
            textLoc.ResetText();
            textCodPos.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" && textTel.Text == "" && textDom.Text == ""
               && textNumDom.Text == "" && textMail.Text == "" && textPiso.Text == ""
               && textDepto.Text == "" && textLoc.Text == "" && textCodPos.Text == "")
            {
                MessageBox.Show("Complete algún campo a modificar");
            }

            userAdapter.actualizarUsuario(Convert.ToDecimal(id), textNom.Text, textMail.Text, textTel.Text, textDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textCodPos.Text);

        }
    }
}
