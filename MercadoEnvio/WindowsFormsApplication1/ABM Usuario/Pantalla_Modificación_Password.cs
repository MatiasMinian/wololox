using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Pantalla_Modificación_Password : Form
    {
        public Pantalla_Modificación_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text == "")
            {

                MessageBox.Show("Ingresa nueva password y verificala");

            }
            else if (textBox3.Text=="")
            {
                MessageBox.Show("Ingresa el usuario");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("Ingresa nueva password");

            }
            else


                MessageBox.Show("Ingresa verificación de password");

        }
    }
}
