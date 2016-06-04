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

                //Seleccionar por ahora para probar
               //Menu_Cliente menu = new Menu_Cliente();
                //Menu_Empresa menu = new Menu_Empresa();
               Menu_Administradores menu = new Menu_Administradores();
                menu.matchearUsuario(textoUser.Text);
                this.Hide();
                menu.ShowDialog();
                this.Close();
                this.Dispose();

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