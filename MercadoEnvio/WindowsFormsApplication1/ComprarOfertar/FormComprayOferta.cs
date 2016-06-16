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
        private Decimal idUser;
        private GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter;
        private GD1C2016DataSet.publicacionesDataTable publiData;
        private Decimal maxPage = 5;
        private List<String> rubros;
        private Decimal codigo_publicacion;
        private Decimal stock;
        private Decimal precio;



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
            rubros = new List<String>();
            FormSelecRubro seleccionRubro= new FormSelecRubro(rubros,this);
            seleccionRubro.ShowDialog();
        }

        internal void asignarRubros(List<string> rubros)
        {
 
            textRubros.Text = string.Join(", ", rubros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRubros.Text = "";
            textDescripcion.Text = "";
            tablaPubl.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();

            if (textDescripcion.Text == "" && textRubros.Text == "")
            {

                MessageBox.Show("Complete algún filtro de búsqueda");


            }
            else if (textRubros.Text == "")
            {


                publiData = publiAdapter.buscarPublicacionesPorDescripcion(textDescripcion.Text);

                foreach (DataRow row in publiData.Rows)
                {

                    tablaPubl.Rows.Add(row.Field<Decimal>("codigo"),
                                       row.Field<String>("descripcion"),
                                       row.Field<Decimal>("precio"),
                                       row.Field<Decimal>("stock"),
                                       row.Field<String>("tipo"),
                                       row.Field<String>("descripcion1"),
                                       row.Field<String>("nombre_usuario"));
                }

            }
            else if (textDescripcion.Text == "")
            {


                for (int i = 0; i < rubros.Count; i++)
                {


                    publiData = publiAdapter.buscarPublicacionesPorRubro(rubros[i]);

                    foreach (DataRow row in publiData.Rows)
                    {
                        tablaPubl.Rows.Add(row.Field<Decimal>("codigo"),
                                           row.Field<String>("descripcion"),
                                           row.Field<Decimal>("precio"),
                                           row.Field<Decimal>("stock"),
                                           row.Field<String>("tipo"),
                                           row.Field<String>("descripcion1"),
                                           row.Field<String>("nombre_usuario"));

                    }

                }



            }
            else
            {

                for (int i = 0; i < rubros.Count; i++)
                {

                    publiData = publiAdapter.buscarPublicacionesPorRubroYdescripcion(rubros[i], textDescripcion.Text);

                    foreach (DataRow row in publiData.Rows)
                    {
                        tablaPubl.Rows.Add(row.Field<Decimal>("codigo"),
                                           row.Field<String>("descripcion"),
                                           row.Field<Decimal>("precio"),
                                           row.Field<Decimal>("stock"),
                                           row.Field<String>("tipo"),
                                           row.Field<String>("descripcion1"),
                                           row.Field<String>("nombre_usuario"));

                    }


                }

            }

        }

        private void textRubros_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormComprayOferta_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tablaPubl.Rows.Count <= 1)
            {

                MessageBox.Show("No hay publicaciones disponibles según tu búsqueda");

            }
            else if ((Convert.ToString(tablaPubl.CurrentRow.Cells[4].Value)).Equals("Inmediata"))
            {

                codigo_publicacion = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[0].Value);
                stock = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[3].Value);

                Pantalla_Comprar_Inmediata compraInmediata = new Pantalla_Comprar_Inmediata();
                compraInmediata.guardarDatos(idUser, codigo_publicacion,stock,this);
                compraInmediata.ShowDialog();
                

            }
            else
            {

                codigo_publicacion = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[0].Value);
                precio = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[2].Value);

                Pantalla_Subastar subasta = new Pantalla_Subastar();

                subasta.guardarDatos(idUser, codigo_publicacion,precio,this);
                subasta.ShowDialog();
          


            }



        }


        internal void guardaDatos(string user)
        {
            GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable userData = new GD1C2016DataSet.usuariosDataTable();
            userData = userAdapter.consultaID(user);

            idUser = Convert.ToDecimal(userData.Rows[0][0]);
        }
    }
}
