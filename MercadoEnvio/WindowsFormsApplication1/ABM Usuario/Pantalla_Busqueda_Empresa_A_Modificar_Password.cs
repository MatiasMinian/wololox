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
    public partial class Pantalla_Busqueda_Empresa_A_Modificar_Password : Form
    {
        public Pantalla_Busqueda_Empresa_A_Modificar_Password()
        {
            InitializeComponent();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {

                Pantalla_Modificación_Password pantallaModificacionPass = new Pantalla_Modificación_Password();
                pantallaModificacionPass.ShowDialog();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {

                MessageBox.Show("Complete algún campo de búsqueda");

            }

        }
    }
}
