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
    public partial class Pantalla_Modificacion_Principal_Empresa : Form
    {
        public Pantalla_Modificacion_Principal_Empresa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Modificacion_Datos_Empresa pantallaModiDatosEmpresa = new Pantalla_Modificacion_Datos_Empresa();
            pantallaModiDatosEmpresa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_Modificación_Password pantallaModificacionPassword = new Pantalla_Modificación_Password();
            pantallaModificacionPassword.ShowDialog();
        }
    }
}
