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
    public partial class Pantalla_Busqueda_RolGenerico_A_Modificar : Form
    {

        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        public Pantalla_Busqueda_RolGenerico_A_Modificar()
        {
            InitializeComponent();
        }

        private void Pantalla_Busqueda_RolGenerico_A_Modificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.gD1C2016DataSet.usuarios);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNombre.ResetText();
            textFechaCrea.ResetText();
            textTel.ResetText();
            textEmail.ResetText();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" && textTel.Text == "" && textFechaCrea.Text == "" && textEmail.Text == "")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }
            dataClientes.DataSource = userAdapter.BuscarUsuarioHabilitado(textNombre.Text, textTel.Text, textEmail.Text, textFechaCrea.Text);
        }

        private void Pantalla_Busqueda_Cliente_A_Modificar_Load(object sender, EventArgs e)
        {
            dataClientes.DataSource = userAdapter.ObtenerUsuariosHabilitados();
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Pantalla_Modificacion_Datos_RolGenerico pantallaMod = new Pantalla_Modificacion_Datos_RolGenerico(dataClientes.Rows[e.RowIndex]);
            }
        }
    }
}
