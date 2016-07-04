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
    public partial class ModifVisibilidad : Form
    {
        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;
        private GD1C2016DataSet.visibilidadesDataTable visibilidadesData;


        public ModifVisibilidad()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {

            string descripcion = textBox1.Text;
            visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();

            string costoMinimo = textBox3.Text;
            string costoMaximo = textBox2.Text; ;


            if (descripcion == "" && costoMaximo == "" && costoMinimo == "")
            {

                MessageBox.Show("Quedan campos por completar");


            }    
            else if (descripcion == "" && (costoMaximo == "" || costoMinimo == "") || 
                (descripcion != "" && costoMaximo == "" && costoMinimo != "") || 
                (descripcion != "" && costoMaximo != "" && costoMinimo == "")){

                MessageBox.Show("Quedan campos por completar");

            }
             else if(costoMaximo == "" && costoMinimo == ""){


                visibilidadesData = visiAdapter.busquedaPorDescripcion(descripcion);
                

                foreach (DataRow row in visibilidadesData.Rows)
                {
                    dataGridView1.Rows.Add(row.Field<Decimal>("codigo"),                                           
                                           row.Field<String>("descripcion"),
                                           row.Field<Object>("costo_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("costo_publicacion"),
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
                                           row.Field<Object>("costo_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("costo_publicacion"),
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
                                           row.Field<Object>("costo_envio"),
                                           row.Field<Decimal>("porc_producto"),
                                           row.Field<Decimal>("costo_publicacion"),
                                           row.Field<Boolean>("habilitada"));
                }

            }

}
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


                EditarDatosVisibilidad pantallaEditarDatos = new EditarDatosVisibilidad();
                pantallaEditarDatos.cargarDatos(dataGridView1.CurrentRow.Cells[0].Value,
                                    dataGridView1.CurrentRow.Cells[1].Value,
                                    dataGridView1.CurrentRow.Cells[2].Value,
                                    dataGridView1.CurrentRow.Cells[3].Value,
                                    dataGridView1.CurrentRow.Cells[4].Value);

                pantallaEditarDatos.ShowDialog();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
