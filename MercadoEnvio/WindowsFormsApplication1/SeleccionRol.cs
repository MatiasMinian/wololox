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
    public partial class SeleccionRol : Form
    {

        public SeleccionRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Funcionalidades pantallaFuncio = new Pantalla_Funcionalidades(comboBox1.Text);
            pantallaFuncio.ShowDialog();




        }





        
    }
}
