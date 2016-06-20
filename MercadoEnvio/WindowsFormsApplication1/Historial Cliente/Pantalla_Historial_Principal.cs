using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class Pantalla_Historial_Principal : Form
    {

        private Decimal maxPages = 10;
        private Decimal idUser;
        private GD1C2016DataSetTableAdapters.comprasTableAdapter comprasAdapter;
        private GD1C2016DataSet.comprasDataTable comprasData;

        public Pantalla_Historial_Principal()
        {
            InitializeComponent();
        }

        public void generarListado(String user)
        {
            GD1C2016DataSetTableAdapters.usuariosTableAdapter usuAdapter = new GD1C2016DataSetTableAdapters.usuariosTableAdapter();
            GD1C2016DataSet.usuariosDataTable usuData = new GD1C2016DataSet.usuariosDataTable();
            usuData = usuAdapter.consultaID(user);

            idUser = Convert.ToDecimal(usuData[0][0]);

            comprasAdapter = new GD1C2016DataSetTableAdapters.comprasTableAdapter();
            comprasData = comprasAdapter.busquedaDeComprasYsubastas(idUser);

            foreach(DataRow row in comprasData.Rows){

                 dataGridView2.Rows.Add(row.Field<Decimal>("codigo"),
                                       row.Field<String>("descripcion"),
                                       row.Field<Decimal>("cantidad"),
                                       row.Field<Decimal>("precio"),
                                       row.Field<String>("tipo"),
                                       row.Field<DateTime>("fecha"),
                                       row.Field<Object>("estrellas"),
                                       row.Field<String>("nombre_usuario"));


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



    }

}