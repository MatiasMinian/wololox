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

        public void matchearUsuario(String usuario)
        {

            label2.Text = usuario;

        }

        private void botonRol_Click(object sender, EventArgs e)
        {

            Pantalla_ABM_Rol pantallaRol = new Pantalla_ABM_Rol();
            pantallaRol.ShowDialog();

        }

        private void botonUser_Click(object sender, EventArgs e)
        {
            Pantalla_Usuario_Principal pantallaUsuarioPrincipal = new Pantalla_Usuario_Principal();
            pantallaUsuarioPrincipal.ShowDialog();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonVisibilidad_Click(object sender, EventArgs e)
        {

        }

        private void crearRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaCrearRol pantallCrearRol = new PantallaCrearRol();
            pantallCrearRol.ShowDialog();
        }

        private void modificarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaModificarRol pantallaModRol = new PantallaModificarRol();
            pantallaModRol.ShowDialog();
        }

        private void eliminarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaEliminarRol pantallaReliminarRol = new PantallaEliminarRol();
            pantallaReliminarRol.ShowDialog();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_Creacion_Usuario pantallaCreacionUser = new Pantalla_Creacion_Usuario();
            pantallaCreacionUser.ShowDialog();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_Modificacion_Principal_Admins pantallaModificacion = new Pantalla_Modificacion_Principal_Admins();
            pantallaModificacion.ShowDialog();
        }


    }
}
