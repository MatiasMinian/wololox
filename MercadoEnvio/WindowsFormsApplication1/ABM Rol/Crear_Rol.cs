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
    public partial class PantallaCrearRol : Form
    {
        public PantallaCrearRol()
        {
            InitializeComponent();
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Boton_Crear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Ingresa rol a crear");
            }

        }
    }
}
