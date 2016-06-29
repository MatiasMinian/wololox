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
    public partial class Pantalla_Modificacion_Publicaciones : Form
    {
        private Decimal id;


        public Pantalla_Modificacion_Publicaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[1].Value.Equals("Borrador")){

                MessageBox.Show("Finalice de completar los datos de la publicacion para poder modificar su estado");

            }else{


            Pantalla_Modificación_Estado_Publicación pantallaModifEstado = new Pantalla_Modificación_Estado_Publicación();
            pantallaModifEstado.guardarDatos(this,Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
            pantallaModifEstado.ShowDialog();
            

            }
        }


        internal void guardarDatos(decimal idUser)
        {
            this.id = idUser;
        }

        internal void generarListado()
        {

            GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();
            GD1C2016DataSet.publicacionesDataTable publiData = new GD1C2016DataSet.publicacionesDataTable();

            publiData = publiAdapter.publicacionesParaModificacion(id);

            foreach (DataRow row in publiData.Rows)
            {

                dataGridView1.Rows.Add(row.Field<Decimal>("codigo"),
                                       row.Field<String>("descripcion_estado"),
                                       row.Field<String>("descripcion"),
                                       row.Field<String>("descripcion1"),
                                       row.Field<Decimal>("stock"),
                                       row.Field<Decimal>("precio"),
                                       row.Field<String>("tipo"),
                                       row.Field<DateTime>("fecha_inicio"),
                                       row.Field<DateTime>("fecha_vencimiento"));


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells[1].Value.Equals("Borrador"))
            {

                if(dataGridView1.CurrentRow.Cells[6].Value.Equals("Inmediata")){
                Pantalla_Compra_Borrador pantallaCompraBorrador = new Pantalla_Compra_Borrador();
                pantallaCompraBorrador.guardarDatos(this,
                                                    Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value),
                                                    Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value),
                                                    Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value),
                                                    Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value),
                                                    Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value));
                pantallaCompraBorrador.ShowDialog();
                }else{

                Pantalla_Subasta_Borrador pantallaSubastaBorrador = new Pantalla_Subasta_Borrador();
                pantallaSubastaBorrador.guardarDatos(this,
                                                    Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value),
                                                    Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value),
                                                    Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value),
                                                    Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value),
                                                    Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value),
                                                    Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value));
                pantallaSubastaBorrador.ShowDialog();
                }


            }
            else
            {


                MessageBox.Show("El estado de la publicación debe ser borrador");

            }


        }
    }
}
