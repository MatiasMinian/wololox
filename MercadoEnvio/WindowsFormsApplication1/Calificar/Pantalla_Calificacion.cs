using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Calificar
{
    public partial class Pantalla_Calificacion : Form
    {
        public Pantalla_Calificacion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla_historial pantallaHistorial = new Pantalla_historial();
            pantallaHistorial.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Calificar_Publicacion pantallaCalificar = new Pantalla_Calificar_Publicacion();
            pantallaCalificar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
