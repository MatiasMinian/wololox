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
    public partial class Pantalla_Selección_De_Rol_Login : Form
    {
        public Pantalla_Selección_De_Rol_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MessageBox.Show("Selecciona rol");

            }
            else if (comboBox1.Text == "Cliente")
            {

                Menu_Cliente menuCliente = new Menu_Cliente();
                menuCliente.ShowDialog();

            }
            else
            {

                Menu_Empresa menuEmpresa = new Menu_Empresa();
                menuEmpresa.ShowDialog();

            }
        }
    }
}
