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
    public partial class Pantalla_Busqueda_Empresa_A_Modificar : Form
    {
        private GD1C2016DataSetTableAdapters.empresasTableAdapter empAdapter = new GD1C2016DataSetTableAdapters.empresasTableAdapter();
        private GD1C2016DataSet.empresasDataTable infoEmpresas = new GD1C2016DataSet.empresasDataTable();
        public Pantalla_Busqueda_Empresa_A_Modificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRazSoc.ResetText();
            textCUIT.ResetText();
            textNom.ResetText();
            textRepMax.ResetText();
            textRepMin.ResetText();
            foreach (DataRow row in infoEmpresas.Rows)
            {
                dataEmpresas.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("razon_social"), row.Field<String>("descripcion_larga"), row.Field<String>("cuit"), row.Field<String>("nombre_contacto"), row.Field<Decimal>("reputacion"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textRazSoc.Text == "" && textCUIT.Text == "" && textNom.Text == "" && textRepMin.Text == "" && textRepMax.Text == "")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }
            infoEmpresas = empAdapter.ObtenerEmpresasHabilitadas();
            List<DataRow> filasAEliminar = new List<DataRow>();
            String razSoc = textRazSoc.Text;
            String CUIT = textCUIT.Text;
            String nombre_con = textNom.Text;
            String repMin = textRepMin.Text;
            String rubro = textRubro.Text;
            decimal repMinConv;
            if (String.IsNullOrWhiteSpace(repMin))
            {
                repMinConv = 0;
            }
            else
            {
                repMinConv = Convert.ToDecimal(repMin);
            }
            String repMax = textRepMax.Text;
            decimal repMaxConv;
            if (String.IsNullOrWhiteSpace(repMax))
            {
                repMaxConv = 0;
            }
            else
            {
                repMaxConv = Convert.ToDecimal(repMax);
            }
            infoEmpresas = empAdapter.BuscarEmpresa(razSoc, CUIT, nombre_con, rubro, repMinConv, repMaxConv);
            actualizarTabla();
            return;

        }

        private void Pantalla_Busqueda_Empresa_A_Modificar_Load(object sender, EventArgs e)
        {
            configurarTabla();
            infoEmpresas = empAdapter.ObtenerEmpresasHabilitadas();
            actualizarTabla();
        }

        private void configurarTabla()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            dataEmpresas.Columns.Insert(0, id);
            id.Visible = false;

            DataGridViewTextBoxColumn razSoc = new DataGridViewTextBoxColumn();
            razSoc.Name = "Razón Social";
            dataEmpresas.Columns.Insert(1, razSoc);

            DataGridViewTextBoxColumn rubro = new DataGridViewTextBoxColumn();
            rubro.Name = "Rubro";
            dataEmpresas.Columns.Insert(2, rubro);

            DataGridViewTextBoxColumn cuit = new DataGridViewTextBoxColumn();
            cuit.Name = "CUIT";
            dataEmpresas.Columns.Insert(3, cuit);

            DataGridViewTextBoxColumn nomCon = new DataGridViewTextBoxColumn();
            nomCon.Name = "Nombre Contacto";
            dataEmpresas.Columns.Insert(4, nomCon);

            DataGridViewTextBoxColumn rep = new DataGridViewTextBoxColumn();
            rep.Name = "Reputación";
            dataEmpresas.Columns.Insert(5, rep);

            DataGridViewButtonColumn seleccionarButtonColumn = new DataGridViewButtonColumn();
            seleccionarButtonColumn.Name = "Seleccionar";
            dataEmpresas.Columns.Insert(6, seleccionarButtonColumn);
        }

        private void dataEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Pantalla_Modificacion_Datos_Empresa pantallaMod = new Pantalla_Modificacion_Datos_Empresa(dataEmpresas.Rows[e.RowIndex]);

            }
        }

        private void actualizarTabla()
        {
            dataEmpresas.Rows.Clear();
            foreach (DataRow row in infoEmpresas.Rows)
            {
                dataEmpresas.Rows.Add(row.Field<Decimal>("id_usuario"), row.Field<String>("razon_social"), row.Field<String>("descripcion_larga"), row.Field<String>("cuit"), row.Field<String>("nombre_contacto"), row.Field<Decimal>("reputacion"));
            }
        }
    }
}
