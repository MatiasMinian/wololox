using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class PantallaModificarRol : Form
    {
        public PantallaModificarRol()
        {
            InitializeComponent();
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" && textBox1.Text == "" && listBox1.SelectedItems.Count == 0)
            {

                MessageBox.Show("Ingresa rol ,nombre y selecciona funcionalidades a modificar");

            }
            else if (comboBox1.Text == "" && textBox1.Text == "")
            {

                MessageBox.Show("Ingresa rol y nombre a modificar");

            }
            else if (comboBox1.Text == "" && listBox1.SelectedItems.Count == 0)
            {

                MessageBox.Show("Ingresa rol y selecciona funcionalidades a modificar");

            }
            else if (textBox1.Text == "" && listBox1.SelectedItems.Count == 0)
            {

                MessageBox.Show("Ingresa nombre y selecciona funcionalidades a modificar");

            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("Ingresa nombre a modificar");

            }else if (comboBox1.Text == ""){

                MessageBox.Show("Ingresa rol a modificar");

            }else{

                MessageBox.Show("Selecciona funcionalidades a modificar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Selecciona funcionalidad a agregar");

            }
            else
            {

                listBox1.Items.Add(comboBox2.SelectedItem);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count == 0)
            {

                MessageBox.Show("Selecciona funcionalidad a quitar");

            }
            else
            {

                listBox1.Items.Remove(listBox1.SelectedItem);

            }

        }
    }

}