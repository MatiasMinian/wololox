using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class Pantalla_Seleccion_Rubros : Form
    {

        private List<String> listaRubros;
        private GD1C2016DataSetTableAdapters.rubrosTableAdapter rubrosAdapter;
        private GD1C2016DataSet.rubrosDataTable rubrosData;
        private TextBox textBoxRubros;

        public Pantalla_Seleccion_Rubros()
        {
            InitializeComponent();

            rubrosAdapter = new GD1C2016DataSetTableAdapters.rubrosTableAdapter();
            rubrosData = new GD1C2016DataSet.rubrosDataTable();
            rubrosData = rubrosAdapter.GetData();

            foreach (DataRow row in rubrosData.Rows)
            {
                dataGridView1.Rows.Add(row.Field<String>("descripcion_corta"));

            }

        }

        public void guardarDatos(TextBox tbRubros,List<String> listRubros)
        {
            listaRubros = listRubros;
            textBoxRubros = tbRubros;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for(int i = 0;i<dataGridView1.GetCellCount(DataGridViewElementStates.Selected);i++)
            {

                listaRubros.Add(Convert.ToString(dataGridView1.SelectedCells[i].Value));

            }

            textBoxRubros.Text = string.Join(",", listaRubros);
            this.Close();
            

        }
    }
}
