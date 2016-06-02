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
    public partial class Pantalla_Elección_Usuario_A_Modificar_Password : Form
    {
        public Pantalla_Elección_Usuario_A_Modificar_Password()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Cliente_A_Modificar_Password pantallaClienteAmodificarPass = new Pantalla_Busqueda_Cliente_A_Modificar_Password();
            pantallaClienteAmodificarPass.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Empresa_A_Modificar_Password pantallaEmpresaAmodificarPass = new Pantalla_Busqueda_Empresa_A_Modificar_Password();
            pantallaEmpresaAmodificarPass.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
