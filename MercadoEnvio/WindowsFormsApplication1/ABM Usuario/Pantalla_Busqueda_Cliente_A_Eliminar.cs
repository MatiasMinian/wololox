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
    public partial class Pantalla_Busqueda_Cliente_A_Eliminar : Form
    {
        private GD1C2016DataSetTableAdapters.clientesTableAdapter cliAdapter = new GD1C2016DataSetTableAdapters.clientesTableAdapter();
        public Pantalla_Busqueda_Cliente_A_Eliminar()
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
            textApe.ResetText();
            textDNI.ResetText();
            textEmail.ResetText();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textNombre.Text == "" && textApe.Text == "" && textDNI.Text == "" && textEmail.Text == "")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }
            dataClientes.DataSource = BuscarCliente(textNombre.Text, textApe.Text, textEmail.Text, textDNI.Text);
        }

        private void Pantalla_Busqueda_Cliente_A_Eliminar_Load(object sender, EventArgs e)
        {
            dataClientes.DataSource = cliAdapter.ObtenerClientesHabilitados();
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                cliAdapter.DeshabilitarUsuario(dataClientes.Rows[e.RowIndex].Cells[0]);
            }
            dataClientes.DataSource = cliAdapter.ObtenerClientesHabilitados();
        }

    }
}
