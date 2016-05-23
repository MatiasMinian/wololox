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
    }
}
