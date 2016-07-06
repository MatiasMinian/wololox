using System;
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
    public partial class PantallaEliminarRol : Form
    {
        GD1C2016DataSetTableAdapters.rolesTableAdapter rolAdapter = new GD1C2016DataSetTableAdapters.rolesTableAdapter();
        public PantallaEliminarRol()
        {
            InitializeComponent();
            GD1C2016DataSet.rolesDataTable dataRol = rolAdapter.GetData();
            comboRoles.DataSource = dataRol;
            comboRoles.DisplayMember = "nombre";
            comboRoles.ValueMember = "id";

        }

        private void Boton_Cancelar_Eliminar_Rol_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Boton_Eliminar_Rol_Click(object sender, EventArgs e)
        {
            if (comboRoles.Text == "")
            {
                MessageBox.Show("Ingresa rol a eliminar");
            }
            else
            {
                rolAdapter.inhabilitarRol((decimal)comboRoles.SelectedValue);
                MessageBox.Show("Rol bloqueado");
            }
        }
    }

}
