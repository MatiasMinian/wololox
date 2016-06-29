using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class Pantalla_Visibilidad_Principal : Form
    {
        public Pantalla_Visibilidad_Principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AltaVisibilidad altaVisi = new AltaVisibilidad();
            altaVisi.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarVisibilidad eliminarVisi = new EliminarVisibilidad();
            eliminarVisi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifVisibilidad modifVisi = new ModifVisibilidad();
            modifVisi.ShowDialog();
        }
    }
}
