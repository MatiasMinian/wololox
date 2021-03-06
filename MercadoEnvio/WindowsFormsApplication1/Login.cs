﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormularioLogin : Form
    {
        GD1C2016DataSetTableAdapters.usuariosTableAdapter adapterUsuarios = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();

        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void botonLimpieza_Click(object sender, EventArgs e)
        {
            textoPass.Text = "";
            textoUser.Text = "";
        }

        private void botonIngreso_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textoUser.Text) && string.IsNullOrWhiteSpace(textoPass.Text))
            {

                MessageBox.Show("Ingresa usuario y contraseña");

            }

            else if (string.IsNullOrWhiteSpace(textoUser.Text))
            {

                MessageBox.Show("Ingresa usuario");

            }
            else if (string.IsNullOrWhiteSpace(textoPass.Text))
            {

                MessageBox.Show("Ingresa contraseña");

            }

            else
            {

                //Hashear contraseña
                try
                {
                    SHA256 CriptoPass = SHA256Managed.Create();
                    byte[] valorHash;
                    valorHash = CriptoPass.ComputeHash(Encoding.UTF8.GetBytes(textoPass.Text));
                    if (Convert.ToBoolean(adapterUsuarios.login(textoUser.Text, textoPass.Text)))
                    {
                        if ((int)adapterUsuarios.cantidadRoles(textoUser.Text) > 1)
                        {
                            SeleccionRol seleccionRol = new SeleccionRol(textoUser.Text);
                            seleccionRol.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            GD1C2016DataSet.usuariosDataTable infoRol = adapterUsuarios.ObtenerRol(textoUser.Text);
                            Pantalla_Funcionalidades pantallaFunci = new Pantalla_Funcionalidades(infoRol.Rows[0].Field<String>("nombre"));
                            pantallaFunci.matchearUsuario(textoUser.Text);
                            pantallaFunci.ShowDialog();
                            this.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 40003:
                            MessageBox.Show("Password incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        case 40002:
                            MessageBox.Show("Usuario Bloqueado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        case 40001:
                            MessageBox.Show("El Usuario no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        default: MessageBox.Show("Error desconocido"+ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                    }
                }
            }
        }

        /*static byte[] obtenerNumBytes(string input)
        {
            byte[] bytes = new byte[input.Length * sizeof(char)];
            System.Buffer.BlockCopy(input.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }*/

    }

}