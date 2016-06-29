using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.GD1C2016DataSetTableAdapters;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {
        private GD1C2016DataSetTableAdapters.visibilidadesTableAdapter visiAdapter;

        public AltaVisibilidad()
        {
            InitializeComponent();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "0";
            }
        }

        private void limpiarTexto()
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

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "0";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String descripcion = textBox1.Text;
            decimal costo_publicacion;
            decimal costo_envio;
            decimal valorPorProducto;

             if (!string.IsNullOrWhiteSpace(textBox1.Text))
             {
                 if (decimal.TryParse(textBox2.Text, out costo_publicacion) && !string.IsNullOrWhiteSpace(textBox2.Text))
                 {
                     if (decimal.TryParse(textBox3.Text, out costo_envio))
                    {
                        if (decimal.TryParse(textBox4.Text, out valorPorProducto))
                        {
                                //Enviar a BD

                                visiAdapter = new GD1C2016DataSetTableAdapters.visibilidadesTableAdapter();
                                visiAdapter.CrearVisibilidad(descripcion,costo_envio, valorPorProducto, costo_publicacion);
                               
                                MessageBox.Show("Visibilidad creada correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Ingrese porc por producto numérico");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un costo de envío numérico");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un costo de publicación numérico");
                    }
             }
             else
             {
                 MessageBox.Show("Ingrese una descripción");
             }
 
            }

        private void button3_Click(object sender, EventArgs e)
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
    }

    }

