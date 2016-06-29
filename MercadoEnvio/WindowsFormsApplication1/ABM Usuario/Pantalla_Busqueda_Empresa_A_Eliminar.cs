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
    public partial class Pantalla_Busqueda_Empresa_A_Eliminar : Form
    {
        private GD1C2016DataSetTableAdapters.empresasTableAdapter empAdapter = new GD1C2016DataSetTableAdapters.empresasTableAdapter();
        public Pantalla_Busqueda_Empresa_A_Eliminar()
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
            textNom.ResetText();
            textCUIT.ResetText();
            textRepMax.ResetText();
            textRepMin.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textRazSoc.Text == "" && textNom.Text == "" && textCUIT.Text == "" && textRepMax.Text=="" && textRepMin.Text=="")
            {
                MessageBox.Show("Complete algún campo de búsqueda");
            }
            dataEmpresas.DataSource = empAdapter.BuscarEmpresa(textRazSoc.Text, textCUIT.Text, textNom.Text, textRubro.Text, Convert.ToDecimal(textRepMin),Convert.ToDecimal(textRepMax));

        }

        private void Pantalla_Busqueda_Empresa_A_Eliminar_Load(object sender, EventArgs e)
        {
            dataEmpresas.DataSource = empAdapter.ObtenerEmpresasHabilitadas();

        }

        private void dataEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                empAdapter.DeshabilitarUsuario(Convert.ToDecimal(dataEmpresas.Rows[e.RowIndex].Cells[0]));
            }
            dataEmpresas.DataSource = empAdapter.ObtenerEmpresasHabilitadas();
        }
    }
}
