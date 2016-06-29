using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class FormComprayOferta : Form
    {

        private int pageNumber = 1;
        private int elementoInicial;
        private double cantRows =0;
        private Decimal idUser;
        private double maxPages;
        private GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter;
        private GD1C2016DataSet.publicacionesDataTable publiData;
        private List<String> rubros;
        private Decimal codigo_publicacion;
        private Decimal stock;
        private Decimal precio;
        private int rubrosLeidos = 0;


        public FormComprayOferta()
        {
            InitializeComponent();
            label3.Text = Convert.ToString(pageNumber);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rubros = new List<String>();
            FormSelecRubro seleccionRubro = new FormSelecRubro(rubros, this);
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
            pageNumber = 1;
            label3.Text = Convert.ToString(pageNumber);
            tablaPubl.Rows.Clear();
            button5.Enabled = false;
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tablaPubl.Rows.Count == 0)
            {

                MessageBox.Show("No hay publicaciones disponibles según tu búsqueda");

            }
            else if ((Convert.ToString(tablaPubl.CurrentRow.Cells[4].Value)).Equals("Inmediata"))
            {

                codigo_publicacion = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[0].Value);
                stock = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[3].Value);
                precio = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[2].Value);

                Pantalla_Comprar_Inmediata compraInmediata = new Pantalla_Comprar_Inmediata();
                compraInmediata.guardarDatos(idUser, codigo_publicacion, stock, this,precio);
                compraInmediata.ShowDialog();


            }
            else
            {

                codigo_publicacion = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[0].Value);
                precio = Convert.ToDecimal(tablaPubl.CurrentRow.Cells[2].Value);

                Pantalla_Subastar subasta = new Pantalla_Subastar();

                subasta.guardarDatos(idUser, codigo_publicacion, precio, this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tablaPubl.Rows.Count > 0)
            {

                MessageBox.Show("Debes limpiar la grilla antes de seguir con otra búsqueda");

            }
            else
            {

                pageNumber = 1;
                elementoInicial = 0;


                button5.Enabled = true;

                label3.Text = Convert.ToString(pageNumber);

                publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();
                publiData = new GD1C2016DataSet.publicacionesDataTable();

                if (textDescripcion.Text == "" && textRubros.Text == "")
                {

                    MessageBox.Show("Complete algún filtro de búsqueda");


                }
                else if (textRubros.Text == "")
                {


                    elementoInicial = (pageNumber - 1) * 5;

                    publiData = publiAdapter.buscarPublicacionesPorDescripcion(textDescripcion.Text, idUser, elementoInicial);

                    cantRows = (int)publiAdapter.cantidadPublicacionesPorDescripcion(textDescripcion.Text, idUser);

                    maxPages = Math.Ceiling(cantRows / 5);

                    label5.Text = Convert.ToString(maxPages);

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

                    elementoInicial = (pageNumber - 1) * 5;

                    for (int i = 0; i < rubros.Count; i++)
                    {

                        cantRows = cantRows + (int)publiAdapter.cantidadPublicacionesPorRubros(rubros[i], idUser);
                    }

                    maxPages = Math.Ceiling(cantRows / 5);

                    label5.Text = Convert.ToString(maxPages);


                    publiData = publiAdapter.buscarPublicacionesPorRubros(rubros[rubrosLeidos], idUser, elementoInicial);

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

                    rubrosLeidos++;

                }
                else
                {


                    elementoInicial = (pageNumber - 1) * 5;

                    publiData = publiAdapter.buscarPublicacionesPorRubrosYdescripcion(rubros[rubrosLeidos], textDescripcion.Text, idUser, elementoInicial);

                    cantRows = (int)publiAdapter.cantidadPublicacionesPorRubrosYdescripcion(rubros[rubrosLeidos], textDescripcion.Text, idUser);

                    maxPages = Math.Ceiling(cantRows / 5);

                    label5.Text = Convert.ToString(maxPages);

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
        private void button5_Click(object sender, EventArgs e)
        {
            
                pageNumber++;

                label3.Text = Convert.ToString(pageNumber);

                button4.Enabled = true;

                tablaPubl.Rows.Clear();

                elementoInicial = (pageNumber - 1) * 5;


                if (textRubros.Text == "")
                {

                    publiData = publiAdapter.buscarPublicacionesPorDescripcion(textDescripcion.Text, idUser, elementoInicial);

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

                    publiData = publiAdapter.buscarPublicacionesPorRubros(textRubros.Text, idUser, elementoInicial);


                }
                else
                {

                    publiData = publiAdapter.buscarPublicacionesPorRubrosYdescripcion(textRubros.Text, textDescripcion.Text, idUser, elementoInicial);


                }
                if (pageNumber == maxPages)
                {

                    button5.Enabled = false;

                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pageNumber--;

            label3.Text = Convert.ToString(pageNumber);

            button5.Enabled = true;

            if (pageNumber == 1)
            {

                button4.Enabled = false;
                button5.Enabled = true;
            }

            tablaPubl.Rows.Clear();

            elementoInicial = (pageNumber - 1) * 5;

            publiData = publiAdapter.buscarPublicacionesPorDescripcion(textDescripcion.Text, idUser, elementoInicial);


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


