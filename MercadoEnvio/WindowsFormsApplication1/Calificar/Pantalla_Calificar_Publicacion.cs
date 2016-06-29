using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Calificar
{
    public partial class Pantalla_Calificar_Publicacion : Form
    {

        private Decimal id_compra;
        private Decimal estrellas;
        private String descripcion;
        private GD1C2016DataSetTableAdapters.calificacionesTableAdapter caliAdapter;
        private Pantalla_Calificacion_Principal pantallaPrincipal;

        public Pantalla_Calificar_Publicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void guardarCompraSeleccionada(Decimal idcompra,Pantalla_Calificacion_Principal p)
        {


            id_compra = idcompra;
            pantallaPrincipal = p;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese alguna opinion del vendedor");

            }
            
            if(radioButton1.Checked)
            {
                estrellas = 1;

            }
            else if (radioButton2.Checked)
            {
                estrellas = 2;

            }
            else if (radioButton3.Checked)
            {
                estrellas = 3;

            }
            else if (radioButton4.Checked)
            {
                estrellas = 4;
            }
            else
            {
                estrellas = 5;
            }

            descripcion = textBox1.Text;

            caliAdapter = new GD1C2016DataSetTableAdapters.calificacionesTableAdapter();
            caliAdapter.Insert(id_compra, estrellas, descripcion);

            MessageBox.Show("Calificación exitosa");
            this.Close();
            pantallaPrincipal.Close();

        }
    }
}
