﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class Pantalla_Historial_Cantidad_Segun_Estrellas : Form
    {
        public Pantalla_Historial_Cantidad_Segun_Estrellas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Historial_Principal pantallaHistoPrinci = new Pantalla_Historial_Principal();
            this.Close();
            pantallaHistoPrinci.Show();
        }
    }
}