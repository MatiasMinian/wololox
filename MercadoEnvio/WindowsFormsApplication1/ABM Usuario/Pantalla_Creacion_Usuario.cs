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
    public partial class Pantalla_Creacion_Usuario : Form
    {
        public Pantalla_Creacion_Usuario()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cliente");
            comboBox1.Items.Add("Empresa");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Text = comboBox1.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            comboBox1.ResetText();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Ingresa usuario,contraseña y rol");

            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Ingresa usuario y contraseña");

            }
            else if (textBox1.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Ingresa usuario y rol");

            }
            else if (textBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Ingresa contraseña y rol");

            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa usuario");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Ingresa contraseña");

            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecciona rol");

            }
            else if (comboBox1.Text == "Cliente")
            {
                Pantalla_Datos_Cliente pantallaDatosCliente = new Pantalla_Datos_Cliente();
                pantallaDatosCliente.ShowDialog();

            }
            else
            {
                Pantalla_Datos_Empresa pantallaDatosEmpresa = new Pantalla_Datos_Empresa();
                pantallaDatosEmpresa.ShowDialog();

            }

        }

    }

}