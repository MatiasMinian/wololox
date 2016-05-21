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
    public partial class Pantalla_ABM_Usuario : Form
    {
        public Pantalla_ABM_Usuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Cliente");
            comboBox1.Items.Add("Empresa");

           // comboBox1.SelectedIndex=0;


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Text = comboBox1.Text;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
