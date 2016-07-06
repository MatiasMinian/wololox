using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1.ABM_Usuario
{

    public partial class Pantalla_Modificacion_Principal_Cliente : Form
    {

        private Decimal id;

        public Pantalla_Modificacion_Principal_Cliente()
        {
            InitializeComponent();
        }

        internal void guardarDatos(String user){

            GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable userData = new GD1C2016DataSet.usuariosDataTable();

            id = (Decimal) userAdapter.consultaID(user);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Pantalla_Modificacion_Datos_Cliente pantallaModiDatosCliente = new Pantalla_Modificacion_Datos_Cliente();
           // pantallaModiDatosCliente.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_Modificación_Password pantallaModificacionPassword = new Pantalla_Modificación_Password();
            pantallaModificacionPassword.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Pantalla_Modificacion_Publicaciones pantallaModificacionPubli = new Pantalla_Modificacion_Publicaciones();
            pantallaModificacionPubli.guardarDatos(id);
            pantallaModificacionPubli.generarListado();
            pantallaModificacionPubli.ShowDialog();

        }
    }
}
