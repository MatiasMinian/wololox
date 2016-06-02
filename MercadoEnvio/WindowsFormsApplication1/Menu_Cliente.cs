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

namespace WindowsFormsApplication1
{
    public partial class Menu_Cliente : Form
    {

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

        public Menu_Cliente(String usuario) : this()
        {
           labelUsuario.Text = usuario;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void botonCalificar_Click(object sender, EventArgs e)
        {
            Pantalla_Calificacion_Principal pCali = new Pantalla_Calificacion_Principal();
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
            pantallaHistorial.ShowDialog();
     
        }

        private void botonRol_Click(object sender, EventArgs e)
        {
            Pantalla_ABM_Rol pantallaRubroPrincipal = new Pantalla_ABM_Rol();
            pantallaRubroPrincipal.ShowDialog();

       
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pantalla_Modificacion_Principal_Cliente pantallaModificacion = new Pantalla_Modificacion_Principal_Cliente();
            pantallaModificacion.ShowDialog();
        }

        private void botonCompra_Click(object sender, EventArgs e)
        {
            
            FormComprayOferta pantallaCompra = new FormComprayOferta();
            pantallaCompra.ShowDialog();
        }

        private void botonPublic_Click(object sender, EventArgs e)
        {
            Pantalla_Generar_Publicación_Principal pantallaGeneracionPubliPrincipal = new Pantalla_Generar_Publicación_Principal();
            pantallaGeneracionPubliPrincipal.ShowDialog();
        }
    }
}
