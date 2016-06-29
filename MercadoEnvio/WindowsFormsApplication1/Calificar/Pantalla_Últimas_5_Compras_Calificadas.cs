using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Calificar
{
    public partial class Pantalla_Últimas_5_Compras_Calificadas : Form
    {
        private Decimal id_user;
        private GD1C2016DataSetTableAdapters.calificacionesTableAdapter caliAdapter;
        private GD1C2016DataSet.calificacionesDataTable caliData;


        public Pantalla_Últimas_5_Compras_Calificadas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void generarListado(decimal id)
        {
            id_user = id;

            caliAdapter = new GD1C2016DataSetTableAdapters.calificacionesTableAdapter();
            caliData = caliAdapter.ultimas5comprasCalificadas(id);

            foreach (DataRow row in caliData.Rows)
            {

                dataGridView1.Rows.Add(row.Field<Decimal>("id_compra"),
                                       row.Field<Decimal>("cantidad"),
                                       row.Field<DateTime>("fecha"),
                                       row.Field<String>("descripcion"),
                                       row.Field<Decimal>("estrellas"),
                                       row.Field<String>("nombre_usuario"));


            }



        }
    }
}
