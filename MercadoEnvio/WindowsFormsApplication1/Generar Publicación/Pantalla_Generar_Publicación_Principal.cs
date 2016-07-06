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
    public partial class Pantalla_Generar_Publicación_Principal : Form
    {

        private Decimal idUser;

        public Pantalla_Generar_Publicación_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (!(radioButton1.Checked) && !(radioButton2.Checked))
            {

                MessageBox.Show("Selecciona tipo de publicación a generar");

            }
            else if (radioButton1.Checked)
            {

                Pantalla_Generar_Publicación_Compra_Inmediata pantallaCompraInmediata = new Pantalla_Generar_Publicación_Compra_Inmediata();
                pantallaCompraInmediata.guardarDatos(idUser);
                pantallaCompraInmediata.generarListados();
                pantallaCompraInmediata.ShowDialog();

            }
            else
            {

                Pantalla_Generar_Publicación_Subasta pantallaSubasta = new Pantalla_Generar_Publicación_Subasta();
                pantallaSubasta.guardarDatos(idUser);
                pantallaSubasta.generarListados();
                pantallaSubasta.ShowDialog();
                

            }

        }

        internal void guardarDatos(string user)
        {
            GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable userData = new GD1C2016DataSet.usuariosDataTable();
            idUser = (Decimal) userAdapter.consultaID(user);

        }
    }
}
