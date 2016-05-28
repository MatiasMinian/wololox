using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void botonLimpieza_Click(object sender, EventArgs e)
        {
            textoPass.Text = "";
            textoUser.Text = "";
        }

        private void botonIngreso_Click(object sender, EventArgs e)
        {

            if (textoUser.Text == "" && textoPass.Text == "")
            {

                MessageBox.Show("Ingresa usuario y contraseña");

            }

            else if (textoUser.Text == "")
            {

                MessageBox.Show("Ingresa usuario");

            }
            else if (textoPass.Text == "")
            {

                MessageBox.Show("Ingresa contraseña");

            }

            else
            {

                Menu_Administradores menu = new Menu_Administradores();
                this.Hide();
                menu.ShowDialog();
                this.Close();
                this.Dispose();

            }

        }

    }

}