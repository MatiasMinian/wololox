using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Facturas
{
    public partial class Pantalla_Consultar_Facturas : Form
    {

        private Decimal id;

        public Pantalla_Consultar_Facturas()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            MonthCalendar calendario = new MonthCalendar();

            dateTimePicker1.MaxDate = calendario.TodayDate;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Contenido_Factura pantallaBusquedaContenido = new Pantalla_Busqueda_Contenido_Factura();
            pantallaBusquedaContenido.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            String consulta;
            String conexion = Convert.ToString(System.Configuration.ConfigurationManager.ConnectionStrings[1]);
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();


            consulta = "SELECT facturas.nro_fact,facturas.fecha,facturas.total,item_factura.descripcion,item_factura.cantidad" +
            " FROM WOLOLOX.facturas" +
            " INNER JOIN WOLOLOX.item_factura ON facturas.nro_fact = item_factura.nro_fact"+
            " INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion "+
            " INNER JOIN WOLOLOX.usuarios ON publicaciones.id_usuario = usuarios.id_usuario"+
            " WHERE usuarios.id_usuario = "+id;


            if (!checkBox1.Checked && textBox2.Text == "" &&
                textBox3.Text == "" && textBox4.Text == "" && textBox1.Text == "")
            {

                MessageBox.Show("Ingrese algún tipo de filtro");

            }
            else
            {
                if (textBox3.Text != "")
                {

                    GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
                    GD1C2016DataSet.usuariosDataTable userData = new GD1C2016DataSet.usuariosDataTable();

                    userData = userAdapter.consultaID(textBox3.Text);
                    if (userData.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe ese usuario");
                       
                    }
                    else
                    {
                        id = Convert.ToDecimal(userData[0][0]);

                    }
                }


                    if (checkBox1.Checked)
                    {

                        consulta = consulta + " AND facturas.fecha BETWEEN " + Convert.ToDateTime(dateTimePicker1.Value) + " AND " + Convert.ToDateTime(dateTimePicker2.Value);

                    }

                    if (textBox1.Text != "" && textBox2.Text != "")
                    {

                        consulta = consulta + " AND facturas.total BETWEEN " + Convert.ToDecimal(textBox1.Text) + " AND " + Convert.ToDecimal(textBox2.Text);


                    }


                    if (textBox4.Text != "")
                    {

                        consulta = consulta +" AND item_factura.descripcion = LIKE %"+Convert.ToString(textBox4.Text)+"%";

                    }

                }

                SqlCommand cmd = new SqlCommand(consulta, cnn);
                SqlDataReader reader = cmd.ExecuteReader();

                foreach (DataRow row in reader)
                {

                    dataGridView1.Rows.Add(row.Field<Decimal>("nro_fact"),
                                           row.Field<Decimal>("descripcion"),
                                           row.Field<Decimal>("fecha"),
                                           row.Field<Decimal>("cantidad"),
                                           row.Field<Decimal>("total"));


                }
            }


        internal void guardaDatos(string user)
        {
            GD1C2016DataSetTableAdapters.usuariosTableAdapter usuAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable usuData = new GD1C2016DataSet.usuariosDataTable();
            usuData = usuAdapter.consultaID(user);
            id = Convert.ToDecimal(usuData[0][0]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {

                dateTimePicker1.Enabled = true;


            }
        }
    }
}
