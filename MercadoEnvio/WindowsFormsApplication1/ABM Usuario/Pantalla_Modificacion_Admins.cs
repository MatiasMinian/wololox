﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Pantalla_Modificacion_Admins : Form
    {
        public Pantalla_Modificacion_Admins()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla_Habilitacion_Rol pantallaHabilitacionRol = new Pantalla_Habilitacion_Rol();
            pantallaHabilitacionRol.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
