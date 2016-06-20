using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //publiAdapter.actualizarPublicacionesVencidas(appDate);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioLogin());
        }

    }
}
