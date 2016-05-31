using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class FormSelecRubro : Form
    {
        private List<string> rubros;
        private FormComprayOferta formComprayOferta;


        public FormSelecRubro(List<string> rubros, FormComprayOferta formComprayOferta)
        {
            InitializeComponent();
            this.rubros = rubros;
            this.formComprayOferta = formComprayOferta;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {   
            int seleccionadas = tablaRubros.GetCellCount(DataGridViewElementStates.Selected);
            if (seleccionadas > 0){
                for(int i=0;i<seleccionadas;i++){
                    this.rubros.Add(tablaRubros.SelectedCells[i].Value.ToString());
                }
                this.Close();
                formComprayOferta.asignarRubros(rubros);
            }
            else
            {
                MessageBox.Show("Seleccione al menos un rubro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaRubros.Rows.Add("Jardinería");
            tablaRubros.Rows.Add("Computación");
            tablaRubros.Rows.Add("Hogar");
            tablaRubros.Rows.Add("Ropa");
            tablaRubros.Rows.Add("Celulares");
        }
    }
}
