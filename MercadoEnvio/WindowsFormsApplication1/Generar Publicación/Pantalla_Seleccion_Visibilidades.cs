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
    public partial class Pantalla_Seleccion_Visibilidades : Form
    {

        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;
        private GD1C2016DataSet.visibilidadesDataTable visiData;
        private TextBox visiText;
        private TextBox costoText;


        public Pantalla_Seleccion_Visibilidades(Decimal idUser)
        {
            InitializeComponent();

            visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
            visiData = new GD1C2016DataSet.visibilidadesDataTable();
            visiData = visiAdapter.GetData();

            GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();
            decimal cantidadDePublicaciones = Convert.ToDecimal(publiAdapter.cantidadDePublicacionesUsuario(idUser));

            foreach (DataRow row in visiData.Rows)
            {
                if (row[1].Equals("Gratuita") && cantidadDePublicaciones >= 1)
                {


                }
                else
                {
                    dataGridView1.Rows.Add(row.Field<String>("descripcion"),
                                           row.Field<Decimal>("costo_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("costo_publicacion"));
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void guardaDatos(TextBox tbVisi,TextBox tbCosto)
        {

            visiText = tbVisi;
            costoText = tbCosto;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            visiText.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            costoText.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

            this.Close();
        }
    }
}
