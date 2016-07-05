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
    public partial class Pantalla_Busqueda_RolGenerico_A_Eliminar : Form
    {
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        private GD1C2016DataSet.usuariosDataTable infoUsuarios = new GD1C2016DataSet.usuariosDataTable();
        private decimal idRol;
        public Pantalla_Busqueda_RolGenerico_A_Eliminar(decimal id)
        {
            InitializeComponent();
            this.idRol = id;
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

            infoUsuarios = userAdapter.ObtenerUsuariosHabilitados(idRol);
            dataUsuarios.Rows.Clear();
            foreach (DataRow row in infoUsuarios.Rows)
            {
                dataUsuarios.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("nombre_usuario"), row.Field<String>("mail"), row.Field<String>("telefono"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" && textTel.Text == "" && textFechaCrea.Text == "" && textEmail.Text == "")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }

            infoUsuarios = userAdapter.ObtenerUsuariosHabilitados(idRol);
            List<DataRow> filasAEliminar = new List<DataRow>();
            String nombre = textNombre.Text;
            String mail = textEmail.Text;
            String tel = textTel.Text;
            infoUsuarios = userAdapter.BuscarUsuarioHabilitado(nombre, tel, mail, idRol);
            actualizarTabla();
            return;

        }

        private void Pantalla_Busqueda_Empresa_A_Eliminar_Load(object sender, EventArgs e)
        {
            configurarTabla();
            infoUsuarios = userAdapter.ObtenerUsuariosHabilitados(idRol);
            actualizarTabla();

        }

        private void configurarTabla()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            dataUsuarios.Columns.Insert(0, id);
            id.Visible = false;

            DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
            nombre.Name = "Nombre Usuario";
            dataUsuarios.Columns.Insert(1, nombre);

            DataGridViewTextBoxColumn mail = new DataGridViewTextBoxColumn();
            mail.Name = "E-mail";
            dataUsuarios.Columns.Insert(2, mail);

            DataGridViewTextBoxColumn telefono = new DataGridViewTextBoxColumn();
            telefono.Name = "Teléfono";
            dataUsuarios.Columns.Insert(3, telefono);

            DataGridViewButtonColumn seleccionarButtonColumn = new DataGridViewButtonColumn();
            seleccionarButtonColumn.Name = "Seleccionar";
            dataUsuarios.Columns.Insert(4, seleccionarButtonColumn);
        }

        private void dataEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                userAdapter.DeshabilitarUsuario(Convert.ToDecimal(dataUsuarios.Rows[e.RowIndex].Cells[0]));
            }
            dataUsuarios.DataSource = userAdapter.ObtenerUsuariosHabilitados(idRol);
        }

        private void actualizarTabla()
        {
            dataUsuarios.Rows.Clear();
            foreach (DataRow row in infoUsuarios.Rows)
            {
                dataUsuarios.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("nombre_usuario"), row.Field<String>("mail"), row.Field<String>("telefono"));
            }
        }
    }
}
