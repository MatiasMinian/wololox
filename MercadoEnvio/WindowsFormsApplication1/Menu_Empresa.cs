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
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1
{
    public partial class Menu_Empresa : Form
    {
        public Menu_Empresa()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Modificacion_Principal_Cliente pantallaModificacion = new Pantalla_Modificacion_Principal_Cliente();
            pantallaModificacion.ShowDialog();
        }

        private void botonPublic_Click(object sender, EventArgs e)
        {
            Pantalla_Generar_Publicación_Principal pantallaGeneracionPubliPrincipal = new Pantalla_Generar_Publicación_Principal();
            pantallaGeneracionPubliPrincipal.ShowDialog();
        }

    }
}
