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
    public partial class Pantalla_Modificacion_Datos_Cliente : Form
    {
        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter;
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter;
        private GD1C2016DataSetTableAdapters.direccionesTableAdapter dirAdapter;
        String id;

        public Pantalla_Modificacion_Datos_Cliente(DataGridViewRow clienteSeleccionado)
        {
            InitializeComponent();
            //Formato fecha

            textFechaNac.Format = DateTimePickerFormat.Custom;
            textFechaNac.CustomFormat = "dd/MM/yyyy";

            this.id = clienteSeleccionado.Cells[0].Value.ToString();
            textNom.Text = clienteSeleccionado.Cells[1].Value.ToString();
            textApe.Text = clienteSeleccionado.Cells[2].Value.ToString();
            textDni.Text = clienteSeleccionado.Cells[3].Value.ToString();
            textFechaNac.Text = clienteSeleccionado.Cells[4].Value.ToString();
            GD1C2016DataSet.usuariosDataTable usersData = userAdapter.BuscarUsuario(Convert.ToDecimal(id));
            textMail.Text = usersData.Columns[0].ToString();
            textTel.Text = usersData.Columns[1].ToString();
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
            textApe.ResetText();
            textDni.ResetText();
            textNumDom.ResetText();
            textMail.ResetText();
            textPiso.ResetText();
            textDepto.ResetText();
            textLoc.ResetText();
            textCodPos.ResetText();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" && textTel.Text == "" && textDom.Text == "" && textApe.Text == ""
               && textDni.Text == "" && textNumDom.Text == "" && textMail.Text == "" && textPiso.Text == ""
               && textDepto.Text == "" && textLoc.Text == "" && textCodPos.Text == "")
    
            {
                MessageBox.Show("Complete algún campo a modificar");
            }

            cliAdapter.actualizarCliente(Convert.ToDecimal(id), textNom.Text, textApe.Text, textMail.Text, textTel.Text, textDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textCodPos.Text, Convert.ToDecimal(textDni.Text), Convert.ToDateTime(textFechaNac.Text));

        }

 
    }

}