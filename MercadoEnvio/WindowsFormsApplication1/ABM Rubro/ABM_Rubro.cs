using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rubro
{
    public partial class Pantalla_Rubro : Form
    {
        public Pantalla_Rubro()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox listadoDeRubros = new System.Windows.Forms.ListBox();
            listadoDeRubros.FormattingEnabled = true;
            listadoDeRubros.Location = new System.Drawing.Point(6, 65);
            listadoDeRubros.Name = "listBox1";
            listadoDeRubros.Size = new System.Drawing.Size(635, 134);
            listadoDeRubros.TabIndex = 4;
            listadoDeRubros.Items.Add("Deportes");
            listadoDeRubros.Items.Add("Computación");
            listadoDeRubros.Items.Add("Electrodomésticos");
            listadoDeRubros.Items.Add("Casa");
            groupBox1.Controls.Add(listadoDeRubros);

        }

        }
    }
