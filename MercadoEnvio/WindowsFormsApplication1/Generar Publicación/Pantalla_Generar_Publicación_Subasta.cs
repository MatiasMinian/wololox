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
    public partial class Pantalla_Generar_Publicación_Subasta : Form
    {
        private Decimal idUser;
        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;
        private GD1C2016DataSetTableAdapters.rubrosTableAdapter rubroAdapter;
        private GD1C2016DataSetTableAdapters.estadosTableAdapter estadoAdapter;
        private GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter;
        private GD1C2016DataSetTableAdapters.publicaciones_rubrosTableAdapter publiRubrosAdapter;
        private List<String> rubros;

        public Pantalla_Generar_Publicación_Subasta()
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
                Decimal costo = Convert.ToDecimal(textBox3.Text);
                String tipo = "Subasta";
                String descripcion = textBox1.Text;
                Decimal stock = numericUpDown1.Value;
                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaVencimiento = dateTimePicker2.Value;
                Decimal valorInicial = Convert.ToDecimal(textBox2.Text);
                String visibilidad = textBox5.Text;
                String estado = comboBox1.Text;

                visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
                rubroAdapter = new GD1C2016DataSetTableAdapters.rubrosTableAdapter();
                estadoAdapter = new GD1C2016DataSetTableAdapters.estadosTableAdapter();
                publiRubrosAdapter = new GD1C2016DataSetTableAdapters.publicaciones_rubrosTableAdapter();
                publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();

                decimal id_visibilidad = Convert.ToDecimal(visiAdapter.consultaIDvisibilidad(visibilidad));               
                decimal id_estado = Convert.ToDecimal(estadoAdapter.consultaIDestado(estado));

              publiAdapter.Insert(idUser, id_estado, id_visibilidad,fechaInicio,fechaVencimiento ,descripcion, stock, valorInicial, tipo);

                for (int i = 0; i < rubros.Count; i++)
                {

                    decimal id_rubro = Convert.ToDecimal(rubroAdapter.consultaIDrubro(rubros[i]));

                    decimal id_publi = Convert.ToDecimal(publiAdapter.consultaIDpublIngresada());

                    publiRubrosAdapter.Insert(id_publi, id_rubro);

                }

                MessageBox.Show("Publicación generada correctamente");

                this.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            comboBox1.ResetText();
            textBox5.ResetText();
            textBox4.ResetText();

        }



        internal void guardarDatos(decimal id)
        {

            idUser = id;


        }

        internal void generarListados()
        {
            //Cargo estados disponibles

            estadoAdapter = new GD1C2016DataSetTableAdapters.estadosTableAdapter();
            GD1C2016DataSet.estadosDataTable estadosData = new GD1C2016DataSet.estadosDataTable();
            estadosData = estadoAdapter.GetData();

           rubroAdapter = new GD1C2016DataSetTableAdapters.rubrosTableAdapter();
            GD1C2016DataSet.rubrosDataTable rubroData = new GD1C2016DataSet.rubrosDataTable();
            rubroData = rubroAdapter.GetData();

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
    }
}
