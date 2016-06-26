using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class Pantalla_Modificación_Estado_Publicación : Form
    {
        private Decimal id_Publicacion;
        private Decimal id_estado;
        private Pantalla_Modificacion_Publicaciones pantallaModifP;

        public Pantalla_Modificación_Estado_Publicación()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Seleccione nuevo estado");

            }
            else
            {

                GD1C2016DataSetTableAdapters.estadosTableAdapter estadoAdapter = new GD1C2016DataSetTableAdapters.estadosTableAdapter();
                id_estado = Convert.ToDecimal(estadoAdapter.consultaIDestado(comboBox1.Text));
                GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();

                publiAdapter.actualizarEstadoPublicacion(id_Publicacion, id_estado);

                MessageBox.Show("Estado modificado correctamente");

                this.Close();
                pantallaModifP.Close();

            }
        }

        internal void guardarDatos(Pantalla_Modificacion_Publicaciones pmp,Decimal idPubli, String estadoPubli)
        {
            pantallaModifP = pmp;

            id_Publicacion = idPubli;

            if (estadoPubli.Equals("Activa"))
            {

                comboBox1.Items.Add("Pausada");
                comboBox1.Items.Add("Finalizada");


            }
            else
            {

                comboBox1.Items.Add("Activa");
                comboBox1.Items.Add("Finalizada");


            }



        }
    }
}
