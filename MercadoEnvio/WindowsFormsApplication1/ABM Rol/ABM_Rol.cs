﻿using System;
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
    public partial class Pantalla_ABM_Rol : Form
    {
        public Pantalla_ABM_Rol()
        {
            InitializeComponent();
        }

        private void Boton_Crear_Rol_Click(object sender, EventArgs e)
        {

            PantallaCrearRol pantallCrearRol = new PantallaCrearRol();
            pantallCrearRol.ShowDialog();
          
        }

        private void Boton_Mod_Rol_Click(object sender, EventArgs e)
        {
 
            PantallaModificarRol pantallaModRol = new PantallaModificarRol();
            pantallaModRol.ShowDialog();
           
        }

        private void Boton_Eliminar_Rol_Click(object sender, EventArgs e)
        {

            PantallaEliminarRol pantallaReliminarRol = new PantallaEliminarRol();
            pantallaReliminarRol.ShowDialog();
      
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();


        }
    }
}
