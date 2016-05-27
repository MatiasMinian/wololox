using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Pantalla_Datos_Cliente : Form
    {
        public Pantalla_Datos_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Creacion_Usuario pantallaCreacionUser = new Pantalla_Creacion_Usuario();
            this.Close();
            pantallaCreacionUser.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
            textBox11.ResetText();
            comboBox1.ResetText();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MonthCalendar calendarioFechaCreacion = new MonthCalendar();
            calendarioFechaCreacion.Location = new System.Drawing.Point(50, 50);
            calendarioFechaCreacion.Size = new System.Drawing.Size(50, 50);
            calendarioFechaCreacion.Show();
            this.Controls.Add(calendarioFechaCreacion);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MonthCalendar calendarioFechaCreacion = new MonthCalendar();
            calendarioFechaCreacion.Show();
        }

    }
}
