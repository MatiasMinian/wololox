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
    public partial class Pantalla_Vendedores_Mayor_Cantidad_Productos_No_Vendidos : Form
    {
       private String anio;
       private int trimestre;
       private List<int> listaMeses;

        public Pantalla_Vendedores_Mayor_Cantidad_Productos_No_Vendidos()
        {
            InitializeComponent();

      
            //Cargar visibilidades

            GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
            GD1C2016DataSet.visibilidadesDataTable visiData = new GD1C2016DataSet.visibilidadesDataTable();
            visiData = visiAdapter.GetData();

            foreach (DataRow row in visiData)
            {
                comboBox2.Items.Add(row[1]);

            }      

        }

        internal void guardarDatos(int trim, String anio)
        {
            listaMeses = new List<int>();
            this.anio = anio;
            trimestre = trim;


            //Cargo meses según trimestre

            if (trimestre== 1)
            {
                
                listaMeses.Add(1);
                listaMeses.Add(2);
                listaMeses.Add(3);


            }
            else if (trimestre==2)
            {

                
                listaMeses.Add(4);
                listaMeses.Add(5);
                listaMeses.Add(6);

            }
            else if (trimestre==3)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GD1C2016DataSetTableAdapters.usuariosTableAdapter usuAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable usuData = new GD1C2016DataSet.usuariosDataTable();

            String visibilidad = comboBox2.Text;

            if (comboBox2.Text == "")
            {

                MessageBox.Show("Complete filtro de búsqueda");

            }
            else
            {

                switch(trimestre){

                    case 1: usuData=usuAdapter.vendedorProductosNoVendidos1trimestre(anio, visibilidad);
                            this.generarListado(usuData);
                            break;

                    case 2: usuData = usuAdapter.vendedorProductosNoVendidos2trimestre(anio, visibilidad);
                            this.generarListado(usuData);    
                            break;

                    case 3: usuData = usuAdapter.vendedorProductosNoVendidos3trimestre(anio, visibilidad);
                            this.generarListado(usuData);
                            break;

                    case 4: usuData = usuAdapter.vendedorProductosNoVendidos4trimestre(anio, visibilidad);
                            this.generarListado(usuData);
                            break;

                }

             }
        }

        private void generarListado(GD1C2016DataSet.usuariosDataTable usuData)
        {
            if (usuData.Rows.Count == 0)
            {

                MessageBox.Show("No existen publicaciones en esa fecha");

            }
            else
            {

                foreach (DataRow row in usuData.Rows)
                {

                    dataGridView1.Rows.Add(row.Field<String>("nombre_usuario"),
                                           row.Field<Decimal>("cant_no_vendidos"));


                }
            }

        }

    }

}
