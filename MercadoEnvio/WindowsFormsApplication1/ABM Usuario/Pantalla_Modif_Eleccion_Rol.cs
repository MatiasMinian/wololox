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
    public partial class Pantalla_Modif_Eleccion_Rol : Form
    {
        private GD1C2016DataSetTableAdapters.rolesTableAdapter rolAdapter = new GD1C2016DataSetTableAdapters.rolesTableAdapter();
        public Pantalla_Modif_Eleccion_Rol()
        {
            InitializeComponent();
        }

        private void Pantalla_Modif_Eleccion_Rol_Load(object sender, EventArgs e)
        {
            rolAdapter.Fill(this.gD1C2016DataSet.roles);   
        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRol.SelectedIndex < 0)
            {
                botonAceptar.Enabled = false;
            }
            else
            {
                botonAceptar.Enabled = true;
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (comboRol.SelectedText == "Cliente")
            {
                Pantalla_Busqueda_Cliente_A_Modificar menu = new Pantalla_Busqueda_Cliente_A_Modificar();
                menu.ShowDialog();
                this.Close();
            }
            else if (comboRol.SelectedText == "Empresa"){
                Pantalla_Busqueda_Empresa_A_Modificar menu = new Pantalla_Busqueda_Empresa_A_Modificar();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                Pantalla_Busqueda_RolGenerico_A_Modificar menu = new Pantalla_Busqueda_RolGenerico_A_Modificar();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
