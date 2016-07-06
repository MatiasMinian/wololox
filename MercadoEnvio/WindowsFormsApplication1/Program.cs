using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Listado_Estadistico;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Rol;

namespace WindowsFormsApplication1
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();

            var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

            var appDate = DateTime.Parse(value);

            //publiAdapter.ActualizarPublicacionesVencidas(appDate);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioLogin());
            //Application.Run(new Pantalla_Funcionalidades("Administrador"));

        }

    }
}
