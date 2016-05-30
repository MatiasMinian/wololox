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
    public partial class PantallaModificarRol : Form
    {
        public PantallaModificarRol()
        {
            InitializeComponent();
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            if (Modificar_Rol_Desplegable_Roles.Text == "")
            {

                MessageBox.Show("Ingresa rol a modificar");
            }
        }
    }
}
