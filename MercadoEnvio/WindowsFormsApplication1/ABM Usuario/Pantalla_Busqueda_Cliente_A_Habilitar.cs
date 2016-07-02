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
            dataClientes.DataSource = cliAdapter.BuscarCliente(textNombre.Text, textApellido.Text, textEmail.Text, Convert.ToDecimal(textDNI.Text));

        }

        private void Pantalla_Busqueda_Cliente_A_Habilitar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet.clientes' table. You can move, or remove it, as needed.
            dataClientes.DataSource = cliAdapter.ObtenerClientesBloqueados();

        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                cliAdapter.HabilitarUsuario(Convert.ToDecimal(dataClientes.Rows[e.RowIndex].Cells[0]));
            }
            dataClientes.DataSource = cliAdapter.ObtenerClientesBloqueados();
        }

    }
}
