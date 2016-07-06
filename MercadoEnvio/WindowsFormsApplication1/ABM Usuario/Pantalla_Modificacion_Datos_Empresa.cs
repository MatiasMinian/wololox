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
        private GD1C2016DataSetTableAdapters.empresasTableAdapter empAdapter = new GD1C2016DataSetTableAdapters.empresasTableAdapter();
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        private GD1C2016DataSetTableAdapters.direccionesTableAdapter dirAdapter = new GD1C2016DataSetTableAdapters.direccionesTableAdapter();
        String id;
        private string usuario;

        public Pantalla_Modificacion_Datos_Empresa(DataGridViewRow empresaSeleccionada)
        {
            InitializeComponent();
            this.rubrosTableAdapter.Fill(this.gD1C2016DataSet.rubros);
            this.id = empresaSeleccionada.Cells[0].Value.ToString();
            textRacSoc.Text = empresaSeleccionada.Cells[1].Value.ToString();
            comboRubro.Text = empresaSeleccionada.Cells[2].Value.ToString();
            textCUIT.Text = empresaSeleccionada.Cells[3].Value.ToString();
            textNomCon.Text = empresaSeleccionada.Cells[4].Value.ToString();
            GD1C2016DataSet.usuariosDataTable usersData = userAdapter.BuscarUsuario(Convert.ToDecimal(id));
            textMail.Text = usersData.Rows[0].Field<String>("mail");
            textTel.Text = usersData.Rows[0].Field<String>("telefono");
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Rows[0].Field<String>("calle");
            textNumDom.Text = direccionData.Rows[0].Field<Decimal>("numero").ToString();
            textPiso.Text = direccionData.Rows[0].Field<Decimal>("piso").ToString();
            textDepto.Text = direccionData.Rows[0].Field<String>("departamento");
            textLocal.Text = direccionData.Rows[0].Field<String>("localidad");
            textCodPos.Text = direccionData.Rows[0].Field<String>("cod_postal");
            textCiudad.Text = direccionData.Rows[0].Field<String>("ciudad");
            
        }

        public Pantalla_Modificacion_Datos_Empresa(decimal idUser)
        {
            InitializeComponent();
            this.rubrosTableAdapter.Fill(this.gD1C2016DataSet.rubros);
            GD1C2016DataSet.empresasDataTable empData = empAdapter.ObtenerEmpresa(idUser);
            this.id = idUser.ToString();
            textRacSoc.Text = empData.Rows[0].Field<String>("razon_social");
            comboRubro.Text = empData.Rows[0].Field<String>("descripcion_larga");
            textCUIT.Text = empData.Rows[0].Field<String>("cuit");
            textNomCon.Text = empData.Rows[0].Field<String>("nombre_contacto");
            GD1C2016DataSet.usuariosDataTable usersData = userAdapter.BuscarUsuario(Convert.ToDecimal(id));
            textMail.Text = usersData.Rows[0].Field<String>("mail");
            textTel.Text = usersData.Rows[0].Field<String>("telefono");
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Rows[0].Field<String>("calle");
            textNumDom.Text = direccionData.Rows[0].Field<Decimal>("numero").ToString();
            textPiso.Text = direccionData.Rows[0].Field<Decimal>("piso").ToString();
            textDepto.Text = direccionData.Rows[0].Field<String>("departamento");
            textLocal.Text = direccionData.Rows[0].Field<String>("localidad");
            textCodPos.Text = direccionData.Rows[0].Field<String>("cod_postal");
            textCiudad.Text = direccionData.Rows[0].Field<String>("ciudad");
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
            MessageBox.Show("Usuario modificado");
            this.Close();
        }


    }
}
