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
    public partial class Pantalla_Calificacion_Principal : Form
    {
        private GD1C2016DataSetTableAdapters.calificacionesTableAdapter caliAdapter;
        private GD1C2016DataSet.calificacionesDataTable caliData;
        private Decimal id;

        public Pantalla_Calificacion_Principal()
        {
            InitializeComponent();

            }

        public void generarListado(String user){

             GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable userData = new GD1C2016DataSet.usuariosDataTable();

            userData = userAdapter.consultaID(user);

            id = Convert.ToDecimal(userData.Rows[0][0]);


            caliAdapter = new GD1C2016DataSetTableAdapters.calificacionesTableAdapter();
            caliData = caliAdapter.buscarPublicacionesAcalificar(id);

            foreach (DataRow row in caliData.Rows)
            {

                dataGridView1.Rows.Add(row.Field<Decimal>("id_compra"),
                                       row.Field<String>("descripcion"),
                                       row.Field<String>("tipo"),
                                       row.Field<Decimal>("precio"),
                                       row.Field<Decimal>("cantidad"),
                                       row.Field<String>("nombre_usuario"));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla_Últimas_5_Compras_Calificadas ultimas5compras = new Pantalla_Últimas_5_Compras_Calificadas();
            ultimas5compras.generarListado(id);
            ultimas5compras.ShowDialog();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count <= 1)
            {

                MessageBox.Show("No tienes compras pendientes de calificación");

            }
            else
            {
                Pantalla_Calificar_Publicacion pantallaCalificar = new Pantalla_Calificar_Publicacion();
                pantallaCalificar.guardarCompraSeleccionada(Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value),this);
                pantallaCalificar.ShowDialog();


            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_Compras_Segun_Estrellas pantallaCSestrellas = new Pantalla_Compras_Segun_Estrellas();
            pantallaCSestrellas.generarListado(id);
            pantallaCSestrellas.ShowDialog();



        }
    }
}
