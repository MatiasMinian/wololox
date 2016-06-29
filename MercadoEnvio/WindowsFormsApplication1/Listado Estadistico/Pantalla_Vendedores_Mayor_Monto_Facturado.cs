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
    public partial class Pantalla_Vendedores_Mayor_Monto_Facturado : Form
    {
        private String anio;
        private int trimestre;
        private List<Decimal> listaMeses;

        public Pantalla_Vendedores_Mayor_Monto_Facturado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            GD1C2016DataSetTableAdapters.usuariosTableAdapter usuAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable usuData = new GD1C2016DataSet.usuariosDataTable();

            switch (trimestre)
            {

                case 1: usuData = usuAdapter.vendedoresMayorMontoFacturado1trimestre(anio);
                    this.generarListado(usuData);
                    break;

                case 2: usuData = usuAdapter.vendedoresMayorMontoFacturado2trimestre(anio);
                    this.generarListado(usuData);
                    break;

                case 3: usuData = usuAdapter.vendedoresMayorMontoFacturado3trimestre(anio);
                    this.generarListado(usuData);
                    break;

                case 4: usuData = usuAdapter.vendedoresMayorMontoFacturado4trimestre(anio);
                    this.generarListado(usuData);
                    break;

            }

        }

        private void generarListado(GD1C2016DataSet.usuariosDataTable usuData)
        {
            if (usuData.Rows.Count == 0)
            {

                MessageBox.Show("No existen facturas disponibles");

            }
            else
            {

                foreach (DataRow row in usuData.Rows)
                {

                    dataGridView1.Rows.Add(row.Field<String>("nombre_usuario"),
                                           row.Field<Decimal>("monto_facturado"));


                }
            }

        }

        public void guardarDatos(String valor1, int valor2)
        {
            listaMeses = new List<Decimal>();
            anio = valor1;
            trimestre = valor2;

            //Cargo meses según trimestre

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
