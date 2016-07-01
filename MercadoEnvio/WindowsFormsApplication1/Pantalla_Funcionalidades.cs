using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.Historial_Cliente;
using WindowsFormsApplication1.ComprarOfertar;
using WindowsFormsApplication1.Generar_Publicación;
using WindowsFormsApplication1.Facturas;
using WindowsFormsApplication1.Listado_Estadistico;
using WindowsFormsApplication1.ABM_Visibilidad;

namespace WindowsFormsApplication1
{
    public partial class Pantalla_Funcionalidades : Form
    {

       private GD1C2016DataSetTableAdapters.funcionalidadesTableAdapter funciAdapter;
       private GD1C2016DataSet.funcionalidadesDataTable funciData;
       private String user;

        public Pantalla_Funcionalidades(String rol)
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Anchor = AnchorStyles.None;
                    control.Left = (control.Parent.Width + 150 - control.Width) / 2;
                }
            }

            funciAdapter = new GD1C2016DataSetTableAdapters.funcionalidadesTableAdapter();
            funciData = new GD1C2016DataSet.funcionalidadesDataTable();

            funciData = funciAdapter.traerFuncionalidades(rol);

            foreach(DataRow row in funciData.Rows){

                switch (Convert.ToString(row.Field<String>("nombre")))
                {

                    case "ABM visibilidades": botonVisi.Enabled = true;
                                        break;

                    case "ABM roles": botonRoles.Enabled = true;
                                        break;

                    case "ABM usuarios": botonUsuarios.Enabled = true;
                                        break;

                    case "Generar publicacion": botonPublic.Enabled = true;
                                        break;

                    case "Comprar/ofertar": botonCompra.Enabled = true;
                                        break;

                    case "Historial cliente": botonHistorial.Enabled = true;
                                        break;

                    case "Calificar vendedor": botonCalificar.Enabled = true;
                                        break;

                    case "Listado estadistico": botonEstadisticas.Enabled = true;
                                        break;

                    case "Consulta facturas": botonFacturas.Enabled = true;
                                        break;

                    case "Modificacion usuario": botonDatos.Enabled = true;
                                        break;

                    case "Modificacion publicacion": botonMPubli.Enabled = true;
                                        break;

                }

            }
        }

        public void matchearUsuario(String usuario){

            user = usuario;
           label2.Text = usuario+"!!";

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void botonCalificar_Click(object sender, EventArgs e)
        {
            Pantalla_Calificacion_Principal pCali = new Pantalla_Calificacion_Principal();
            pCali.generarListado(user); 
            pCali.ShowDialog();
             

        }

        private void botonUser_Click(object sender, EventArgs e)
        {
            Pantalla_Usuario_Principal pantallaUserPrincipal = new Pantalla_Usuario_Principal();
            pantallaUserPrincipal.Show();
    
        }

        private void botonHistorial_Click(object sender, EventArgs e)
        {
            Pantalla_Historial_Principal pantallaHistorial = new Pantalla_Historial_Principal();

            pantallaHistorial.generarListado(user);
            pantallaHistorial.ShowDialog();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pantalla_Modificacion_Principal_Cliente pantallaModificacion = new Pantalla_Modificacion_Principal_Cliente();
            pantallaModificacion.guardarDatos(user);
            pantallaModificacion.ShowDialog();
        }

        private void botonCompra_Click(object sender, EventArgs e)
        {
            
            FormComprayOferta pantallaCompra = new FormComprayOferta();
            pantallaCompra.guardaDatos(user);
            pantallaCompra.ShowDialog();
        }

        private void botonPublic_Click(object sender, EventArgs e)
        {
            Pantalla_Generar_Publicación_Principal pantallaGeneracionPubliPrincipal = new Pantalla_Generar_Publicación_Principal();
            pantallaGeneracionPubliPrincipal.guardarDatos(user);
            pantallaGeneracionPubliPrincipal.ShowDialog();
        }

        private void botonEstadisticas_Click(object sender, EventArgs e)
        {
            Pantalla_Listado_Estadistico_Principal pantallaListadoE = new Pantalla_Listado_Estadistico_Principal();
            pantallaListadoE.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void botonMPubli_Click(object sender, EventArgs e)
        {
            Pantalla_Modificacion_Publicaciones pantallaMPubli = new Pantalla_Modificacion_Publicaciones();
            pantallaMPubli.ShowDialog();
        }

        private void botonVisi_Click(object sender, EventArgs e)
        {
            Pantalla_Visibilidad_Principal pantallaVisi = new Pantalla_Visibilidad_Principal();
            pantallaVisi.ShowDialog();
        }

        private void botonRoles_Click(object sender, EventArgs e)
        {
            Pantalla_Rol_Principal pantallaRol = new Pantalla_Rol_Principal();
            pantallaRol.ShowDialog();

        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            Pantalla_Usuario_Principal pantallaUsuario = new Pantalla_Usuario_Principal();
            pantallaUsuario.ShowDialog();
        }

    }
}
