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

               // Pantalla_Funcionalidades menu = new Pantalla_Funcionalidades();
               // Menu_Administradores menu = new Menu_Administradores();
                menu.matchearUsuario(textoUser.Text);
                this.Hide();
                menu.ShowDialog();
                this.Close();
                this.Dispose();
            }

        }
        
    }

}
/*
        //Hashear contraseña
        try
        {
            SHA256 CriptoPass = SHA256Managed.Create();
            byte[] valorHash;
            valorHash = CriptoPass.ComputeHash(obtenerNumBytes(textoPass.Text));
            if (Convert.ToBoolean(adapterUsuarios.login(textoUser.Text, Convert.ToString(valorHash))))
            {
                Menu_Cliente menu = new Menu_Cliente();
                //Menu_Administradores menu = new Menu_Administradores();
                menu.matchearUsuario(textoUser.Text);
                this.Hide();
                menu.ShowDialog();
                this.Close();
                this.Dispose();
            }


       switch ((int)(adapterUsuarios.login(textoUser.Text, textoPass.Text))){
            case 0: MessageBox.Show("Usuario/Contraseña incorrectos!");
                break;
            case 1: loguearse(textoUser.Text);
                break;
            case 2: MessageBox.Show("Usuario bloqueado!");
                break;
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
            }
        }

    }

}
                  
        
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
          
       Pantalla_Funcionalidades pantallaFunci = new Pantalla_Funcionalidades((String)adapterUsuarios.obtenerRol(User));
       pantallaFunci.ShowDialog();

    }

}

static byte[] obtenerNumBytes(string input)
{
    byte[] bytes = new byte[input.Length * sizeof(char)];
    System.Buffer.BlockCopy(input.ToCharArray(), 0, bytes, 0, bytes.Length);
    return bytes;
}

}

}*/