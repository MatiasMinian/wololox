using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class Pantalla_Generar_Publicación_Principal : Form
    {
        public Pantalla_Generar_Publicación_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                Pantalla_Generar_Publicación_Compra_Inmediata pantallaCompraInmediata = new Pantalla_Generar_Publicación_Compra_Inmediata();
                pantallaCompraInmediata.ShowDialog();

            }
            else
            {



            }

        }
    }
}
