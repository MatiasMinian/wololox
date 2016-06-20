using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class Pantalla_Listado_Estadistico_Principal : Form
    {


        public Pantalla_Listado_Estadistico_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Pantalla_Vendedores_Mayor_Cantidad_Productos_No_Vendidos pantalla1 = new Pantalla_Vendedores_Mayor_Cantidad_Productos_No_Vendidos();
            pantalla1.guardarDatos((int)this.numericUpDown2.Value, Convert.ToString(this.numericUpDown1.Value));
            pantalla1.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_Vendedores_Con_Mayor_Cantidad_De_Facturas pantalla2 = new Pantalla_Vendedores_Con_Mayor_Cantidad_De_Facturas();
            pantalla2.guardarDatos(Convert.ToString(this.numericUpDown1.Value), (int)this.numericUpDown2.Value);
            pantalla2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla_Clientes_Mayor_Cantidad_Productos_Comprados pantalla3 = new Pantalla_Clientes_Mayor_Cantidad_Productos_Comprados();
            pantalla3.guardarDatos(Convert.ToString(this.numericUpDown1.Value), (int)this.numericUpDown2.Value);
            pantalla3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla_Vendedores_Mayor_Monto_Facturado pantalla4 = new Pantalla_Vendedores_Mayor_Monto_Facturado();
            pantalla4.guardarDatos(Convert.ToString(this.numericUpDown1.Value), (int)this.numericUpDown2.Value);
            pantalla4.ShowDialog();
        }
    }
}
