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

        private int pageNumber = 1;
        private int elementoInicial=0;
        private double cantRows;
        private double maxPages;
        private Decimal? idConsulta = null;
        private DateTime? fecha1 = null;
        private DateTime? fecha2 = null;
        private String importe1;
        private String importe2;
        private String detalle;
        private GD1C2016DataSetTableAdapters.facturasTableAdapter factuAdapter;
        private GD1C2016DataSet.facturasDataTable factuData;

        public Pantalla_Consultar_Facturas()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

            var appDate = DateTime.Parse(value);

            dateTimePicker1.Value = appDate;
            dateTimePicker2.Value = appDate;


            
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
            label7.Text = Convert.ToString(1);
            button7.Enabled = false;
            button8.Enabled = false;
            dataGridView1.Rows.Clear();
            label9.Text = Convert.ToString(1);
            checkBox1.Checked = false;

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

            factuAdapter = new GD1C2016DataSetTableAdapters.facturasTableAdapter();
            factuData = new GD1C2016DataSet.facturasDataTable();


            if (dataGridView1.Rows.Count > 0)
            {

                MessageBox.Show("Debes limpiar la grilla antes de seguir con otra búsqueda");


            }
            else
            {


                pageNumber = 1;
                elementoInicial = 0;

                if (!checkBox1.Checked && (textBox2.Text == "" ||
                    textBox1.Text == "") && textBox4.Text == "" && textBox3.Text == "")
                {

                    MessageBox.Show("Ingrese algún tipo de filtro");

                }
                else
                {

                    if (((textBox1.Text != "" && textBox2.Text == "") || (textBox2.Text != "" && textBox1.Text == "")) && (checkBox1.Checked || textBox4.Text != "" || textBox3.Text != ""))
                    {

                        MessageBox.Show("Filtros incorrectos");


                    }
                    else
                    {

                        if (checkBox1.Checked)
                        {
                            fecha1 = dateTimePicker1.Value;
                            fecha2 = dateTimePicker2.Value;
                        }

                        if (textBox3.Text != "")
                        {

                            GD1C2016DataSetTableAdapters.usuariosTableAdapter userAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
                            GD1C2016DataSet.usuariosDataTable userData = new GD1C2016DataSet.usuariosDataTable();

                            idConsulta = (Decimal)userAdapter.consultaID(textBox3.Text);
                            if (idConsulta == null)
                            {
                                MessageBox.Show("No existe ese usuario");
                            }
                        }

                        if (textBox1.Text != "" && textBox2.Text != "")
                        {

                            importe1 = textBox1.Text;
                            importe2 = textBox2.Text;

                        }

                        detalle = textBox4.Text;

                        elementoInicial = (pageNumber - 1) * 6;
                                     
                        cantRows = Convert.ToDouble(factuAdapter.cantidadDeFacturas(idConsulta, fecha1, fecha2, importe1, importe2, detalle));

                        maxPages = Math.Ceiling(cantRows / 6);

                        if (maxPages != 0)
                        {
                            if (maxPages > 1)
                            {
                                button8.Enabled = true;

                            }
                            label9.Text = Convert.ToString(maxPages);

                            factuData = factuAdapter.consultaDeFacturas(idConsulta, fecha1, fecha2, importe1, importe2, detalle, elementoInicial);

                            foreach (DataRow row in factuData.Rows)
                            {

                                dataGridView1.Rows.Add(row.Field<Decimal>("nro_fact"),
                                                       row.Field<String>("descripcion"),
                                                       row.Field<Object>("id_compra"),
                                                       row.Field<DateTime>("fecha"),
                                                       row.Field<Object>("total"));
                            }


                        }
                        else
                        {

                            fecha1 = null;
                            fecha2 = null;
                            importe1 = null;
                            importe2 = null;
                            detalle = null;
                            idConsulta = null;



                        }
                    }
                }

            }
        }
 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {

                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;


                var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

                var appDate = DateTime.Parse(value);

                dateTimePicker2.MaxDate = appDate;
                dateTimePicker1.MaxDate = appDate;




            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            button7.Enabled = true;

            pageNumber++;

            label7.Text = Convert.ToString(pageNumber);

            if (pageNumber == maxPages)
            {

                button8.Enabled = false;

            }


            dataGridView1.Rows.Clear();

            elementoInicial = (pageNumber - 1) * 6;


            factuData = factuAdapter.consultaDeFacturas(idConsulta, fecha1, fecha2, importe1, importe2, detalle, elementoInicial);

            foreach (DataRow row in factuData.Rows)
            {

                dataGridView1.Rows.Add(row.Field<Decimal>("nro_fact"),
                                                       row.Field<String>("descripcion"),
                                                       row.Field<Object>("id_compra"),
                                                       row.Field<DateTime>("fecha"),
                                                       row.Field<Object>("total"));
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            pageNumber--;

            label7.Text = Convert.ToString(pageNumber);

            if (pageNumber == 1)
            {

                button7.Enabled = false;
                button8.Enabled = true;

            }

            dataGridView1.Rows.Clear();

            elementoInicial = (pageNumber - 1) * 6;


                factuData = factuAdapter.consultaDeFacturas(idConsulta, fecha1, fecha2, importe1, importe2, detalle, elementoInicial);

                foreach (DataRow row in factuData.Rows)
                {

                    dataGridView1.Rows.Add(row.Field<Decimal>("nro_fact"),
                                                       row.Field<String>("descripcion"),
                                                       row.Field<Object>("id_compra"),
                                                       row.Field<DateTime>("fecha"),
                                                       row.Field<Object>("total"));
                }
            
        }

    }
}
