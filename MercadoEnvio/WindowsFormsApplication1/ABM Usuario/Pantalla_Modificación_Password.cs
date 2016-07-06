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
    public partial class Pantalla_Modificación_Password : Form
    {
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        public Pantalla_Modificación_Password()
        {
            InitializeComponent();
        }

        public Pantalla_Modificación_Password(string usuario)
        {
            InitializeComponent();
            textUser.Text = usuario;
            textUser.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textPass.Text == "" && textPass2.Text == "")
            {

                MessageBox.Show("Ingresa nueva password y verificala");

            }
            else if (textUser.Text == "")
            {
                MessageBox.Show("Ingresa el usuario");
            }
            else if (textPass.Text == "")
            {

                MessageBox.Show("Ingresa nueva password");

            }
            else if (textPass.Text != textPass2.Text)
            {
                MessageBox.Show("Ingresa claves coincidentes");
            }
            else
            {
                userAdapter.CambiarContraseña(textUser.Text, textPass.Text);
                MessageBox.Show("Contraseña cambiada!");
                this.Close();
            }

        }
    }
}
