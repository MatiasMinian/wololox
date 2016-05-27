using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Usuario;

namespace WindowsFormsApplication1
{
    public partial class Menu_Administradores : Form
    {
        public Menu_Administradores()
        {
            InitializeComponent();

        }

        private void botonRol_Click(object sender, EventArgs e)
        {

            Pantalla_ABM_Rol pantallaRol = new Pantalla_ABM_Rol();
            pantallaRol.Show();

        }

        private void botonUser_Click(object sender, EventArgs e)
        {
            Pantalla_Usuario_Principal pantallaUsuarioPrincipal = new Pantalla_Usuario_Principal();
            pantallaUsuarioPrincipal.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonVisibilidad_Click(object sender, EventArgs e)
        {

        }


    }
}
