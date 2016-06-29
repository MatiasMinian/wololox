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
    public partial class PantallaModificarRol : Form
    {
        GD1C2016DataSetTableAdapters.rolesTableAdapter rolAdapter = new GD1C2016DataSetTableAdapters.rolesTableAdapter();
        GD1C2016DataSetTableAdapters.funcionalidadesTableAdapter funcAdapter = new GD1C2016DataSetTableAdapters.funcionalidadesTableAdapter();
        GD1C2016DataSetTableAdapters.funcionalidades_rolesTableAdapter funcXRolAdapter = new GD1C2016DataSetTableAdapters.funcionalidades_rolesTableAdapter();
        public PantallaModificarRol()
        {
            InitializeComponent();
            GD1C2016DataSet.rolesDataTable rolData = rolAdapter.GetData();
            comboRol.DataSource = rolData;
            comboRol.DisplayMember = "nombre";
            comboRol.DisplayMember = "id";
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            if (comboRol.Text == "" && textNombre.Text == "" && listFunc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ingresa rol ,nombre y selecciona funcionalidades a modificar");
            }
            else if (comboRol.Text == "" && textNombre.Text == "")
            {
                MessageBox.Show("Ingresa rol y nombre a modificar");
            }
            else if (comboRol.Text == "" && listFunc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ingresa rol y selecciona funcionalidades a modificar");
            }
            else if (textNombre.Text == "" && listFunc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ingresa nombre y selecciona funcionalidades a modificar");
            }
            else if (textNombre.Text == "")
            {
                MessageBox.Show("Ingresa nombre a modificar");
            }else if (comboRol.Text == ""){
                MessageBox.Show("Ingresa rol a modificar");
            }else if (listFunc.SelectedItems.Count==0){
                MessageBox.Show("Selecciona funcionalidades a modificar");
            }
            else
            {
                rolAdapter.borrarTodasFunciones((decimal) comboRol.SelectedValue);
                foreach (object func in listFunc.Items)
                {
                    DataRowView funcionalidad = (DataRowView)func;
                    funcXRolAdapter.insertarFuncXRol((decimal)funcionalidad["id"], (decimal)comboRol.SelectedValue);
                }
                this.Close();
            }
           

        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            textNombre.Text = comboRol.SelectedText;
            comboFunc.DataSource = funcAdapter.FillByRolSinFunc(funcAdapter.GetData(), (decimal) comboRol.SelectedValue);
            listFunc.DataSource = funcAdapter.FillByRolConFunc(funcAdapter.GetData(), (decimal)comboRol.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listFunc.Items.Remove(comboFunc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listFunc.Items.Add(comboFunc);
        }

 

    }

}