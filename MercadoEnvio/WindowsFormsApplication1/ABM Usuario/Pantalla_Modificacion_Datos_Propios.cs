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
    public partial class Pantalla_Modificacion_Datos_Propios : Form
    {
        private string usuario;
        private string rol;
        private GD1C2016DataSetTableAdapters.usuariosTableAdapter usrAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
        public Pantalla_Modificacion_Datos_Propios(String user, String nombreRol)
        {
            InitializeComponent();
            this.usuario = user;
            this.rol = nombreRol;
        }

        private void botonPass_Click(object sender, EventArgs e)
        {
            Pantalla_Modificación_Password modifPass = new Pantalla_Modificación_Password(usuario);
            modifPass.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonModif_Click(object sender, EventArgs e)
        {
            decimal id = (Decimal) usrAdapter.consultaID(usuario);
            if (rol == "Cliente")
            {
                Pantalla_Modificacion_Datos_Cliente menu = new Pantalla_Modificacion_Datos_Cliente(id);
                menu.ShowDialog();
            }
            else if (rol == "Empresa")
            {
                Pantalla_Modificacion_Datos_Empresa menu = new Pantalla_Modificacion_Datos_Empresa(id);
                menu.ShowDialog();
            }
            else
            {
                //Pantalla_Modificacion_Datos_RolGenerico menu = new Pantalla_Modificacion_Datos_RolGenerico(id,rol);
                //menu.ShowDialog();
            }
        }
    }
}
