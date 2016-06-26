using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class EditarDatosVisibilidad : Form
    {
        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;
        private decimal id;

        public EditarDatosVisibilidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> funcion = null;

            funcion = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        funcion(control.Controls);
            };

            funcion(Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {   String descripcion = textBox1.Text;
                decimal costoPubli;
                decimal valorPorProducto;
                decimal valorPorEnvio;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (decimal.TryParse(textBox3.Text, out costoPubli))
                        {
                            if (decimal.TryParse(textBox4.Text, out valorPorProducto))
                            {
                                if (decimal.TryParse(textBox5.Text, out valorPorEnvio))
                                {
                                    //Enviar a BD

                                    visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
                                    visiAdapter.ModificarVisibilidad(id, descripcion, valorPorEnvio, valorPorProducto, costoPubli);
                             
                                    MessageBox.Show("Visibilidad modificada correctamente");
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese una comisión por envío numérica");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese una comisión por producto numérica");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese una comisión por tipo de publicación numérica");
                        }
                    }
                                 
                else
                {
                    MessageBox.Show("Ingrese una descripción");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "0";
            }
            
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "0";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "0";
            }
        }

        internal void cargarDatos(object codigo,object descripcionActual, object costoEnvioActual, object costoProdActual, object costoPubli)
        {
            id = Convert.ToDecimal(codigo);
            textBox1.Text = Convert.ToString(descripcionActual);
            textBox3.Text = Convert.ToString(costoPubli);
            textBox4.Text = Convert.ToString(costoProdActual);
            textBox5.Text = Convert.ToString(costoEnvioActual);
        }
    }
}
