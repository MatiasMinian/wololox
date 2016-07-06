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
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        private GD1C2016DataSetTableAdapters.direccionesTableAdapter dirAdapter = new GD1C2016DataSetTableAdapters.direccionesTableAdapter();
        private string id;
        private string usuario;
        private string rol;

        public Pantalla_Modificacion_Datos_RolGenerico(DataGridViewRow usuarioSeleccionado)
        {
            InitializeComponent();
            this.id = usuarioSeleccionado.Cells[0].Value.ToString();
            textNom.Text = Convert.ToString(usuarioSeleccionado.Cells[1].Value);
            textMail.Text = Convert.ToString(usuarioSeleccionado.Cells[2].Value);
            textTel.Text = Convert.ToString(usuarioSeleccionado.Cells[3].Value);
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Rows[0].Field<String>("calle");
            textNumDom.Text = Convert.ToString(direccionData.Rows[0].Field<Decimal>("numero"));
            textPiso.Text = Convert.ToString(direccionData.Rows[0].Field<Decimal>("piso"));
            textDepto.Text = direccionData.Rows[0].Field<String>("departamento");
            textLoc.Text = direccionData.Rows[0].Field<String>("localidad");
            textCodPos.Text = direccionData.Rows[0].Field<String>("cod_postal");
            textCiudad.Text = direccionData.Rows[0].Field<String>("ciudad");
        }

        public Pantalla_Modificacion_Datos_RolGenerico(string usuario, string rol)
        {
            // TODO: Complete member initialization
            this.usuario = usuario;
            this.rol = rol;
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

            userAdapter.ActualizarUsuario(Convert.ToDecimal(id), textNom.Text, textMail.Text, textTel.Text, textDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textCodPos.Text);
            MessageBox.Show("Usuario modificado");
            this.Close();
        }

    }
}
