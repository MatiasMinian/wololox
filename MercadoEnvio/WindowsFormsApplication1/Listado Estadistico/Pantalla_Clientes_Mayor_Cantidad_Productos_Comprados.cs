using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class Pantalla_Clientes_Mayor_Cantidad_Productos_Comprados : Form
    {
        private String anio;
        private int trimestre;
        private String rubro;
        private List<Decimal> listaMeses;


        public Pantalla_Clientes_Mayor_Cantidad_Productos_Comprados()
        {
            InitializeComponent();

            //Cargo rubros

            GD1C2016DataSetTableAdapters.rubrosTableAdapter rubroAdapter = new GD1C2016DataSetTableAdapters.rubrosTableAdapter();
            GD1C2016DataSet.rubrosDataTable rubroData = new GD1C2016DataSet.rubrosDataTable();

            rubroData = rubroAdapter.GetData();

            foreach (DataRow row in rubroData.Rows)
            {


                comboBox2.Items.Add(row[2]);


            }
        }

        public void guardarDatos(String valor1, int valor2)
        {
            listaMeses = new List<Decimal>();
            anio = valor1;
            trimestre = valor2;

            if (trimestre == 1)
            {

                listaMeses.Add(1);
                listaMeses.Add(2);
                listaMeses.Add(3);


            }
            else if (trimestre == 2)
            {


                listaMeses.Add(4);
                listaMeses.Add(5);
                listaMeses.Add(6);

            }
            else if (trimestre == 3)
            {


                listaMeses.Add(7);
                listaMeses.Add(8);
                listaMeses.Add(9);


            }
            else
            {

                listaMeses.Add(10);
                listaMeses.Add(11);
                listaMeses.Add(12);

            }

            textBox1.Text = string.Join(",", listaMeses);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text == "")
            {

                MessageBox.Show("Completar filtro de búsqueda");

            }
            else
            {

                rubro = comboBox2.Text;

                GD1C2016DataSetTableAdapters.usuariosTableAdapter usuAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
                GD1C2016DataSet.usuariosDataTable usuData = new GD1C2016DataSet.usuariosDataTable();

                  switch(trimestre){

                      case 1: usuData = usuAdapter.clientesMayorCantCompras1trimestre(anio, rubro);
                            this.generarListado(usuData);
                            break;

                    case 2: usuData = usuAdapter.clientesMayorCantCompras2trimestre(anio, rubro);
                            this.generarListado(usuData);    
                            break;

                    case 3: usuData = usuAdapter.clientesMayorCantCompras3trimestre(anio, rubro);
                            this.generarListado(usuData);
                            break;

                    case 4: usuData = usuAdapter.clientesMayorCantCompras4trimestre(anio, rubro);
                            this.generarListado(usuData);
                            break;

                }

             }
        }

        private void generarListado(GD1C2016DataSet.usuariosDataTable usuData)
        {
            if (usuData.Rows.Count == 0)
            {

                MessageBox.Show("No existen compras disponibles");

            }
            else
            {

                foreach (DataRow row in usuData.Rows)
                {

                    dataGridView1.Rows.Add(row.Field<String>("nombre_usuario"),
                                           row.Field<Decimal>("cant_compras"));


                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            comboBox2.ResetText();
            dataGridView1.Rows.Clear();
        }
    }

}