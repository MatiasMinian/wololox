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
    public partial class PantallaCrearRol : Form
    {
        GD1C2016DataSetTableAdapters.funcionalidadesTableAdapter funcAdapter = new GD1C2016DataSetTableAdapters.funcionalidadesTableAdapter();
        GD1C2016DataSetTableAdapters.rolesTableAdapter rolAdapter = new GD1C2016DataSetTableAdapters.rolesTableAdapter();
        GD1C2016DataSetTableAdapters.funcionalidades_rolesTableAdapter funcXRolAdapter = new GD1C2016DataSetTableAdapters.funcionalidades_rolesTableAdapter();

        public PantallaCrearRol()
        {
            InitializeComponent();
            GD1C2016DataSet.funcionalidadesDataTable funcData = funcAdapter.GetData();
            listaFunc.DataSource = funcData;
            listaFunc.DisplayMember = "nombre";
            listaFunc.ValueMember = "id";
            listaFunc.TopIndex = 0;
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Boton_Crear_Click(object sender, EventArgs e)
        {
            if (textNomRol.Text == "" && listaFunc.SelectedItems.Count==0)
            {

                MessageBox.Show("Ingrese nombre de rol a crear y seleccione al menos una funcionalidad");
            }
            else if (textNomRol.Text == "")
            {

                MessageBox.Show("Ingrese nombre de rol a crear");

            }
            else if (listaFunc.SelectedItems.Count==0)
            {

                MessageBox.Show("Seleccione funcionalidades de rol a crear");

            }
            else
            {
                rolAdapter.insertarRol(textNomRol.Text);
                decimal idRol = rolAdapter.GetData().Last().id;
                foreach (object func in listaFunc.SelectedItems)
                {
                    funcXRolAdapter.insertarFuncXRol((decimal)listaFunc.SelectedValue, idRol);
                }
                this.Close();
            }
        }


    }
}
