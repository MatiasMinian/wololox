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
    public partial class Pantalla_Busqueda_Cliente_A_Habilitar : Form
    {
        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter = new GD1C2016DataSetTableAdapters.clientesTableAdapter();
        private GD1C2016DataSet.clientesDataTable infoClientes = new GD1C2016DataSet.clientesDataTable();
        public Pantalla_Busqueda_Cliente_A_Habilitar()
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
            infoClientes = cliAdapter.ObtenerClientesBloqueados();
            dataClientes.Rows.Clear();
            foreach (DataRow row in infoClientes.Rows)
            {
                dataClientes.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("nombre"), row.Field<String>("apellido"), row.Field<String>("mail"), row.Field<Decimal>("dni"));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" && textApellido.Text == "" && textDNI.Text == "" && textEmail.Text == "")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }
            infoClientes = cliAdapter.ObtenerClientesBloqueados();
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
            infoClientes = cliAdapter.BuscarClienteBloq(nombre, apellido, email, dniConvertido);
            actualizarTabla();
            return;

        }

        private void Pantalla_Busqueda_Cliente_A_Habilitar_Load(object sender, EventArgs e)
        {
            configurarTabla();
            infoClientes = cliAdapter.ObtenerClientesBloqueados();
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
                cliAdapter.HabilitarUsuario(Convert.ToDecimal(dataClientes.Rows[e.RowIndex].Cells[0].Value));
                MessageBox.Show("Usuario desbloqueado");
            }
            infoClientes = cliAdapter.ObtenerClientesBloqueados();
            actualizarTabla();
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
