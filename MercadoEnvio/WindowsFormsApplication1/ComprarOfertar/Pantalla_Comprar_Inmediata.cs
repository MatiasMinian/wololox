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
    public partial class Pantalla_Comprar_Inmediata : Form
    {
        private Decimal idUser;
        private Decimal codigo_publicacion;
        private Decimal stock;
        private GD1C2016DataSetTableAdapters.comprasTableAdapter compraAdapter;
        private FormComprayOferta pantallaCompra;
    
        public Pantalla_Comprar_Inmediata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void guardarDatos(decimal id, decimal codigo_publi,decimal stockPubli,FormComprayOferta pantallaCompraYoferta)
        {
            idUser = id;
            codigo_publicacion = codigo_publi;
            stock = stockPubli;
            textBox1.Text = Convert.ToString(stock);
            numericUpDown1.Maximum = stock;
            pantallaCompra = pantallaCompraYoferta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MonthCalendar calendario = new MonthCalendar();
            DateTime fechaActual = calendario.TodayDate;
            compraAdapter = new GD1C2016DataSetTableAdapters.comprasTableAdapter();
            compraAdapter.Insert(numericUpDown1.Value, fechaActual, codigo_publicacion, idUser);

            MessageBox.Show("Compra realizada correctamente");
            this.Close();
            pantallaCompra.Close();


        }
    }
}
