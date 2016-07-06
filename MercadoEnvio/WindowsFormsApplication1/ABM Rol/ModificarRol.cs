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
            comboRol.SelectedIndex = -1;
            comboRol.DisplayMember = "nombre";
            comboRol.ValueMember = "id";
            comboFunc.DisplayMember = "nombre";
            comboFunc.ValueMember = "id";
            listFunc.DisplayMember = "nombre";
            listFunc.ValueMember = "id";
            textNombre.Text = "";
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            textNombre.Text = comboRol.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcXRolAdapter.removerFuncXRol(Convert.ToDecimal(listFunc.SelectedValue), Convert.ToDecimal(comboRol.SelectedValue));
            GD1C2016DataSet.funcionalidadesDataTable infoFuncNo = funcAdapter.GetDataByFuncSinRol((decimal)comboRol.SelectedValue);
            comboFunc.DataSource = infoFuncNo;
            GD1C2016DataSet.funcionalidadesDataTable infoFuncSi = funcAdapter.GetDataByFuncDelRol((decimal)comboRol.SelectedValue);
            listFunc.DataSource = infoFuncSi;
            MessageBox.Show("Funcionalidad eliminada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcXRolAdapter.insertarFuncXRol(Convert.ToDecimal(comboFunc.SelectedValue), Convert.ToDecimal(comboRol.SelectedValue));
            GD1C2016DataSet.funcionalidadesDataTable infoFuncNo = funcAdapter.GetDataByFuncSinRol((decimal)comboRol.SelectedValue);
            comboFunc.DataSource = infoFuncNo;
            GD1C2016DataSet.funcionalidadesDataTable infoFuncSi = funcAdapter.GetDataByFuncDelRol((decimal)comboRol.SelectedValue);
            listFunc.DataSource = infoFuncSi;
            MessageBox.Show("Funcionalidad agregada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textNombre.Text = comboRol.Text;
            GD1C2016DataSet.funcionalidadesDataTable infoFuncNo = funcAdapter.GetDataByFuncSinRol((decimal)comboRol.SelectedValue);
            comboFunc.DataSource = infoFuncNo;
            GD1C2016DataSet.funcionalidadesDataTable infoFuncSi = funcAdapter.GetDataByFuncDelRol((decimal)comboRol.SelectedValue);
            listFunc.DataSource = infoFuncSi;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rolAdapter.cambiarNombreRol(Convert.ToDecimal(comboRol.SelectedValue), textNombre.Text);
            MessageBox.Show("Nombre cambiado");
            GD1C2016DataSet.rolesDataTable rolData = rolAdapter.GetData();
            comboRol.DataSource = rolData;
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            if (textNombre.Text == comboRol.Text)
            {
                button4.Enabled = false;
            }
        }



    }

}