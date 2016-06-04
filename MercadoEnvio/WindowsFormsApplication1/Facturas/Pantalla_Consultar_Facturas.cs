using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Facturas
{
    public partial class Pantalla_Consultar_Facturas : Form
    {
        public Pantalla_Consultar_Facturas()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Contenido_Factura pantallaBusquedaContenido = new Pantalla_Busqueda_Contenido_Factura();
            pantallaBusquedaContenido.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text == "" &&
                textBox3.Text == "" && textBox4.Text == "")
            {

                MessageBox.Show("Ingrese algún tipo de filtro");

            }

        }
    }
}
