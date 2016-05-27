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
    public partial class Pantalla_Modificacion_Usuario : Form
    {
        public Pantalla_Modificacion_Usuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla_Usuario_Principal pantallaPrincipal = new Pantalla_Usuario_Principal();
            this.Close();
            pantallaPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
