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
    public partial class Pantalla_Usuario_Principal : Form
    {
        public Pantalla_Usuario_Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Pantalla_Creacion_Usuario pantallaCreacionUser = new Pantalla_Creacion_Usuario();
            pantallaCreacionUser.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonModif_Click(object sender, EventArgs e)
        {
            Pantalla_Modif_Eleccion_Rol pantallaModificacion = new Pantalla_Modif_Eleccion_Rol(0);
            pantallaModificacion.ShowDialog();
        }

        private void botonElim_Click(object sender, EventArgs e)
        {
            Pantalla_Modif_Eleccion_Rol pantallaModificacion = new Pantalla_Modif_Eleccion_Rol(1);
            pantallaModificacion.ShowDialog();
        }

        private void botonHabilitar_Click(object sender, EventArgs e)
        {
            Pantalla_Modif_Eleccion_Rol pantallaModificacion = new Pantalla_Modif_Eleccion_Rol(2);
            pantallaModificacion.ShowDialog();
        }

        private void botonPass_Click(object sender, EventArgs e)
        {
            Pantalla_Modificación_Password pantallaModificacion = new Pantalla_Modificación_Password();
            pantallaModificacion.ShowDialog();
        }

    
    }
}
