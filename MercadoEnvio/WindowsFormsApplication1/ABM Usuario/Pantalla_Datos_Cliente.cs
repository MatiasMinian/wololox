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
    public partial class Pantalla_Datos_Cliente : Form
    {
        public Pantalla_Datos_Cliente()
        {
            InitializeComponent();

            //Formato fecha

            textBox12.Format = DateTimePickerFormat.Custom;
            textBox12.CustomFormat = "dd/MM/yyyy";

            textBox13.Format = DateTimePickerFormat.Custom;
            textBox13.CustomFormat = "dd/MM/yyyy";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
            textBox11.ResetText();
            comboBox1.ResetText();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
               || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == ""
               || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || comboBox1.Text == "")
            {

                MessageBox.Show("Complete campos vacíos");

            }

        }

 
    }

}