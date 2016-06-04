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
        public Pantalla_Clientes_Mayor_Cantidad_Productos_Comprados()
        {
            InitializeComponent();
        }

        public void guardaParametrosParaBusqueda(decimal valor1, decimal valor2)
        {
            decimal anio;
            decimal trimestre;

            anio = valor1;
            trimestre = valor2;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {

                MessageBox.Show("Completar filtros de búsqueda");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
        }
    }

}