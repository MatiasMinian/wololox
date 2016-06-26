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
    public partial class Pantalla_Subasta_Borrador : Form
    {
        private Pantalla_Modificacion_Publicaciones pantallaModifP;
        private Decimal idUser;
        private Decimal idPubli;
        private GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter;
        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;
        private GD1C2016DataSetTableAdapters.rubrosTableAdapter rubroAdapter;
        private GD1C2016DataSetTableAdapters.estadosTableAdapter estadoAdapter;
        private GD1C2016DataSetTableAdapters.publicaciones_rubrosTableAdapter publiRubrosAdapter;
        private List<String> rubros;
        private Decimal costo;
        private String tipo;
        private String descripcion;
        private Decimal stock;
        private DateTime fechaInicio;
        private DateTime fechaVencimiento;
        private Decimal precio;
        private String visibilidad;
        private String estado;

        public Pantalla_Subasta_Borrador()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

            var appDate = DateTime.Parse(value);

            dateTimePicker1.Value = appDate;
            dateTimePicker2.MinDate = dateTimePicker1.Value;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == ""
               || comboBox1.Text == "" || textBox5.Text == "" || numericUpDown1.Value == 0
               || !(int.TryParse(textBox2.Text, out number)))
            {

                MessageBox.Show("Hay campos vacíos o inválidos");

            }
            else
            {
                costo = Convert.ToDecimal(textBox3.Text);
                tipo = "Inmediata";
                descripcion = textBox1.Text;
                stock = numericUpDown1.Value;
                fechaInicio = dateTimePicker1.Value;
                fechaVencimiento = dateTimePicker2.Value;
                precio = Convert.ToDecimal(textBox2.Text);
                visibilidad = textBox5.Text;
                estado = comboBox1.Text;

                visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
                rubroAdapter = new GD1C2016DataSetTableAdapters.rubrosTableAdapter();
                estadoAdapter = new GD1C2016DataSetTableAdapters.estadosTableAdapter();
                publiRubrosAdapter = new GD1C2016DataSetTableAdapters.publicaciones_rubrosTableAdapter();

                decimal id_visibilidad = Convert.ToDecimal(visiAdapter.consultaIDvisibilidad(visibilidad));
                decimal id_estado = Convert.ToDecimal(estadoAdapter.consultaIDestado(estado));

                publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();

                publiAdapter.actualizarPublicacion(idPubli, id_estado, id_visibilidad, descripcion, stock, precio, fechaInicio, fechaVencimiento);

                for (int i = 0; i < rubros.Count; i++)
                {

                    decimal id_rubro = Convert.ToDecimal(rubroAdapter.consultaIDrubro(rubros[i]));

                    publiRubrosAdapter.actualizarPubliRubros(idPubli, id_rubro);

         
                }

                MessageBox.Show("Publicación modificada correctamente");

                this.Close();
                pantallaModifP.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            comboBox1.ResetText();
            textBox5.ResetText();

        }  

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla_Seleccion_Visibilidades p = new Pantalla_Seleccion_Visibilidades(idUser);
            p.guardaDatos(this.textBox5,this.textBox3);
            p.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rubros = new List<String>();
            Pantalla_Seleccion_Rubros pantallaRubros = new Pantalla_Seleccion_Rubros();
            pantallaRubros.guardarDatos(textBox4,rubros);
            pantallaRubros.ShowDialog();
        }

        internal void guardarDatos(Pantalla_Modificacion_Publicaciones pmp,Decimal p1, string p2, string p3, string p4, decimal p5, decimal p6, string p7, DateTime dateTime1, DateTime dateTime2)
        {
            pantallaModifP = pmp;
            rubroAdapter = new GD1C2016DataSetTableAdapters.rubrosTableAdapter();
            GD1C2016DataSet.rubrosDataTable rubrosData = new GD1C2016DataSet.rubrosDataTable();
            rubrosData = rubroAdapter.rubrosDePublicacion(p1);

            rubros = new List<String>();

            foreach(DataRow row in rubrosData.Rows){

                rubros.Add(Convert.ToString(row[1]));

            }

            estadoAdapter = new GD1C2016DataSetTableAdapters.estadosTableAdapter();
            GD1C2016DataSet.estadosDataTable estadosData = new GD1C2016DataSet.estadosDataTable();
            estadosData = estadoAdapter.GetData();

            foreach (DataRow row in estadosData.Rows)
            {
                if (row[1].Equals("Finalizada") || row[1].Equals("Pausada"))
                {

                }
                else
                {
                    comboBox1.Items.Add(row[1]);

                }
            }

            idPubli = p1;
            estado = p2;
            visibilidad = p3;
            descripcion = p4;
            stock = p5;
            precio = p6;
            tipo = p7;

            textBox1.Text = descripcion;
            numericUpDown1.Text = Convert.ToString(stock);
            textBox2.Text = Convert.ToString(precio);
            textBox5.Text = visibilidad;
            comboBox1.Text = estado;

            textBox4.Text = string.Join(",",rubros);

             visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
            GD1C2016DataSet.visibilidadesDataTable visiData = new GD1C2016DataSet.visibilidadesDataTable();
            visiData = visiAdapter.GetData();

            foreach (DataRow row in visiData.Rows)
            {
                if (row[1].Equals(visibilidad))
                {

                    textBox3.Text = Convert.ToString(row[5]);

                }

            }

        }
    }
}
