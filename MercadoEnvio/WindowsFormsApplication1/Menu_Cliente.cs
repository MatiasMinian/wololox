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

namespace WindowsFormsApplication1
{
    public partial class Menu_Cliente : Form
    {
        private String user;

        public Menu_Cliente()
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
        }

        public void matchearUsuario(String usuario){

            user = usuario;
           labelUsuario.Text = usuario+"!!";

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

        private void botonFacturas_Click(object sender, EventArgs e)
        {
            Pantalla_Consultar_Facturas pantallaFacturas = new Pantalla_Consultar_Facturas();
            pantallaFacturas.guardaDatos(user);
            pantallaFacturas.ShowDialog();
        }

        private void botonEstadisticas_Click(object sender, EventArgs e)
        {
            Pantalla_Listado_Estadistico_Principal pantallaListadoE = new Pantalla_Listado_Estadistico_Principal();
            pantallaListadoE.ShowDialog();
        }
    }
}
