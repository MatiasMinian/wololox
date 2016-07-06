using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SeleccionRol : Form
    {
        GD1C2016DataSetTableAdapters.usuariosTableAdapter adapterUsuarios = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        private String user;

        public SeleccionRol(String usuario)
        {
            InitializeComponent();
            botonIngreso.Enabled = false;
            matchearUsuario(usuario);
            GD1C2016DataSet.usuariosDataTable infoRoles = adapterUsuarios.ObtenerRol(usuario);
            comboRoles.SelectedIndex = -1;
            foreach (DataRow row in infoRoles.Rows)
            {
                comboRoles.Items.Add(row.Field<String>("nombre"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_Funcionalidades pantallaFuncio = new Pantalla_Funcionalidades(comboRoles.Text);
            pantallaFuncio.matchearUsuario(user);
            pantallaFuncio.ShowDialog();
            this.Close();
        }

        internal void matchearUsuario(string User)
        {
            user = User;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoles.SelectedIndex != 0)
            {
                botonIngreso.Enabled = true;
            }
        }
    }
}
