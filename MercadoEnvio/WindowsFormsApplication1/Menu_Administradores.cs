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
using WindowsFormsApplication1.ABM_Visibilidad;
using WindowsFormsApplication1.Facturas;

namespace WindowsFormsApplication1
{
    public partial class Menu_Administradores : Form
    {
        public Menu_Administradores()
        {
            InitializeComponent();

        }

        public void matchearUsuario(String usuario)
        {

            label2.Text = usuario+"!!";

        }


        private void botonUser_Click(object sender, EventArgs e)
        {
            Pantalla_Usuario_Principal pantallaUsuarioPrincipal = new Pantalla_Usuario_Principal();
            pantallaUsuarioPrincipal.ShowDialog();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonVisibilidad_Click(object sender, EventArgs e)
        {

        }

        private void crearRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaCrearRol pantallCrearRol = new PantallaCrearRol();
            pantallCrearRol.ShowDialog();
        }

        private void modificarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaModificarRol pantallaModRol = new PantallaModificarRol();
            pantallaModRol.ShowDialog();
        }

        private void eliminarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaEliminarRol pantallaReliminarRol = new PantallaEliminarRol();
            pantallaReliminarRol.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_Datos_Cliente pantallaAltaCliente = new Pantalla_Datos_Cliente();
            pantallaAltaCliente.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_Datos_Empresa pantallaAltaEmpresa = new Pantalla_Datos_Empresa();
            pantallaAltaEmpresa.ShowDialog();

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Pantalla_Modificacion_Datos_Cliente pantallaModifDatosCliente = new Pantalla_Modificacion_Datos_Cliente();
            //pantallaModifDatosCliente.ShowDialog();
        }

        private void contraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void habilitarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_Habilitacion_Rol pantallaHabilitacionRol = new Pantalla_Habilitacion_Rol();
            pantallaHabilitacionRol.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Cliente_A_Modificar pantallaClienteAmodificar = new Pantalla_Busqueda_Cliente_A_Modificar();
            pantallaClienteAmodificar.ShowDialog();
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Empresa_A_Modificar pantallaEmpresaAmodificar = new Pantalla_Busqueda_Empresa_A_Modificar();
            pantallaEmpresaAmodificar.ShowDialog();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Cliente_A_Eliminar pantallaClienteAeliminar = new Pantalla_Busqueda_Cliente_A_Eliminar();
            pantallaClienteAeliminar.ShowDialog();
        }

        private void empresaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Empresa_A_Eliminar pantallaEmpresaAeliminar = new Pantalla_Busqueda_Empresa_A_Eliminar();
            pantallaEmpresaAeliminar.ShowDialog();
        }

        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Cliente_A_Habilitar pantallaClienteAhabilitar = new Pantalla_Busqueda_Cliente_A_Habilitar();
            pantallaClienteAhabilitar.ShowDialog();
        }

        private void empresaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pantalla_Busqueda_Empresa_A_Habilitar pantallaEmpresaAhabilitar = new Pantalla_Busqueda_Empresa_A_Habilitar();
            pantallaEmpresaAhabilitar.ShowDialog();
        }

        private void crearVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaVisibilidad pantallaCreacionVisibilidad = new AltaVisibilidad();
            pantallaCreacionVisibilidad.ShowDialog();
        }

        private void modificarVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifVisibilidad pantallaModifVisibilidad = new ModifVisibilidad();
           pantallaModifVisibilidad.ShowDialog();
        }

        private void clienteToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            Pantalla_Busqueda_Cliente_A_Modificar_Password pantallaBusquedaCLpass = new Pantalla_Busqueda_Cliente_A_Modificar_Password();
            pantallaBusquedaCLpass.ShowDialog();


        }

        private void empresaToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            Pantalla_Busqueda_Empresa_A_Modificar_Password pantallaBusquedaEpass = new Pantalla_Busqueda_Empresa_A_Modificar_Password();
            pantallaBusquedaEpass.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarVisibilidad pantallaEliminacion = new EliminarVisibilidad();
            pantallaEliminacion.ShowDialog();
        }

        private void consultarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_Consultar_Facturas pantallaFactu = new Pantalla_Consultar_Facturas();
            pantallaFactu.ShowDialog();
        }

  
    }
}
