using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Facturas
{
    public partial class Pantalla_Mostrar_Factura : Form
    {
        private GD1C2016DataSetTableAdapters.facturasTableAdapter factuAdapter;
        private GD1C2016DataSet.facturasDataTable factuData;
        private int nro_fact;
        private Decimal total;

        public Pantalla_Mostrar_Factura(int id_compra,Decimal cod_publi,DateTime fechaCompra)
        {
            InitializeComponent();

            factuAdapter = new GD1C2016DataSetTableAdapters.facturasTableAdapter();
            factuData = new GD1C2016DataSet.facturasDataTable();

            factuData = factuAdapter.busquedaDeFacturas(id_compra);

            nro_fact = Convert.ToInt32(factuData[0][0]);
            total = Convert.ToDecimal(factuData[0][5]);


            dataGridView1.Rows.Add(nro_fact, id_compra, cod_publi, fechaCompra, total);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
