using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class FormComprayOferta : Form
    {
        public FormComprayOferta()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            List<String> rubros = new List<String>();
            FormSelecRubro seleccionRubro= new FormSelecRubro(rubros,this);
            seleccionRubro.ShowDialog();
        }

        internal void asignarRubros(List<string> rubros)
        {
            textRubros.Text = string.Join(", ", rubros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRubros.Text = "RUBROS";
            textDescripcion.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaPubl.Rows.Add("Producto1", 150);
            tablaPubl.Rows.Add("Producto2", 50);
            tablaPubl.Rows.Add("Producto3", 250);
            tablaPubl.Rows.Add("Producto4", 10);
            tablaPubl.Rows.Add("Producto5", 850);
        }

    }
}
