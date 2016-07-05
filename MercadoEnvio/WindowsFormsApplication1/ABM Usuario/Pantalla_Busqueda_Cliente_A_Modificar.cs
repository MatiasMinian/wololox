using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Pantalla_Busqueda_Cliente_A_Modificar : Form
    {
        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter = new GD1C2016DataSetTableAdapters.clientesTableAdapter();
        private GD1C2016DataSet.clientesDataTable infoClientes = new GD1C2016DataSet.clientesDataTable();
        public Pantalla_Busqueda_Cliente_A_Modificar()
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
            textApellido.ResetText();
            textDNI.ResetText();
            textEmail.ResetText();
            infoClientes = cliAdapter.ObtenerClientesHabilitados();
            dataClientes.Rows.Clear();
            foreach (DataRow row in infoClientes.Rows)
            {
                dataClientes.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("nombre"), row.Field<String>("apellido"), row.Field<String>("mail"), row.Field<Decimal>("dni"));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" && textApellido.Text == "" && textDNI.Text == "" && textEmail.Text == "")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }
            infoClientes = cliAdapter.ObtenerClientesHabilitados();
            List<DataRow> filasAEliminar = new List<DataRow>();
            String nombre = textNombre.Text;
            String apellido = textApellido.Text;
            String email = textEmail.Text;
            String dni = textDNI.Text;
            decimal dniConvertido;
            if (String.IsNullOrWhiteSpace(dni))
            {
                dniConvertido = 0;
            }
            else
            {
                dniConvertido = Convert.ToDecimal(dni);
            }
            infoClientes = cliAdapter.BuscarCliente(nombre, apellido, email, dniConvertido);
            actualizarTabla();
            return;
        }

        private void Pantalla_Busqueda_Cliente_A_Modificar_Load(object sender, EventArgs e)
        {
            configurarTabla();
            infoClientes = cliAdapter.ObtenerClientesHabilitados();
            actualizarTabla();

        }

        private void configurarTabla()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            dataClientes.Columns.Insert(0, id);
            id.Visible = false;

            DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
            nombre.Name = "Nombre";
            dataClientes.Columns.Insert(1, nombre);

            DataGridViewTextBoxColumn apellido = new DataGridViewTextBoxColumn();
            apellido.Name = "Apellido";
            dataClientes.Columns.Insert(2, apellido);

            DataGridViewTextBoxColumn mail = new DataGridViewTextBoxColumn();
            mail.Name = "E-mail";
            dataClientes.Columns.Insert(3, mail);

            DataGridViewTextBoxColumn dni = new DataGridViewTextBoxColumn();
            dni.Name = "DNI";
            dataClientes.Columns.Insert(4, dni);

            DataGridViewButtonColumn seleccionarButtonColumn = new DataGridViewButtonColumn();
            seleccionarButtonColumn.Name = "Seleccionar";
            dataClientes.Columns.Insert(5, seleccionarButtonColumn);
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Pantalla_Modificacion_Datos_Cliente pantallaMod = new Pantalla_Modificacion_Datos_Cliente(dataClientes.Rows[e.RowIndex]);
                pantallaMod.ShowDialog();
                this.Close();
            }
        }

        private void actualizarTabla()
        {
            dataClientes.Rows.Clear();
            foreach (DataRow row in infoClientes.Rows)
            {
                dataClientes.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("nombre"), row.Field<String>("apellido"), row.Field<String>("mail"), row.Field<Decimal>("dni"));
            }
        }

    }
}
