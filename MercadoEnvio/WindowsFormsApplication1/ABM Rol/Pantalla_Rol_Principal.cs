using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class Pantalla_Rol_Principal : Form
    {
        public Pantalla_Rol_Principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaCrearRol pantallaCRol = new PantallaCrearRol();
            pantallaCRol.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaEliminarRol pantallaERol = new PantallaEliminarRol();
            pantallaERol.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaModificarRol pantallaMRol = new PantallaModificarRol();
            pantallaMRol.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla_Habilitacion_Rol pantallaHabilitacion = new Pantalla_Habilitacion_Rol();
            pantallaHabilitacion.ShowDialog();
        }
    }
}
