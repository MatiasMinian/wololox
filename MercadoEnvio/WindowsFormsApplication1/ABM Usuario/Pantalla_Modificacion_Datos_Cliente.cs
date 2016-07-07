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
        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter = new GD1C2016DataSetTableAdapters.clientesTableAdapter();
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        private GD1C2016DataSetTableAdapters.direccionesTableAdapter dirAdapter = new GD1C2016DataSetTableAdapters.direccionesTableAdapter();
        String id;
  

        public Pantalla_Modificacion_Datos_Cliente(DataGridViewRow clienteSeleccionado)
        {
            InitializeComponent();

            var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

            String appDate = value;

            
            
            //Formato fecha

            textFechaNac.Format = DateTimePickerFormat.Custom;
            textFechaNac.CustomFormat = "dd/MM/yyyy";

            textFechaNac.MaxDate = Convert.ToDateTime(appDate);

            this.id = clienteSeleccionado.Cells[0].Value.ToString();
            textNom.Text = clienteSeleccionado.Cells[1].Value.ToString();
            textApe.Text = clienteSeleccionado.Cells[2].Value.ToString();
            textMail.Text = clienteSeleccionado.Cells[3].Value.ToString();
            textDni.Text = clienteSeleccionado.Cells[4].Value.ToString();
            GD1C2016DataSet.usuariosDataTable usersData = userAdapter.BuscarUsuario(Convert.ToDecimal(id));
            textTel.Text = usersData.Rows[0].Field<String>("telefono");
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Rows[0].Field<String>("calle");
            textNumDom.Text = direccionData.Rows[0].Field<Decimal>("numero").ToString();
            textPiso.Text = direccionData.Rows[0].Field<Decimal>("piso").ToString();
            textDepto.Text = direccionData.Rows[0].Field<String>("departamento");
            textLoc.Text = direccionData.Rows[0].Field<String>("localidad");
            textCodPos.Text = direccionData.Rows[0].Field<String>("cod_postal");
            textCiudad.Text = direccionData.Rows[0].Field<String>("ciudad");
        }

        public Pantalla_Modificacion_Datos_Cliente(decimal idUser)
        {
            InitializeComponent();
            //Formato fecha

            textFechaNac.Format = DateTimePickerFormat.Custom;
            textFechaNac.CustomFormat = "dd/MM/yyyy";

            GD1C2016DataSet.clientesDataTable cliData = cliAdapter.ObtenerCliente(idUser);
            this.id = idUser.ToString();
            textNom.Text = cliData.Rows[0].Field<String>("nombre");
            textApe.Text = cliData.Rows[0].Field<String>("apellido");
            textDni.Text = cliData.Rows[0].Field<String>("dni");
            GD1C2016DataSet.usuariosDataTable usersData = userAdapter.BuscarUsuario(Convert.ToDecimal(id));
            textTel.Text = usersData.Rows[0].Field<String>("telefono");
            textMail.Text = usersData.Rows[0].Field<String>("nombre");
            GD1C2016DataSet.direccionesDataTable direccionData = dirAdapter.BuscarDireccion(Convert.ToDecimal(id));
            textDom.Text = direccionData.Rows[0].Field<String>("calle");
            textNumDom.Text = direccionData.Rows[0].Field<Decimal>("numero").ToString();
            textPiso.Text = direccionData.Rows[0].Field<Decimal>("piso").ToString();
            textDepto.Text = direccionData.Rows[0].Field<String>("departamento");
            textLoc.Text = direccionData.Rows[0].Field<String>("localidad");
            textCodPos.Text = direccionData.Rows[0].Field<String>("cod_postal");
            textCiudad.Text = direccionData.Rows[0].Field<String>("ciudad");
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

            cliAdapter.ActualizarCliente(Convert.ToDecimal(id), textNom.Text, textApe.Text, textMail.Text, textTel.Text, textDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textCodPos.Text, Convert.ToDecimal(textDni.Text), Convert.ToDateTime(textFechaNac.Text));
            MessageBox.Show("Usuario modificado");
            this.Close();
        }

 
    }

}