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
        public PantallaCrearRol()
        {
            InitializeComponent();
            listaFunc.Items.Add("ABM de roles");
            listaFunc.Items.Add("ABM de usuarios");
            listaFunc.Items.Add("ABM de visibilidades");
            listaFunc.Items.Add("Generar publicación");
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

        }


    }
}
