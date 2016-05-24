using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.Calificar;

namespace WindowsFormsApplication1
{
    public partial class MenuForm : Form
    {

        public MenuForm()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Anchor = AnchorStyles.None;
                    control.Left = (control.Parent.Width + 150 - control.Width) / 2;
                }
            }
        }

        public MenuForm(String usuario) : this()
        {
           labelUsuario.Text = usuario;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void botonCalificar_Click(object sender, EventArgs e)
        {
            Pantalla_Calificacion pCali = new Pantalla_Calificacion();
            pCali.Show();
        }

        private void botonUser_Click(object sender, EventArgs e)
        {
            Pantalla_ABM_Usuario pantallaUser = new Pantalla_ABM_Usuario();
            pantallaUser.Show();
        }
    }
}
