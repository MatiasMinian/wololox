﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class Pantalla_Vendedores_Mayor_Monto_Facturado : Form
    {
        public Pantalla_Vendedores_Mayor_Monto_Facturado()
        {
            InitializeComponent();
        }

        public void guardaParametrosParaBusqueda(decimal valor1, decimal valor2)
        {
            decimal anio;
            decimal trimestre;

            anio = valor1;
            trimestre = valor2;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Complete mes de búsqueda");

            }
        }
    }
}
