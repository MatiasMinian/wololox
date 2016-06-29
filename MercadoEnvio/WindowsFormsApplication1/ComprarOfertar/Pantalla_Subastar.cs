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
    public partial class Pantalla_Subastar : Form
    {
        private Decimal valorSubasta;
        private Decimal id_User;
        private Decimal codigoPublicacion;
        private FormComprayOferta pantallaCompra;
        private GD1C2016DataSetTableAdapters.ofertasTableAdapter ofertaAdapter;
      

        public Pantalla_Subastar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void guardarDatos(decimal idUser, decimal codigo_publicacion,decimal valorSubastaActual,FormComprayOferta pantallaCO)
        {
            id_User = idUser;
            codigoPublicacion = codigo_publicacion;
            valorSubasta = valorSubastaActual;
            pantallaCompra = pantallaCO;

            textBox1.Text = Convert.ToString(valorSubasta);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

                MessageBox.Show("Ingresa oferta");

            }
            else if (Convert.ToDecimal(textBox2.Text) < Convert.ToDecimal(textBox1.Text))
            {

                MessageBox.Show("El valor de la oferta debe ser mayor al actual");

            }
            else
            {

                var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];
                var appDate = DateTime.Parse(value);

                ofertaAdapter = new GD1C2016DataSetTableAdapters.ofertasTableAdapter();
                ofertaAdapter.Insert(id_User,codigoPublicacion,appDate,Convert.ToDecimal(textBox2.Text));
                MessageBox.Show("Oferta realizada correctamente");
                this.Close();
                pantallaCompra.Close();

            }
        }
    }
}
