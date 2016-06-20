using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class EliminarVisibilidad : Form
    {
        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;
        private GD1C2016DataSet.visibilidadesDataTable visibilidadesData;

        public EliminarVisibilidad()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string descripcion = textBox1.Text;
            visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();

            string costoMinimo = textBox3.Text;
            string costoMaximo = textBox2.Text; ;


            if (descripcion == "" && costoMaximo == "" && costoMinimo == "")
            {

                MessageBox.Show("Quedan campos por completar");

            }else if(costoMaximo == "" && costoMinimo == ""){


                visibilidadesData = visiAdapter.busquedaPorDescripcion(descripcion);
                

                foreach (DataRow row in visibilidadesData.Rows)
                {
                    dataGridView1.Rows.Add(row.Field<Decimal>("codigo"),                                           
                                           row.Field<String>("descripcion"),
                                           row.Field<Decimal>("porc_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("porc_publicacion"),
                                           row.Field<Decimal>("costo"),
                                           row.Field<Boolean>("habilitada"));
                }


            }
            else if (descripcion == "")
            {

                visibilidadesData = visiAdapter.busquedaPorCostos(Convert.ToDecimal(costoMinimo),Convert.ToDecimal(costoMaximo));

                foreach (DataRow row in visibilidadesData.Rows)
                {
                    dataGridView1.Rows.Add(row.Field<Decimal>("codigo"),
                                           row.Field<String>("descripcion"),
                                           row.Field<Decimal>("porc_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("porc_publicacion"),
                                           row.Field<Decimal>("costo"),
                                           row.Field<Boolean>("habilitada"));
                }

            }
            else
            {

                visibilidadesData = visiAdapter.busquedaPorDescripcionYcostos(descripcion,Convert.ToDecimal(costoMinimo), Convert.ToDecimal(costoMaximo));

                foreach (DataRow row in visibilidadesData.Rows)
                {
                    dataGridView1.Rows.Add(row.Field<Decimal>("codigo"),
                                           row.Field<String>("descripcion"),
                                           row.Field<Decimal>("porc_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("porc_publicacion"),
                                           row.Field<Decimal>("costo"),
                                           row.Field<Boolean>("habilitada"));
                }

            }

}

        private void button2_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> funcion = null;

            funcion = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        funcion(control.Controls);
            };

            funcion(Controls);
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


                visiAdapter.eliminarVisibilidad(Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value));

                MessageBox.Show("Visibilidad eliminada correctamente");


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
