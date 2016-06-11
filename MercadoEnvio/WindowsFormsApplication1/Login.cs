using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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
                SHA256 CriptoPass = SHA256Managed.Create();
                byte[] valorHash;
                valorHash = CriptoPass.ComputeHash(obtenerNumBytes(textoPass.Text));

                switch ((int)(adapterUsuarios.login(textoUser.Text, textoPass.Text))){
                    case 0: MessageBox.Show("Usuario/Contraseña incorrectos!");
                        break;
                    case 1: loguearse(textoUser.Text);
                        break;
                    case 2: MessageBox.Show("Usuario bloqueado!");
                        break;
                }
                

                
               Menu_Administradores menu = new Menu_Administradores();
                menu.matchearUsuario(textoUser.Text);
                this.Hide();
                menu.ShowDialog();
                this.Close();
                this.Dispose();

            }

        }

        private void loguearse(string User)
        {
            if ((int)adapterUsuarios.cantidadRoles(User) > 1)
            {
                SeleccionRol pantallaSeleccion = new SeleccionRol();
                //A revisar dsp
            }
            else
            {
                switch ((String)adapterUsuarios.obtenerRol(User)){
                    case "Empresa": Menu_Empresa menu = new Menu_Empresa();
                        break;
                    case "Cliente": Menu_Cliente menu2 = new Menu_Cliente();
                        break;
                    //Ver que hacer con nuevos roles, ver cambiar este malicioso switch
                }
            }
            
        }

        static byte[] obtenerNumBytes(string input)
        {
            byte[] bytes = new byte[input.Length * sizeof(char)];
            System.Buffer.BlockCopy(input.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

    }

}