﻿using System;
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
    public partial class Pantalla_Usuario_Principal : Form
    {
        public Pantalla_Usuario_Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_Creacion_Usuario pantallaCreacionUser = new Pantalla_Creacion_Usuario();
            this.Hide();
            pantallaCreacionUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Modificacion_Usuario pantallaModificacion = new Pantalla_Modificacion_Usuario();
            this.Hide();
            pantallaModificacion.Show();
        }

    
    }
}