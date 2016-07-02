using System;
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
    public partial class Pantalla_Datos_Rol_Generico : Form
    {
        private String idUsuario;
        private String contraseña;
        private String idRol;

        public Pantalla_Datos_Rol_Generico(String id, String pass, String idRol)
        {
            InitializeComponent();
            this.idUsuario = id;
            this.contraseña = pass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNom.ResetText();
            textTel.ResetText();
            texDom.ResetText();
            textNumDom.ResetText();
            textMail.ResetText();
            textPiso.ResetText();
            textDepto.ResetText();
            textLoc.ResetText();
            textPost.ResetText();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textTel.Text == "" || texDom.Text == "" || textNumDom.Text == "" || textMail.Text == "" || textPiso.Text == ""
               || textDepto.Text == "" || textLoc.Text == "" || textPost.Text == "")
            {

                MessageBox.Show("Complete campos vacíos");

            }
            GD1C2016DataSetTableAdapters.usuariosTableAdapter usrAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            usrAdapter.CrearUsuarioRolGenerico(idUsuario, contraseña, textMail.Text, textTel.Text, texDom.Text, Convert.ToDecimal(textNumDom.Text), Convert.ToDecimal(textPiso.Text), textDepto.Text, textLoc.Text, textCiudad.Text, textPost.Text);
            MessageBox.Show("Usuario creado");
        }
    }
}
