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
    public partial class PantallaEliminarRol : Form
    {
        public PantallaEliminarRol()
        {
            InitializeComponent();
        }

        private void Boton_Cancelar_Eliminar_Rol_Click(object sender, EventArgs e)
        {
            Pantalla_ABM_Rol pantallaRol = new Pantalla_ABM_Rol();
            this.Close();
            pantallaRol.Show();
        }

        private void Boton_Eliminar_Rol_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Ingresa rol a eliminar");
            }
        }
    }

}
