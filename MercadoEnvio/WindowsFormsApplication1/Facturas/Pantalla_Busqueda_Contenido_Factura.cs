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
    public partial class Pantalla_Busqueda_Contenido_Factura : Form
    {
        public Pantalla_Busqueda_Contenido_Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {


                MessageBox.Show("Ingrese algún contenido");
            }
        }
    }

}